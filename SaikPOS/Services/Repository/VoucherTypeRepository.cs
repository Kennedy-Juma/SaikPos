using Dapper;
using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Services.Interface;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class VoucherTypeRepository :IVoucherType
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public VoucherTypeRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public List<VoucherType> GetVoucherType()
        {
            using (SqlConnection sqlcon = new SqlConnection(_conn.DbConn))
            {
                var ListofPlan = sqlcon.Query<VoucherType>("SELECT VoucherTypeId,VoucherTypeName FROM VoucherType", null, null, true, 0, commandType: CommandType.Text).ToList();
                return ListofPlan;
            }
        }
    }
}
