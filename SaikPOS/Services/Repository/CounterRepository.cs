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
    public class CounterRepository : ICounter
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public CounterRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Counter
                                     where progm.CounterName == name
                               select progm.CounterId).Count();
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
            var checkResult = (from progm in _context.Counter
                               where progm.CounterName == name
                               select progm.CounterId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Counter
                                    where progm.CounterName == name
                                    select progm.CounterId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long CounterId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT CounterId from SalesMaster where CounterId=@CounterId) DELETE FROM Counter where CounterId=@CounterId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@CounterId", SqlDbType.BigInt);
                para.Value = CounterId;
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

        public Counter Edit(long id)
        {
            Counter returnView = _context.Counter.Find(id);
            return returnView;
        }

        public List<Counter> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var param = new DynamicParameters();
                var ListofPlan = sqlcon.Query<Counter>("SELECT *FROM Counter", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public long Save(Counter model)
        {
            _context.Counter.Add(model);
            _context.SaveChanges();
            long id = model.CounterId;
            return id;
        }

        public void Update(Counter model)
        {
            _context.Counter.Update(model);
            _context.SaveChanges();
        }
    }
}
