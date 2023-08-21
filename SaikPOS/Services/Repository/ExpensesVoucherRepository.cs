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
    public class ExpensesVoucherRepository
    {
       private readonly ApplicationDbContext _context;
        DatabaseConnection _conn;
        public ExpensesVoucherRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<ExpenseVoucherView> ViewAllExpenditureVoucher(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                var ListofPlan = sqlcon.Query<ExpenseVoucherView>("ExpensesView", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public bool ExpensiveVoucherDelete(long ExpensiveMasterId , long VoucherTypeId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("ExpensiveVoucherDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@ExpensiveMasterId", SqlDbType.BigInt);
                para.Value = ExpensiveMasterId;
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
        public string GetExpenvoucherNo(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM ExpenseMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public List<AccountLedger> EpensiveComboFill(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<AccountLedger>("EpensiveComboFill", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
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
                return sqlcon.Query<bool>("SELECT VoucherNo FROM ExpenseMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public ExpenseMaster EditExpenseMaster(long ExpensiveMasterId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("ExpensiveMasterId", ExpensiveMasterId, DbType.Int64);

            ExpenseMaster employee = new ExpenseMaster();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirstOrDefault<ExpenseMaster>("SELECT *FROM ExpenseMaster where ExpensiveMasterId=@ExpensiveMasterId", parameters, commandType: CommandType.Text);
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
        public List<ExpenseDetails> ViewExpenditureDetails(long ExpensiveMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@ExpensiveMasterId", ExpensiveMasterId);
                var ListofPlan = sqlcon.Query<ExpenseDetails>("SELECT *FROM ExpenseDetails where ExpensiveMasterId=@ExpensiveMasterId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<IncomeExpenditureView> ViewExpenditureShowPrint(long ExpensiveMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@ExpensiveMasterId", ExpensiveMasterId);
                var ListofPlan = sqlcon.Query<IncomeExpenditureView>("ExpenseVoucherDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<IncomeExpenditureView> ViewIncomeShowPrint(long IncomeMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@IncomeMasterId", IncomeMasterId);
                var ListofPlan = sqlcon.Query<IncomeExpenditureView>("IncomeVoucherDetails", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<ExpenseVoucherView> ExpensesReport(DateTime fromDate, DateTime toDate, long LedgerId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                var ListofPlan = sqlcon.Query<ExpenseVoucherView>("ExpensesReport", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
