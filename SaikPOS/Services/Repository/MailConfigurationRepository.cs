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
    public class MailConfigurationRepository : IMailConfiguration
    {
        private readonly ApplicationDbContext _context;
        private readonly DatabaseConnection _conn;
        public MailConfigurationRepository(ApplicationDbContext context, DatabaseConnection conn)
        {
            _context = context;
            _conn = conn;
        }
        public MailConfigurations Edit(int id)
        {
            MailConfigurations returnView = _context.MailConfigurations.Find(id);
            return returnView;
        }
        public void Update(MailConfigurations model)
        {
            _context.MailConfigurations.Update(model);
            _context.SaveChanges();
        }
    }
}
