using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class IncomeVoucherRepository
    {
       private readonly ApplicationDbContext _context;
        DatabaseConnection _conn;
        public IncomeVoucherRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<IncomeVoucherView> IncomeView(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                var ListofPlan = sqlcon.Query<IncomeVoucherView>("IncomeView", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public bool IncomeVoucherDelete(long IncomeMasterId , long VoucherTypeId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IncomeVoucherDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@IncomeMasterId", SqlDbType.BigInt);
                para.Value = IncomeMasterId;
                para = cmd.Parameters.Add("@VoucherTypeId", SqlDbType.BigInt);
                para.Value = VoucherTypeId;
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
        public string GetIncomevoucherNo(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM IncomeMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public List<AccountLedger> IncomeComboFill(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<AccountLedger>("IncomeComboFill", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public bool EpensiveVouchernoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                return sqlcon.Query<bool>("SELECT VoucherNo FROM IncomeMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public IncomeMaster EditIncomeMaster(long IncomeMasterId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IncomeMasterId", IncomeMasterId, DbType.Int64);

            IncomeMaster employee = new IncomeMaster();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirstOrDefault<IncomeMaster>("SELECT *FROM IncomeMaster where IncomeMasterId=@IncomeMasterId", parameters, commandType: CommandType.Text);
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
        public List<IncomeDetails> ViewIncomeDetails(long IncomeMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@IncomeMasterId", IncomeMasterId);
                var ListofPlan = sqlcon.Query<IncomeDetails>("SELECT *FROM IncomeDetails where IncomeMasterId=@IncomeMasterId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<IncomeVoucherView> IncomeReport(DateTime fromDate, DateTime toDate, long LedgerId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                var ListofPlan = sqlcon.Query<IncomeVoucherView>("IncomeReportFill", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<PurchaseMasterView> OverDueSales(long LedgerId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@LedgerId", LedgerId);
                var ListofPlan = sqlcon.Query<PurchaseMasterView>("OverdueSales", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }

    }
}
