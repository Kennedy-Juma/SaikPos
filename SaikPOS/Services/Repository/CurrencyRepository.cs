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
    public class CurrencyRepository : ICurrency
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public CurrencyRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Currency
                                     where progm.CurrencyName == name
                               select progm.CurrencyId).Count();
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
            var checkResult = (from progm in _context.Currency
                               where progm.CurrencyName == name
                               select progm.CurrencyId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Currency
                                    where progm.CurrencyName == name
                                    select progm.CurrencyId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long CurrencyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT CurrencyId from Product where UnitId=@UnitId) DELETE FROM Unit where UnitId=@UnitId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@CurrencyId", SqlDbType.BigInt);
                para.Value = CurrencyId;
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

        public Currency Edit(long id)
        {
            Currency returnView = _context.Currency.Find(id);
            return returnView;
        }

        public List<Currency> GetAll()
        {
            var view = _context.Currency.ToList();
            return view;
        }

        public long Save(Currency model)
        {
            _context.Currency.Add(model);
            _context.SaveChanges();
            long id = model.CurrencyId;
            return id;
        }

        public void Update(Currency model)
        {
            _context.Currency.Update(model);
            _context.SaveChanges();
        }
    }
}
