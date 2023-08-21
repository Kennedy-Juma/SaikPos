using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
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
    public class PurchaseInvoiceRepository : IPurchaseInvoice
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public PurchaseInvoiceRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool DeletePurchseInvoice(long PurchaseMasterId, string VoucherNo, long CompanyId, long FinancialYearId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("PurchseInvoiceDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@PurchaseMasterId", SqlDbType.BigInt);
                para.Value = PurchaseMasterId;
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

        public PurchaseMaster EditPurchaseMaster(long PurchaseMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseMasterId", PurchaseMasterId);
                var result = sqlcon.Query<PurchaseMaster>("SELECT *FROM PurchaseMaster where PurchaseMasterId=@PurchaseMasterId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
        }

        public List<PurchaseMasterView> ViewAllPurchaseMasterDetails(long id)
        {
            var varlist = (from a in _context.PurchaseMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == id
                           select new PurchaseMasterView
                           {
                               PurchaseMasterId = a.PurchaseMasterId,
                               Date = a.Date,
                               VoucherNo = a.VoucherNo,
                               GrandTotal = a.GrandTotal,
                               Status = a.Status,
                               UserId = a.UserId,
                               CreditAmount = a.CreditAmount,
                               CashAmount = a.CashAmount + a.BankAmount,
                               LedgerCode = b.LedgerCode,
                               LedgerName = b.LedgerName,
                               VoucherTypeName = c.VoucherTypeName,
                               DueDate = a.DueDate
                           }).ToList();

            return varlist;
        }

        public List<PurchaseMasterView> ViewAllPurchseInvoice(long id, DateTime fromDate, DateTime toDate)
        {
            var varlist = (from a in _context.PurchaseMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == id && a.Date >= fromDate && a.Date <= toDate
                           select new PurchaseMasterView
                           {
                               PurchaseMasterId = a.PurchaseMasterId,
                               Date = a.Date,
                               VoucherNo = a.VoucherNo,
                               GrandTotal = a.GrandTotal,
                               Status = a.Status,
                               UserId = a.UserId,
                               CreditAmount = a.CreditAmount,
                               LedgerCode = b.LedgerCode,
                               LedgerName = b.LedgerName,
                               VoucherTypeName = c.VoucherTypeName,
                               DueDate = a.DueDate
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
                return sqlcon.Query<bool>("SELECT VoucherNo FROM PurchaseMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo AND VoucherTypeId='13' ", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public PaymentSupplierView GetPreviousDuesBalancepurchase(long LedgerId)
        {
            PaymentSupplierView info = new PaymentSupplierView();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            SqlDataReader rdr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDue", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@LedgerId", SqlDbType.Decimal);
                sprmparam.Value = LedgerId;
                rdr = sccmd.ExecuteReader();
                while (rdr.Read())
                {
                    info.DueBalance = Convert.ToDecimal(rdr["DueBalance"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                rdr.Close();
                sqlcon.Close();
            }
            return info;
        }
        public List<ProductView> PurchaseInvoiceView(long PurchaseMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseMasterId", PurchaseMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("PurchaseInvoiceDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public PurchaseMasterView PrintPurchaseMasterView(long PurchaseMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@PurchaseMasterId", PurchaseMasterId);
                var result = sqlcon.Query<PurchaseMasterView>("PrintPurchaseMasterView", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        
        public List<PaymentMaster> GetPaymentPurchaseView(long DetailsId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@DetailsId", DetailsId);
                var ListofPlan = sqlcon.Query<PaymentMaster>("SELECT VoucherNo,Date,TotalAmount,CashAmount + BankAmount as CashAmount FROM PaymentMaster where DetailsId=@DetailsId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public bool CheckPymentSupplier(string voucherNo, long companyId, long financialYearId, long VoucherTypeId)
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
    }
}
