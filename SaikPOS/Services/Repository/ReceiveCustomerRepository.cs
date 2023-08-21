using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class ReceiveCustomerRepository : IReceiveCustomer
    {
       private readonly ApplicationDbContext _context;
       private readonly DatabaseConnection _conn;
        public ReceiveCustomerRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public string GetReceiveVoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM ReceiptMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherTypeId=@VoucherTypeId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public bool CheckReceiveCustomer(string voucherNo, long companyId, long financialYearId, long VoucherTypeId)
        {
            var checkAccountCount = (from progm in _context.ReceiptMaster
                                     where progm.VoucherNo == voucherNo && progm.CompanyId == companyId && progm.FinancialYearId == financialYearId && progm.VoucherTypeId == VoucherTypeId
                                     select progm.ReceiptMasterId).Count();
            if (checkAccountCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<ReceiptMaster> GetReceiptMasterView(long DetailsId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@DetailsId", DetailsId);
                var ListofPlan = sqlcon.Query<ReceiptMaster>("SELECT VoucherNo,NepaliDate,Date,TotalAmount,CashAmount + BankAmount as CashAmount FROM ReceiptMaster where DetailsId=@DetailsId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<PaymentReceiveView> ViewAllReceiveCustomer(long LedgerId, long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@LedgerId", LedgerId);
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                var ListofPlan = sqlcon.Query<PaymentReceiveView>("ReceiveCustomerlist", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public ReceiptMaster EditReceiveCustomer(long ReceiptMasterId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("ReceiptMasterId", ReceiptMasterId, DbType.String);

            ReceiptMaster employee = new ReceiptMaster();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirstOrDefault<ReceiptMaster>("SELECT *FROM ReceiptMaster where ReceiptMasterId=@ReceiptMasterId", parameters, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return employee;
        }
        public bool ReceiveCustomerDelete(string VoucherNo, long VoucherTypeId, long FinancialYearId, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("ReceiveCustomerDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@VoucherNo", SqlDbType.NVarChar);
                para.Value = VoucherNo;
                para = cmd.Parameters.Add("@VoucherTypeId", SqlDbType.BigInt);
                para.Value = VoucherTypeId;
                para = cmd.Parameters.Add("@FinancialYearId", SqlDbType.BigInt);
                para.Value = FinancialYearId;
                para = cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                para.Value = CompanyId;
                long rowAffacted = cmd.ExecuteNonQuery();
                if (rowAffacted > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public PaymentSupplierView ReceiveCustomerView(long ReceiptMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@ReceiptMasterId", ReceiptMasterId);
                var result = sqlcon.Query<PaymentSupplierView>("ReceiveCustomerPrint", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
    }
}
