using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.ViewModel;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class InventoryReportRepository : IInventoryReport
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        DataAccess _da;
        public InventoryReportRepository(ApplicationDbContext context, DatabaseConnection conn , DataAccess da)
        {
            _context = context;
            _conn = conn;
            _da = da;
        }
        public DataSet CustomerLedgerOpening(DateTime fromDate, long LedgerId, long CompanyId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CustomerLedgeerOpening", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                sqlparam.Value = CompanyId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public DataSet CustomerLedger(DateTime fromDate, DateTime toDate, long LedgerId, long CompanyId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CustomerLedgeer", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                sqlparam.Value = CompanyId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public DataSet CustomerLedgerDue(DateTime fromDate, DateTime toDate, long LedgerId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CustomerLedgeerDue", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public DataSet CustomerLedgerDueSingle(DateTime fromDate, DateTime toDate, long LedgerId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CustomerLedgeerDueSingle", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public List<PurchaseSales> CustomerCountSales(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                var ListofPlan = sqlcon.Query<PurchaseSales>("CustomerCountSales", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<PurchaseSales> SaleReports(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                var ListofPlan = sqlcon.Query<PurchaseSales>("SaleReports", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public DataSet SuppllierLedgerDue(DateTime fromDate, DateTime toDate, long ledgerId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("SupplierLedgeerDue", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.BigInt);
                sqlparam.Value = ledgerId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public DataSet SupplierLedgerDueSingle(DateTime fromDate, DateTime toDate, long ledgerId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("SupplierLedgeerDueSingle", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.BigInt);
                sqlparam.Value = ledgerId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public List<PurchaseSales> SupplierCountPurchase(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                var ListofPlan = sqlcon.Query<PurchaseSales>("SupplierCountPurchase", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<PurchaseSales> PurchaseRepports(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@fromDate", fromDate);
                para.Add("@toDate", toDate);
                para.Add("@LedgerId", LedgerId);
                para.Add("@VoucherTypeId", VoucherTypeId);
                var ListofPlan = sqlcon.Query<PurchaseSales>("PurchaseReport", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<InventoryViewFinl> StockReport(long GroupId, long ProductId, long CompanyId)
        {
            List<InventoryViewFinl> _UsersModel = new List<InventoryViewFinl>();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("StockReport", sqlcon);//call Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GroupId", GroupId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@CompanyId", CompanyId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                InventoryViewFinl _UserModel = new InventoryViewFinl();
                _UserModel.productCode = reader["productCode"].ToString();
                _UserModel.productName = reader["productName"].ToString();
                //_UserModel.batchNo = reader["batchNo"].ToString();
                _UserModel.unitName = reader["unitName"].ToString();
                //_UserModel.purchaseRate = Convert.ToDecimal(reader["purchaseRate"].ToString());
                _UserModel.purQty = Convert.ToDecimal(reader["purQty"].ToString());
                _UserModel.SalesQty = Convert.ToDecimal(reader["SalesQty"].ToString());
                _UserModel.rate = Convert.ToDecimal(reader["rate"].ToString());
                _UserModel.PurchaseStockBal = Convert.ToDecimal(reader["PurchaseStockBal"].ToString());
                _UserModel.SalesStockBalance = Convert.ToDecimal(reader["SalesStockBalance"].ToString());
                _UserModel.Stock = Convert.ToDecimal(reader["Stock"].ToString());
                _UserModel.stockvalue = Convert.ToDecimal(reader["stockvalue"].ToString());
                _UserModel.salesRate = Convert.ToDecimal(reader["salesRate"].ToString());
                _UsersModel.Add(_UserModel);
            }
            reader.Close();
            sqlcon.Close();
            return _UsersModel;
        }
        public List<InventoryViewFinl> ProductStatisticsFill(long GroupId, string criteria, string BatchNo, long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@GroupId", GroupId);
                para.Add("@criteria", criteria);
                para.Add("@BatchNo", BatchNo);
                para.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<InventoryViewFinl>("ProductStatisticsFill", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public DataSet DayBook(DateTime fromDate, DateTime toDate, long VoucherTypeId, long LedgerId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            //dtbl.Columns.Add("SlNo", typeof(int));
            //dtbl.Columns["SlNo"].AutoIncrement = true;
            //dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            //dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("DayBook", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@VoucherTypeId", SqlDbType.BigInt);
                sqlparam.Value = VoucherTypeId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public DataSet LedgercountReport(DateTime fromDate, DateTime toDate, long LedgerId, string LedgerName, long CompanyId)
        {
            DataSet dtbl = new DataSet();
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("LedgercountReport", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = fromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = toDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@LedgerId", SqlDbType.BigInt);
                sqlparam.Value = LedgerId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.NVarChar);
                sqlparam.Value = LedgerName;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                sqlparam.Value = CompanyId;
                sqldadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public List<FinancialReport> FillAccountGroup(DateTime fromDate, DateTime toDate, long CompanyId)
        {
            List<SqlParameter> paramColl = new List<SqlParameter>();
            paramColl.Add(new SqlParameter("@fromDate", fromDate));
            paramColl.Add(new SqlParameter("@toDate", toDate));
            paramColl.Add(new SqlParameter("@CompanyId", CompanyId));

            DataTable dtResult = _da.ExecuteDataTable("AccountGroupReportFill", paramColl);
            List<FinancialReport> dtoList = new List<FinancialReport>();
            foreach (DataRow dr in dtResult.Rows)
            {
                //RegTypeDTO dto = new RegTypeDTO();
                //dto.RegName = dr["RegName"].ToString();
                //dto.RegTypeID = Convert.ToInt32(dr["RegTypeID"]);
                //dto.Rate = Convert.ToDecimal(dr["Rate"]);
                //dtoList.Add(dto);

                dtoList.Add(new FinancialReport
                {
                    AccountGroupId = Convert.ToInt64(dr["AccountGroupId"]),
                    Name = dr["Name"].ToString(),
                    //Code = dr["Code"].ToString(),
                    OpeningBalance = dr["OpeningBalance"].ToString(),
                    Balance = dr["Balance"].ToString(),
                    //OpeningDr = Convert.ToDecimal(dr["OpeningDr"].ToString()),
                    //OpeningCr = Convert.ToDecimal(dr["OpeningCr"].ToString()),
                    Debit = Convert.ToDecimal(dr["Debit"].ToString()),
                    Credit = Convert.ToDecimal(dr["Credit"].ToString())
                    //ClosingDr = Convert.ToDecimal(dr["ClosingDr"].ToString()),
                    //ClosingCr = Convert.ToDecimal(dr["ClosingCr"].ToString())
                });

            }
            return dtoList;

        }
        public DashboardView SalesPurchaseTotal(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var returnView = sqlcon.Query<DashboardView>("SalesPurchaseTotal", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
                return returnView;
            }
        }
        public DashboardView Receive(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var returnView = sqlcon.Query<DashboardView>("Receive", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
                return returnView;
            }
        }
        public DashboardView Pay(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                var returnView = sqlcon.Query<DashboardView>("Pay", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
                return returnView;
            }
        }
        public List<FinancialReport> TopReceive(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var paramater = new DynamicParameters();
                paramater.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<FinancialReport>("TopReceive", paramater, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public DataSet ProfitAndLossAnalysis(DateTime fromDate, DateTime toDate, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysis", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                prm.Value = CompanyId;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysisDetailed(DateTime fromDate, DateTime toDate, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisDetailed", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                prm.Value = CompanyId;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        public decimal StockValueGetOnDate(DateTime date, DateTime dtToDate, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            decimal dcstockValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                object obj = null;
                SqlParameter prm = new SqlParameter();
                SqlCommand sccmd = new SqlCommand();
                if (calculationMethod == "FIFO")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            prm.Value = dtToDate;
                            //prm.Value = PublicVariables._dtToDate;
                            //prm.Value = PublicVariables._dtFromDate;
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", sqlcon);
                            //prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            //prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                            prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                            //prm.Value = PublicVariables._dtToDate;
                            prm.Value = dtToDate;
                            //prm.Value = PublicVariables._dtToDate;
                        }
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByFIFO", sqlcon);
                    }
                }
                sccmd.CommandType = CommandType.StoredProcedure;
                prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                prm.Value = date;
                obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decimal.TryParse(obj.ToString(), out dcstockValue);
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
            return dcstockValue;
        }
        public decimal StockValueGetOnDate(DateTime date, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            decimal dcstockValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                object obj = null;
                SqlParameter prm = new SqlParameter();
                SqlCommand sccmd = new SqlCommand();
                if (calculationMethod == "FIFO")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            //prm.Value = PublicVariables._dtFromDate;
                            prm.Value = DateTime.Now;
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            //prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                            //prm.Value = PublicVariables._dtToDate;
                            prm.Value = date;
                        }
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByFIFO", sqlcon);
                    }
                }
                sccmd.CommandType = CommandType.StoredProcedure;
                prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                prm.Value = date;
                obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decimal.TryParse(obj.ToString(), out dcstockValue);
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
            return dcstockValue;
        }
        public DataSet BalanceSheet(DateTime toDate, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BalanceSheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                prm.Value = CompanyId;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(DateTime fromDate, DateTime toDate, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForBalansheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                prm.Value = CompanyId;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(DateTime toDate, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForPreviousYears", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                prm.Value = CompanyId;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        public List<SalesMasterView> SalesInvoiceViewGraph(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                //para.Add("@VoucherNo", VoucherNo);
                var ListofPlan = sqlcon.Query<SalesMasterView>("SalesInvoiceViewGraph", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<PurchaseMasterView> ViewAllPurchseInvoiceGraph(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                //para.Add("@VoucherNo", VoucherNo);
                var ListofPlan = sqlcon.Query<PurchaseMasterView>("ViewAllPurchseInvoiceGraph", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public List<FinancialReport> GettopProduct(long CompanyId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var paramater = new DynamicParameters();
                paramater.Add("@CompanyId", CompanyId);
                var ListofPlan = sqlcon.Query<FinancialReport>("GettopProduct", paramater, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
