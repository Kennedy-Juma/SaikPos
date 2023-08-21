
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
    public class ProductGroupRepository : IProductGroup
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public ProductGroupRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.ProductGroup
                                     where progm.GroupName == name
                               select progm.GroupId).Count();
            if (checkResult > 0)
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
            var checkResult = (from progm in _context.ProductGroup
                               where progm.GroupName == name
                               select progm.GroupId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.ProductGroup
                                    where progm.GroupName == name
                                    select progm.GroupId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long GroupId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT GroupId from Product where GroupId=@GroupId) DELETE FROM ProductGroup where GroupId=@GroupId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@GroupId", SqlDbType.BigInt);
                para.Value = GroupId;
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
        public List<ProductGroupView> ViewAllProductGroup()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<ProductGroupView>("ProductGroupViewForGridFill", null, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public ProductGroup Edit(long id)
        {
            ProductGroup returnView = _context.ProductGroup.Find(id);
            return returnView;
        }

        public List<ProductGroup> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var param = new DynamicParameters();
                var ListofPlan = sqlcon.Query<ProductGroup>("SELECT *FROM ProductGroup", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public long Save(ProductGroup model)
        {
            _context.ProductGroup.Add(model);
            _context.SaveChanges();
            long id = model.GroupId;
            return id;
        }

        public void Update(ProductGroup model)
        {
            _context.ProductGroup.Update(model);
            _context.SaveChanges();
        }
    }
}
