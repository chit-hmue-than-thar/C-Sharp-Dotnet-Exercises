using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneIntake.ConsoleApp2
{
    internal class DapperCrudService
    {
        private readonly SqlConnectionStringBuilder sb;
        public DapperCrudService()
        {
             sb = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-K38OUQ8", // "." // "(local)
                InitialCatalog = "OrderManagementSystem", //database name
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
        }
        public void Read() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                List<CustomerDto> lst = db.Query<CustomerDto>("SELECT * FROM [dbo].[Tbl_Customer]").ToList(); // Click Ctrl+'.' on lst to change from Dynamic List to 

                foreach (var item in lst)
                {
                    Console.WriteLine($"Id: {item.CustomerID}, Name: {item.FirstName} {item.LastName}, Email: {item.Email} ");
                }
            }
        }
        public void Create() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int res = db.Execute("INSERT INTO [dbo].[Tbl_Customer] ( [FirstName], [LastName], [Address], [ZipCode], [Gender], [BirthDate], [Email], [MobileNo]) " +
           "VALUES ( 'Thar', 'Thar', '117, 57C Mandalay', '22109', 'F', '2003-01-09', 'than.thar@gmail.com', '097820278890');");

                Console.WriteLine($"Rows Created: {res}");
            }
            
        }
        public void Update()
        {
            using(IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();

                int res = db.Execute("UPDATE [dbo].[Tbl_Customer]\r\nSET [Email] = 'updated.email@example.com'\r\nWHERE [CustomerID] = 2;");
                Console.WriteLine($"Rows Updated: {res}");

            }
        }
        public void Delete() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();

                int res = db.Execute("DELETE FROM [dbo].[Tbl_Customer] WHERE [Address] = '117, 57C Mandalay';");
                Console.WriteLine($"Rows Deleted: {res}");
                
            }
            
        }

    }
}
