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
    public class BatchRepository : IBatch
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public BatchRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Batch
                                     where progm.BatchNo == name
                               select progm.BatchId).Count();
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
            var checkResult = (from progm in _context.Batch
                               where progm.BatchNo == name
                               select progm.BatchId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Batch
                                    where progm.BatchNo == name
                                    select progm.BatchId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long AreaId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT AreaId from AccountLedger where AreaId=@AreaId) DELETE FROM Area where AreaId=@AreaId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@AreaId", SqlDbType.BigInt);
                para.Value = AreaId;
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

        public Batch Edit(long id)
        {
            Batch returnView = _context.Batch.Find(id);
            return returnView;
        }

        public List<Batch> GetAll()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var param = new DynamicParameters();
                var ListofPlan = sqlcon.Query<Batch>("SELECT *FROM Batch", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }

        public long Save(Batch model)
        {
            _context.Batch.Add(model);
            _context.SaveChanges();
            long id = model.BatchId;
            return id;
        }

        public void Update(Batch model)
        {
            _context.Batch.Update(model);
            _context.SaveChanges();
        }
    }
}
