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
    public class SalesInvoiceRepository : ISalesInvoice
    {
        private readonly ApplicationDbContext _context;
        DatabaseConnection _conn;
        public SalesInvoiceRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public DashboardView GetCashBankresultCustomerPayment(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var returnView = sqlcon.Query<DashboardView>("GetCashBankresultCustomerPayment", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
                return returnView;
            }
        }
        public List<SalesMasterView> ViewAllSalesInvoice(long CompanyId)
        {
            var varlist = (from a in _context.SalesMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == CompanyId
                           select new SalesMasterView
                           {
                               SalesMasterId = a.SalesMasterId,
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
        public SalesMaster EditsalesMaster(long SalesMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", SalesMasterId);
                var result = sqlcon.Query<SalesMaster>("SELECT *FROM SalesMaster where SalesMasterId=@SalesMasterId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
        }
        public bool DeleteSalesInvoice(long SalesMasterId, string VoucherNo, long CompanyId, long FinancialYearId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("SalesInvoiceDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@SalesMasterId", SqlDbType.BigInt);
                para.Value = SalesMasterId;
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
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM SalesMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherTypeId=@VoucherTypeId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public List<SalesMasterView> ViewAllSalesInvoice(long CompanyId, DateTime FromDate, DateTime ToDate)
        {
            var varlist = (from a in _context.SalesMaster
                           join b in _context.AccountLedger on a.LedgerId equals b.LedgerId
                           join c in _context.VoucherType on a.VoucherTypeId equals c.VoucherTypeId
                           where a.CompanyId == CompanyId && a.Date >= FromDate && a.Date <= ToDate
                           select new SalesMasterView
                           {
                               SalesMasterId = a.SalesMasterId,
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
        public bool AccountSalesInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                return sqlcon.Query<bool>("SELECT VoucherNo FROM SalesMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo AND VoucherTypeId='13' ", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public PaymentSupplierView CustomerSalesDue(long LedgerId)
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
                SqlCommand sccmd = new SqlCommand("CustomerSalesDue", sqlcon);
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
        public SalesMasterView SalesMasterPrint(long SalesMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", SalesMasterId);
                var result = sqlcon.Query<SalesMasterView>("SalesMasterPrint", para, null, true, 0, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<ProductView> SalesDetailsPrint(long SalesMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", SalesMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("SalesInvoicePrint", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<ProductView> SalesInvoiceView(long SalesMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", SalesMasterId);
                var ListofPlan = sqlcon.Query<ProductView>("SalesInvoiceDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public PaymentSupplierView GetPreviousDuesBalanceSales(long LedgerId)
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
                SqlCommand sccmd = new SqlCommand("SalesDue", sqlcon);
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
        public List<SalesMasterView> GetCustomerPaymentList(long LedgerId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@LedgerId", LedgerId);
                var ListofPlan = sqlcon.Query<SalesMasterView>("CustomerReceiveListone", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }

    }
}
