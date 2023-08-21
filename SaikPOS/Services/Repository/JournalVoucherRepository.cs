using Dapper;
using SaikPOS.Data;
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
    public class JournalVoucherRepository : IJournalVoucher
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public JournalVoucherRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<JournlVoucherView> ViewJouranlVoucherView(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                var ListofPlan = sqlcon.Query<JournlVoucherView>("JournalVoucherView", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
        public JournalMaster EditJournalVoucher(long JournalMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@JournalMasterId", JournalMasterId);
                var result = sqlcon.Query<JournalMaster>("SELECT *FROM JournalMaster where JournalMasterId=@JournalMasterId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
                return result;
            }
        }
        public bool JournalVoucherDelete(long JournalMasterId, string VoucherNo, long VoucherTypeId, long YearId, long CompanyId)
        {
            SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("JournalVoucherDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                para = cmd.Parameters.Add("@JournalMasterId", SqlDbType.BigInt);
                para.Value = JournalMasterId;
                para = cmd.Parameters.Add("@VoucherNo", SqlDbType.NVarChar);
                para.Value = VoucherNo;
                para = cmd.Parameters.Add("@VoucherTypeId", SqlDbType.BigInt);
                para.Value = VoucherTypeId;
                para = cmd.Parameters.Add("@YearId", SqlDbType.BigInt);
                para.Value = YearId;
                para = cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt);
                para.Value = CompanyId;
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
        public string JournalvoucherNo(long CompanyId, long FinancialYearId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                string val = string.Empty;
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                return val = sqlcon.Query<string>("SELECT ISNULL( MAX(SerialNo+1),1) FROM JournalMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId", para, null, true, 0, commandType: CommandType.Text).FirstOrDefault();
            }
        }
        public bool VouchernoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@CompanyId", CompanyId);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@VoucherNo", VoucherNo);
                return sqlcon.Query<bool>("SELECT VoucherNo FROM JournalMaster where CompanyId=@CompanyId AND FinancialYearId=@FinancialYearId AND VoucherNo=@VoucherNo", para, null, true, 0, CommandType.Text).SingleOrDefault();
            }
        }
        public List<JournalDetails> JournalVoucherView(long JournalMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@JournalMasterId", JournalMasterId);
                var ListofPlan = sqlcon.Query<JournalDetails>("SELECT *FROM JournalDetails where JournalMasterId=@JournalMasterId", para, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
        public List<JournlDetilsView> JournalVoucherPrint(long JournalMasterId)
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var para = new DynamicParameters();
                para.Add("@JournalMasterId", JournalMasterId);
                var ListofPlan = sqlcon.Query<JournlDetilsView>("JournalVoucherPrint", para, null, true, 0, commandType: CommandType.StoredProcedure).ToList();
                return ListofPlan;
            }
        }
    }
}
