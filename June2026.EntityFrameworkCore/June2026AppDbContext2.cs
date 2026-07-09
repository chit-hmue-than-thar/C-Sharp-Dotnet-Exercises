using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026.EntityFrameworkCore
{
    internal class June2026AppDbContext2 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-TJF0H2P", // "." // "(local)
                    InitialCatalog = "OrderManagementSystem", //database name
                    UserID = "sa",
                    Password = "sasa@123",
                    TrustServerCertificate = true
                };
                optionsBuilder.UseSqlServer(sb.ConnectionString); // mssql used
                // optionsBuilder.UseOracle(sb.ConnectionString); // if use oracle
                // optionsBuilder.UseMySql(sb.ConnectionString); // if use mysql
            }
        }

            public DbSet<SalemanEntity> Salemans { get; set; } // DbSet for SalemanEntity
    }
 }

