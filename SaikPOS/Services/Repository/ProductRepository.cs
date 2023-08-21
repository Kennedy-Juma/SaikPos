using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public ProductRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }

        public bool CheckName(string name)
        {
            var checkResult = (from progm in _context.Product
                               where progm.ProductName == name
                               select progm.ProductId).Count();
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
            var checkResult = (from progm in _context.Product
                               where progm.ProductName == name
                               select progm.ProductId).Count();
            if (checkResult > 0)
            {

                var checkAccount = (from progm in _context.Product
                                    where progm.ProductName == name
                                    select progm.ProductId).FirstOrDefault();
                return checkAccount;
            }
            else
            {
                return 0;
            }
        }

        public bool Delete(long ProductId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            //SqlTransaction transaction;

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    //transaction = sqlcon.BeginTransaction();
                }
                //transaction = sqlcon.BeginTransaction();
                SqlCommand cmd = new SqlCommand("ProductDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@ProductId", SqlDbType.BigInt);
                para.Value = ProductId;
                long rowAffacted = cmd.ExecuteNonQuery();
                //transaction.Commit();
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

        public Product Edit(long ProductId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("ProductId", ProductId, DbType.Int64);

            Product employee = new Product();

            using (var conn = new SqlConnection(_conn.DbConn))
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    employee = conn.QueryFirst<Product>("SELECT *FROM Product where ProductId=@ProductId", parameters, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return employee;
        }
        public List<ProductView> ViewAllProduct(long companyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@companyId", companyId);
                var ListofPlan = sqlcon.Query<ProductView>("ViewAllProduct", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }



        public string GetProductNo(long companyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@companyId", companyId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(productCode+1),1) FROM Product where companyId=@companyId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public long Save(Product model)
        {
            _context.Product.Add(model);
            _context.SaveChanges();
            long id = model.ProductId;
            return id;
        }

        public void Update(Product model)
        {
            _context.Product.Update(model);
            _context.SaveChanges();
        }

        public long SaveOpeningStock(StockPosting posting)
        {
            _context.StockPosting.Add(posting);
            _context.SaveChanges();
            long id = posting.StockPostingId;
            return id;
        }

        public List<ProductView> ViewCategoryWiseProduct(long CategoryId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CategoryId", CategoryId);
                var ListofPlan = sqlcon.Query<ProductView>("ViewCategoryWiseProduct", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
