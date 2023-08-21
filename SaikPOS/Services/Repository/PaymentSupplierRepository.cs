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
    public class PaymentSupplierRepository : IPaymentSupplier
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public PaymentSupplierRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<PaymentReceiveView> ViewAllPaymentSupplier(long LedgerId, long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@LedgerId", LedgerId);
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                var ListofPlan = sqlcon.Query<PaymentReceiveView>("Paymentsupplierlist", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public bool CheckPaymentSupplier(string voucherNo, long companyId, long financialYearId, long VoucherTypeId)
        {
            var checkAccountCount = (from progm in _context.PaymentMaster
                                     where progm.VoucherNo == voucherNo && progm.CompanyId == companyId && progm.FinancialYearId == financialYearId && progm.VoucherTypeId == VoucherTypeId
                                     select progm.PaymentMasterId).Count();
            if (checkAccountCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetPaymentVoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM PaymentMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherTypeId=@VoucherTypeId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public PaymentMaster EditPaymentSupplier(long PaymentMasterId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("PaymentMasterId", PaymentMasterId, DbType.String);

            PaymentMaster employee = new PaymentMaster();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirstOrDefault<PaymentMaster>("SELECT *FROM PaymentMaster where PaymentMasterId=@PaymentMasterId", parameters, commandType: CommandType.Text);
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
        public bool DeletePaymentSupplier(string VoucherNo, long VoucherTypeId, long FinancialYearId, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("PaymentMasterDelete", sqlcon);
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
        public List<PurchaseMasterView> GetSupplierPaymentList(long LedgerId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@LedgerId", LedgerId);
                var ListofPlan = sqlcon.Query<PurchaseMasterView>("SupplierPaymentList", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public PaymentSupplierView PaymentSupplierView(long PaymentMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PaymentMasterId", PaymentMasterId);
                var result = sqlcon.Query<PaymentSupplierView>("PaymentSupplierPrint", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
    }
}
