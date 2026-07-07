using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneIntake.SQLInjection
{

    internal class LoginService
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder
        {
                DataSource = "DESKTOP-TJF0H2P", // "." // "(local)
                InitialCatalog = "OrderManagementSystem", //database name
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
        };
        public void Login(string username, string password)
        {
            using (IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString))
            {
                /*
                building your SQL string by concatenating variables directly->
                A user could enter ' OR 1=1 -- into the username field, which would allow them to bypass your login security entirely.
                 You should always use parameterized queries.
                */

                /*
                var users = db.Query($"select * from Tbl_User where UserName = '{username}' and Password = '{password}'");  // Once you add using Dapper;, the .Query() method will appear on IDbConnection
                if (users.Any()) 
                {
                    Console.WriteLine("Login Success");
                }
               else
                {
                    Console.WriteLine("Invalid User or Password");
                }
                */



                // Prevent SQL-Injection Code 
                string query = $"select * from Tbl_User2 where UserName = @UserNameVar and Password = @PasswordVar";
                var user = db.Query(query, new
                {
                    UserNameVar = username,
                    PasswordVar = password
                }).FirstOrDefault();
                if (user!=null)
                {
                    Console.WriteLine("Login Success");
                }
                else
                {
                    Console.WriteLine("Invalid User or Password");
                }
            }
        }
    }
}
