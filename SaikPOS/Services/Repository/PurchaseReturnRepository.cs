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
    public class PurchaseReturnRepository : IPurchaseReturn
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public PurchaseReturnRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool DeletePurchseReturnInvoice(long PurchaseReturnMasterId, string VoucherNo, long CompanyId, long FinancialYearId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeletePurchseReturnInvoice", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@PurchaseReturnMasterId", SqlDbType.BigInt);
                para.Value = PurchaseReturnMasterId;
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

        public PurchaseReturnMaster EditPurchaseMaster(long PurchaseReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseReturnMasterId", PurchaseReturnMasterId);
                var result = sqlcon.Query<PurchaseReturnMaster>("SELECT *FROM PurchaseReturnMaster where PurchaseReturnMasterId=@PurchaseReturnMasterId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
        }

        public List<PurchaseReturnView> ViewAllPurchaseMasterDetails(long id)
        {
            var varlist = (from a in _context.PurchaseReturnMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == id
                           select new PurchaseReturnView
                           {
                               PurchaseReturnMasterId = a.PurchaseReturnMasterId,
                               Date = a.Date,
                               VoucherNo = a.VoucherNo,
                               GrandTotal = a.GrandTotal,
                               UserId = a.UserId,
                               CreditAmount = a.CreditAmount,
                               CashAmount = a.CashAmount + a.BankAmount,
                               LedgerName = b.LedgerName,
                               VoucherTypeName = c.VoucherTypeName,
                           }).ToList();
            return varlist;
        }

        public List<PurchaseReturnView> ViewAllPurchseInvoice(long id, DateTime fromDate, DateTime toDate)
        {
            var varlist = (from a in _context.PurchaseReturnMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == id && a.Date >= fromDate && a.Date <= toDate
                           select new PurchaseReturnView
                           {
                               PurchaseReturnMasterId = a.PurchaseReturnMasterId,
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
        public bool AccountPurchseInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                return sqlcon.Query<bool>("SELECT VoucherNo FROM PurchaseReturnMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo AND VoucherTypeId='14' ", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public List<ProductView> PurchaseInvoiceView(long PurchaseReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseReturnMasterId", PurchaseReturnMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("PurchaseReturnInvoiceDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public PurchaseReturnView PrintPurchaseMasterView(long PurchaseReturnMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseReturnMasterId", PurchaseReturnMasterId);
                var result = sqlcon.Query<PurchaseReturnView>("PrintPurchaseReturnMasterView", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
    }
}
