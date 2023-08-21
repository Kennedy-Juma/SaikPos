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
    public class SalesRepository : ISalesMan
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public SalesRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.SalesMan
                                     where progm.SalesmanName == name
                               select progm.SalesManId).Count();
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
            var checkResult = (from progm in _context.SalesMan
                               where progm.SalesmanName == name
                               select progm.SalesManId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.SalesMan
                                    where progm.SalesmanName == name
                                    select progm.SalesManId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long SalesManId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT SalesManId from SalesMaster where SalesManId=@SalesManId) DELETE FROM SalesMan where SalesManId=@SalesManId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@SalesManId", SqlDbType.BigInt);
                para.Value = SalesManId;
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

        public SalesMan Edit(long id)
        {
            SalesMan returnView = _context.SalesMan.Find(id);
            return returnView;
        }

        public List<SalesMan> GetAll()
        {
            var view = _context.SalesMan.ToList();
            return view;
        }

        public long Save(SalesMan model)
        {
            _context.SalesMan.Add(model);
            _context.SaveChanges();
            long id = model.SalesManId;
            return id;
        }

        public void Update(SalesMan model)
        {
            _context.SalesMan.Update(model);
            _context.SaveChanges();
        }
    }
}
