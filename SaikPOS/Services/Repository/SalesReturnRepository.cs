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
    public class SalesReturnRepository : ISalesReturn
    {
        private readonly ApplicationDbContext _context;
        DatabaseConnection _conn;
        public SalesReturnRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<SalesReturnMasterView> ViewAllSalesInvoice(long CompanyId)
        {
            var varlist = (from a in _context.SalesReturnMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == CompanyId
                           select new SalesReturnMasterView
                           {
                               SalesReturnMasterId = a.SalesReturnMasterId,
                               Date = a.Date,
                               VoucherNo = a.VoucherNo,
                               GrandTotal = a.GrandTotal,
                               UserId = a.UserId,
                               CreditAmount = a.CreditAmount,
                               CashAmount = a.CashAmount + a.BankAmount,
                               LedgerName = b.LedgerName,
                               VoucherTypeName = c.VoucherTypeName
                           }).ToList();

            return varlist;
        }
        public SalesReturnMaster EditsalesMaster(long SalesReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesReturnMasterId", SalesReturnMasterId);
                var result = sqlcon.Query<SalesReturnMaster>("SELECT *FROM SalesReturnMaster where SalesReturnMasterId=@SalesReturnMasterId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
        }
        public bool DeleteSalesInvoice(long SalesReturnMasterId, string VoucherNo, long CompanyId, long FinancialYearId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("SalesReturnInvoiceDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@SalesReturnMasterId", SqlDbType.BigInt);
                para.Value = SalesReturnMasterId;
                para = cmd.Parameters.Add("@VoucherNo", SqlDbType.NVarChar);
                para.Value = VoucherNo;
                para = cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                para.Value = CompanyId;
                para = cmd.Parameters.Add("@FinancialYearId", SqlDbType.BigInt);
                para.Value = FinancialYearId;
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
        public string GetSalesvoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM SalesReturnMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherTypeId=@VoucherTypeId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public List<SalesReturnMasterView> ViewAllSalesInvoice(long CompanyId, DateTime FromDate, DateTime ToDate)
        {
            var varlist = (from a in _context.SalesReturnMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == CompanyId && a.Date >= FromDate && a.Date <= ToDate
                           select new SalesReturnMasterView
                           {
                               SalesMasterId = a.SalesMasterId,
                               Date = a.Date,
                               VoucherNo = a.VoucherNo,
                               GrandTotal = a.GrandTotal,
                               UserId = a.UserId,
                               CreditAmount = a.CreditAmount,
                               LedgerName = b.LedgerName,
                               VoucherTypeName = c.VoucherTypeName
                           }).ToList();

            return varlist;
        }
        public bool AccountSalesInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                return sqlcon.Query<bool>("SELECT VoucherNo FROM SalesReturnMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo AND VoucherTypeId='13' ", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public SalesReturnMasterView SalesMasterPrint(long SalesReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesReturnMasterId", SalesReturnMasterId);
                var result = sqlcon.Query<SalesReturnMasterView>("SalesReturnMasterPrint", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<ProductView> SalesDetailsPrint(long SalesReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesReturnMasterId", SalesReturnMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("SalesReturnInvoicePrint", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<ProductView> SalesInvoiceView(long SalesReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesReturnMasterId", SalesReturnMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("SalesReturnInvoiceDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
