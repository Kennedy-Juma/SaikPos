using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public CategoryRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Category
                                     where progm.CategoryName == name
                               select progm.CategoryId).Count();
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
            var checkResult = (from progm in _context.Category
                                     where progm.CategoryName == name
                               select progm.CategoryId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Category
                                    where progm.CategoryName == name
                                    select progm.CategoryId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long CategoryId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT CategoryId from Product where CategoryId=@CategoryId) DELETE FROM Category where CategoryId=@CategoryId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@CategoryId", SqlDbType.BigInt);
                para.Value = CategoryId;
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

        public Category Edit(long id)
        {
            Category returnView = _context.Category.Find(id);
            return returnView;
        }

        public List<Category> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var param = new DynamicParameters();
                var ListofPlan = sqlcon.Query<Category>("SELECT *FROM Category", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public long Save(Category model)
        {
            _context.Category.Add(model);
            _context.SaveChanges();
            long id = model.CategoryId;
            return id;
        }

        public void Update(Category model)
        {
            _context.Category.Update(model);
            _context.SaveChanges();
        }
    }
}
