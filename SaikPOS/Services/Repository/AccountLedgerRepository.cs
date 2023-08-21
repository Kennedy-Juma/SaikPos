using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Data.ViewModel;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class AccountLedgerRepository : IAccountLedger
    {
       private readonly ApplicationDbContext _context;
       private readonly DatabaseConnection _conn;
        public AccountLedgerRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.AccountLedger
                               where progm.LedgerName == name
                               select progm.LedgerId).Count();
            if (checkResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string SerialNoCode(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(LedgerCode+1),1) FROM AccountLedger where CompanyId=@CompanyId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public bool Delete(long ledgerId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("AccountLedgerDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@ledgerId", SqlDbType.BigInt);
                para.Value = ledgerId;
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

        public AccountLedger Edit(long LedgerId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("LedgerId", LedgerId, DbType.Int64);

            AccountLedger employee = new AccountLedger();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirstOrDefault<AccountLedger>("SELECT *FROM AccountLedger where LedgerId=@LedgerId", parameters, commandType: CommandType.Text);
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

        public List<AccountLedgerView> GetAll(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<AccountLedgerView>("SELECT dbo.AccountLedger.LedgerId,dbo.AccountLedger.Email, dbo.AccountLedger.LedgerName, dbo.AccountLedger.LedgerCode, dbo.AccountGroup.AccountGroupId, dbo.AccountGroup.AccountGroupName, dbo.Area.AreaName, dbo.AccountLedger.IsDefault,  dbo.AccountLedger.Phone, dbo.AccountLedger.Mobile,dbo.AccountLedger.OpeningBalance, dbo.Area.AreaId FROM            dbo.AccountLedger INNER JOIN dbo.AccountGroup ON dbo.AccountLedger.AccountGroupId = dbo.AccountGroup.AccountGroupId INNER JOIN  dbo.Area ON dbo.AccountLedger.AreaId = dbo.Area.AreaId where AccountLedger.CompanyId=@CompanyId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<AccountLedgerView> ViewAllCustomer(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<AccountLedgerView>("SELECT dbo.AccountLedger.LedgerId,dbo.AccountLedger.Email, dbo.AccountLedger.LedgerName, dbo.AccountLedger.LedgerCode, dbo.AccountGroup.AccountGroupId, dbo.AccountGroup.AccountGroupName, dbo.Area.AreaName, dbo.AccountLedger.IsDefault,  dbo.AccountLedger.Phone, dbo.AccountLedger.Mobile,AccountLedger.OpeningBalance, dbo.Area.AreaId FROM            dbo.AccountLedger INNER JOIN dbo.AccountGroup ON dbo.AccountLedger.AccountGroupId = dbo.AccountGroup.AccountGroupId INNER JOIN  dbo.Area ON dbo.AccountLedger.AreaId = dbo.Area.AreaId where AccountLedger.CompanyId=@CompanyId and AccountLedger.AccountGroupId= '26'", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<AccountLedgerView> ViewAllSupplier(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<AccountLedgerView>("SELECT dbo.AccountLedger.LedgerId,dbo.AccountLedger.Email, dbo.AccountLedger.LedgerName, dbo.AccountLedger.LedgerCode, dbo.AccountGroup.AccountGroupId, dbo.AccountGroup.AccountGroupName, dbo.Area.AreaName, dbo.AccountLedger.IsDefault,  dbo.AccountLedger.Phone, dbo.AccountLedger.Mobile,AccountLedger.OpeningBalance, dbo.Area.AreaId FROM            dbo.AccountLedger INNER JOIN dbo.AccountGroup ON dbo.AccountLedger.AccountGroupId = dbo.AccountGroup.AccountGroupId INNER JOIN  dbo.Area ON dbo.AccountLedger.AreaId = dbo.Area.AreaId where AccountLedger.CompanyId=@CompanyId and AccountLedger.AccountGroupId= '22'", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public long Save(AccountLedger model)
        {
            long MemID = 0;
            using (SqlConnection con = new SqlConnection(_conn.DbConn))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@LedgerName", model.LedgerName);
                param.Add("@LedgerCode", model.LedgerCode);
                param.Add("@AccountGroupId", model.AccountGroupId);
                param.Add("@CompanyId", model.CompanyId);
                param.Add("@OpeningBalance", model.OpeningBalance);
                param.Add("@IsDefault", model.IsDefault);
                param.Add("@CrOrDr", model.CrOrDr);
                param.Add("@MailingName", model.MailingName);
                param.Add("@Address", model.Address);
                param.Add("@Phone", model.Phone);
                param.Add("@Mobile", model.Mobile);
                param.Add("@Email", model.Email);
                param.Add("@CreditPeriod", model.CreditPeriod);
                param.Add("@CreditLimit", model.CreditLimit);
                param.Add("@PricinglevelId", model.PricinglevelId);
                param.Add("@BillByBill", model.BillByBill);
                param.Add("@Tin", model.Tin);
                param.Add("@Cst", model.Cst);
                param.Add("@Pan", model.Pan);
                param.Add("@RouteId", model.RouteId);
                param.Add("@BankAccountNumber", model.BankAccountNumber);
                param.Add("@BranchName", model.BranchName);
                param.Add("@BranchCode", model.BranchCode);
                param.Add("@AreaId", model.AreaId);
                param.Add("@LogoPathC", model.LogoPathC);
                param.Add("@SkypeID", model.SkypeID);
                param.Add("@Twitter", model.Twitter);
                param.Add("@Facebook", model.Facebook);
                param.Add("@instagram", model.instagram);
                param.Add("@Country", model.Country);
                param.Add("@State", model.State);
                param.Add("@Mnucapality", model.Mnucapality);
                param.Add("@Street", model.Street);
                param.Add("@ZipCode", model.ZipCode);
                param.Add("@Website", model.Website);
                param.Add("@Map", model.Map);
                param.Add("@Dob", model.Dob);
                param.Add("@Referfrom", model.Referfrom);
                param.Add("@AnniversaryDate", model.AnniversaryDate);
                param.Add("@Narration", model.Narration);
                param.Add("@CreatedBy", model.CreatedBy);
                param.Add("@AddedDate", model.AddedDate);
                param.Add("@MemIDOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);
                con.Execute("AccountLedgerInsert", param, null, 0, CommandType.StoredProcedure);
                MemID = param.Get<long>("MemIDOUT");
                return MemID;
            }
        }

        public bool Update(AccountLedger model)
        {
            using (SqlConnection con = new SqlConnection(_conn.DbConn))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@LedgerId", model.LedgerId);
                param.Add("@LedgerName", model.LedgerName);
                param.Add("@LedgerCode", model.LedgerCode);
                param.Add("@AccountGroupId", model.AccountGroupId);
                param.Add("@CompanyId", model.CompanyId);
                param.Add("@OpeningBalance", model.OpeningBalance);
                param.Add("@IsDefault", model.IsDefault);
                param.Add("@CrOrDr", model.CrOrDr);
                param.Add("@MailingName", model.MailingName);
                param.Add("@Address", model.Address);
                param.Add("@Phone", model.Phone);
                param.Add("@Mobile", model.Mobile);
                param.Add("@Email", model.Email);
                param.Add("@CreditPeriod", model.CreditPeriod);
                param.Add("@CreditLimit", model.CreditLimit);
                param.Add("@PricinglevelId", model.PricinglevelId);
                param.Add("@BillByBill", model.BillByBill);
                param.Add("@Tin", model.Tin);
                param.Add("@Cst", model.Cst);
                param.Add("@Pan", model.Pan);
                param.Add("@RouteId", model.RouteId);
                param.Add("@BankAccountNumber", model.BankAccountNumber);
                param.Add("@BranchName", model.BranchName);
                param.Add("@BranchCode", model.BranchCode);
                param.Add("@AreaId", model.AreaId);
                param.Add("@LogoPathC", model.LogoPathC);
                param.Add("@SkypeID", model.SkypeID);
                param.Add("@Twitter", model.Twitter);
                param.Add("@Facebook", model.Facebook);
                param.Add("@instagram", model.instagram);
                param.Add("@Country", model.Country);
                param.Add("@State", model.State);
                param.Add("@Mnucapality", model.Mnucapality);
                param.Add("@Street", model.Street);
                param.Add("@ZipCode", model.ZipCode);
                param.Add("@Website", model.Website);
                param.Add("@Map", model.Map);
                param.Add("@Dob", model.Dob);
                param.Add("@Referfrom", model.Referfrom);
                param.Add("@AnniversaryDate", model.AnniversaryDate);
                param.Add("@Narration", model.Narration);
                param.Add("@CreatedBy", model.CreatedBy);
                param.Add("@AddedDate", model.AddedDate);
                param.Add("@ModifyDate", model.ModifyDate);
                param.Add("@ModifyBy", model.ModifyBy);
                int result = con.Execute("AccountLedgerUpdte", param, null, 0, CommandType.StoredProcedure);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<AccountLedger> GetCashFill()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<AccountLedger>("CashFill", null, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<AccountLedger> GetBankFill()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<AccountLedger>("BankFill", null, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
