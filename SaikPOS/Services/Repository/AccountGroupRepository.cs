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
    public class AccountGroupRepository : IAccountGroup
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public AccountGroupRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResultCount = (from progm in _context.AccountGroup
                                    where progm.AccountGroupName == name
                                     select progm.AccountGroupId).Count();
            if (checkResultCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CheckNameId(string name)
        {
            var checkResultCount = (from progm in _context.AccountGroup
                                     where progm.AccountGroupName == name
                                    select progm.AccountGroupId).Count();
            if (checkResultCount > 0)
            {

                var result = (from progm in _context.AccountGroup
                              where progm.AccountGroupName == name
                                    select progm.AccountGroupId).FirstOrDefault();
                return result;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long AccountGroupId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT AccountGroupId from AccountLedger where AccountGroupId=@AccountGroupId) DELETE FROM AccountGroup where AccountGroupId=@AccountGroupId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@AccountGroupId", SqlDbType.BigInt);
                para.Value = AccountGroupId;
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

        public AccountGroup Edit(long AccountGroupId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("AccountGroupId", AccountGroupId, DbType.Int64);

            AccountGroup group = new AccountGroup();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    group = conn.QueryFirstOrDefault<AccountGroup>("SELECT *FROM AccountGroup where AccountGroupId=@AccountGroupId", parameters, commandType: CommandType.Text);
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
            return group;
        }

        public List<AccountGroup> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<AccountGroup>("SELECT AccountGroupId,AccountGroupName FROM AccountGroup", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public bool Save(AccountGroup model)
        {
            using (SqlConnection con = new SqlConnection(_conn.DbConn))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@AccountGroupName", model.AccountGroupName);
                param.Add("@CompanyId", model.CompanyId);
                param.Add("@GroupCode", model.GroupCode);
                param.Add("@GroupUnder", model.GroupUnder);
                param.Add("@Nature", model.Nature);
                param.Add("@IsDefault", model.IsDefault);
                param.Add("@AffectGrossProfit", model.AffectGrossProfit);
                param.Add("@Narration", model.Narration);
                param.Add("@CreatedBy", model.CreatedBy);
                param.Add("@AddedDate", model.AddedDate);
                int result = con.Execute("IF NOT EXISTS (SELECT AccountGroupName from AccountGroup where AccountGroupName=@AccountGroupName) IF NOT EXISTS (SELECT GroupCode from AccountGroup where GroupCode=@GroupCode) INSERT INTO AccountGroup (AccountGroupName,GroupUnder,GroupCode,CompanyId,Narration,IsDefault,Nature,AffectGrossProfit,CreatedBy,AddedDate)VALUES(@AccountGroupName,@GroupUnder,@GroupCode,@CompanyId,@Narration,@IsDefault,@Nature,@AffectGrossProfit,@CreatedBy,@AddedDate)", param, null, 0, CommandType.Text);

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

        public bool Update(AccountGroup model)
        {
            using (SqlConnection con = new SqlConnection(_conn.DbConn))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@AccountGroupId", model.AccountGroupId);
                param.Add("@CompanyId", model.CompanyId);
                param.Add("@AccountGroupName", model.AccountGroupName);
                param.Add("@GroupCode", model.GroupCode);
                param.Add("@GroupUnder", model.GroupUnder);
                param.Add("@Nature", model.Nature);
                param.Add("@IsDefault", model.IsDefault);
                param.Add("@AffectGrossProfit", model.AffectGrossProfit);
                param.Add("@Narration", model.Narration);
                param.Add("@ModifyDate", model.ModifyDate);
                param.Add("@ModifyBy", model.ModifyBy);
                int result = con.Execute("IF NOT EXISTS (SELECT AccountGroupName from AccountGroup where AccountGroupName=@AccountGroupName and AccountGroupId<>@AccountGroupId) IF NOT EXISTS (SELECT GroupCode from AccountGroup where GroupCode=@GroupCode and AccountGroupId<>@AccountGroupId) Update AccountGroup SET AccountGroupName=@AccountGroupName,GroupUnder=@GroupUnder,GroupCode=@GroupCode,CompanyId=@CompanyId,Narration=@Narration,IsDefault=@IsDefault,Nature=@Nature,AffectGrossProfit=@AffectGrossProfit,ModifyBy=@ModifyBy,ModifyDate=@ModifyDate where AccountGroupId=@AccountGroupId", param, null, 0, CommandType.Text);

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

        public List<AccountGroupView> ViewAllAccountGroup()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<AccountGroupView>("AccountGroupViewAllGridFill", null, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
