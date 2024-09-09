using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace NFL.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NFLDbContext>
    {
        public NFLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NFLDbContext>();
            var connectionString = "server=162.144.12.227;database=jose_NFL;user=jose_admin;password=Baltimore_123!";
            builder.UseMySQL(connectionString);
            return new NFLDbContext(builder.Options);
        }
    }
}