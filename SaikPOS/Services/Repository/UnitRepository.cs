﻿using Dapper;
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
    public class UnitRepository : IUnit
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public UnitRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Unit
                                     where progm.UnitName == name
                               select progm.UnitId).Count();
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
            var checkResult = (from progm in _context.Unit
                               where progm.UnitName == name
                               select progm.UnitId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Unit
                                    where progm.UnitName == name
                                    select progm.UnitId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long UnitId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT UnitId from Product where UnitId=@UnitId) DELETE FROM Unit where UnitId=@UnitId", sqlcon);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@UnitId", SqlDbType.BigInt);
                para.Value = UnitId;
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

        public Unit Edit(long id)
        {
            Unit returnView = _context.Unit.Find(id);
            return returnView;
        }

        public List<Unit> GetAll()
        {
            var view = _context.Unit.ToList();
            return view;
        }

        public long Save(Unit model)
        {
            _context.Unit.Add(model);
            _context.SaveChanges();
            long id = model.UnitId;
            return id;
        }

        public void Update(Unit model)
        {
            _context.Unit.Update(model);
            _context.SaveChanges();
        }
    }
}
