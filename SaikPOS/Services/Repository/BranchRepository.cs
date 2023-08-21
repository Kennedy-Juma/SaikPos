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
    public class BranchRepository : IBranch
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public BranchRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
    

        public List<Branch> GetAll()
        {
            var view = _context.Branch.ToList();
            return view;
        }
        public long CheckNameId(string name)
        {
            var checkResult = (from progm in _context.Category
                               where progm.CategoryName == name
                               select progm.CategoryId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Branch
                                    where progm.BranchName == name
                                    select progm.BranchId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Branch
                               where progm.BranchName == name
                               select progm.BranchId).Count();
            if (checkResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long Save(Branch model)
        {
            _context.Branch.Add(model);
            _context.SaveChanges();
            long id = model.BranchId;
            return id;
        }
        public Branch Edit(long id)
        {
            Branch returnView = _context.Branch.Find(id);
            return returnView;
        }
        public void Update(Branch model)
        {
            _context.Branch.Update(model);
            _context.SaveChanges();
        }
        public bool Delete(long BranchId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM Branch where BranchId=@BranchId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@BranchId", SqlDbType.BigInt);
                para.Value = BranchId;
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
    }
}
