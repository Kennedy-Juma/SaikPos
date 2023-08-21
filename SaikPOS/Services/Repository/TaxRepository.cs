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
    public class TaxRepository : ITax
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public TaxRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Tax
                                     where progm.TaxName == name
                               select progm.TaxId).Count();
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
            var checkResult = (from progm in _context.Tax
                               where progm.TaxName == name
                               select progm.TaxId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Tax
                                    where progm.TaxName == name
                                    select progm.TaxId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long TaxId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT TaxId from Product where TaxId=@TaxId) DELETE FROM Tax where TaxId=@TaxId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@TaxId", SqlDbType.BigInt);
                para.Value = TaxId;
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

        public Tax Edit(long id)
        {
            Tax returnView = _context.Tax.Find(id);
            return returnView;
        }

        public List<Tax> GetAll()
        {
            var view = _context.Tax.ToList();
            return view;
        }

        public long Save(Tax model)
        {
            _context.Tax.Add(model);
            _context.SaveChanges();
            long id = model.TaxId;
            return id;
        }

        public void Update(Tax model)
        {
            _context.Tax.Update(model);
            _context.SaveChanges();
        }
    }
}
