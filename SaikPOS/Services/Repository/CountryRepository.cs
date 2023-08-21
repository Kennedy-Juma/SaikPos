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
    public class CountryRepository : ICountry
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public CountryRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Country
                                     where progm.CountryName == name
                               select progm.CountryId).Count();
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
            var checkResult = (from progm in _context.Country
                               where progm.CountryName == name
                               select progm.CountryId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Country
                                    where progm.CountryName == name
                                    select progm.CountryId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long CountryId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM Country where CountryId=@CountryId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@CountryId", SqlDbType.BigInt);
                para.Value = CountryId;
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

        public Country Edit(long id)
        {
            Country returnView = _context.Country.Find(id);
            return returnView;
        }

        public List<Country> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var param = new DynamicParameters();
                var ListofPlan = sqlcon.Query<Country>("SELECT *FROM Country", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public long Save(Country model)
        {
            _context.Country.Add(model);
            _context.SaveChanges();
            long id = model.CountryId;
            return id;
        }

        public void Update(Country model)
        {
            _context.Country.Update(model);
            _context.SaveChanges();
        }
    }
}
