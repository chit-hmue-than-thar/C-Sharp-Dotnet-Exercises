using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace JuneIntake.ConsoleApp1
//{
//    internal class AdoDotNetService
//    {
//        public void Read()
//        {
//            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
//            sb.DataSource = "DESKTOP-TJF0H2P"; // "." // "(local)
//            sb.InitialCatalog = "OrderManagementSystem"; //database name
//            sb.UserID = "sa";
//            sb.Password = "sasa@123";
//            sb.TrustServerCertificate = true;

//            Console.WriteLine($"Connection String : {sb.ConnectionString}");

//            SqlConnection connection = new SqlConnection(sb.ConnectionString);
//            Console.WriteLine("Connection opening ...");
//            connection.Open();
//            Console.WriteLine("Connection Opened ...");

//            string query = @"SELECT 
//                           [CustomerID]
//                          ,[FirstName]
//                          ,[LastName]
//                          ,[Address]
//                          ,[ZipCode]
//                          ,[Gender]
//                          ,[BirthDate]
//                          ,[Email]
//                          ,[MobileNo]
//                      FROM [dbo].[Tbl_Customer]";

            
            
//          SqlCommand cmd = new SqlCommand(query, connection);
//            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            adapter.Fill(dt);

//            Console.WriteLine("Connection closing ...");
//            connection.Close();
//            Console.WriteLine("Connection closed ...");

//            // DataSet
//            // DataTable
//            // DataRow
//            // DataColumn

//            // to avoid date format conflicts, user year-month-date (yyyy-MMM-dd)
//            // 12-11-2025 (month-date-year / date-month-year)
//            // 2025-11-12 (year-month-date)

//            foreach (DataRow item in dt.Rows)
//            {
//                Console.WriteLine(item["CustomerID"]);
//                Console.WriteLine(item["FirstName"]);
//                Console.WriteLine(item["LastName"]);
//                Console.WriteLine(item["Address"]);
//                Console.WriteLine(item["ZipCode"]);
//                //Console.WriteLine(item["BirthDate"]);
//                DateTime dtDob = Convert.ToDateTime(item["BirthDate"]);
//                Console.WriteLine(dtDob.ToString("dd-MMM-yyyy"));
//            }
//        }

//        public void Create()
//        {
//            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
//            sb.DataSource = "DESKTOP-TJF0H2P";
//            sb.InitialCatalog = "OrderManagementSystem";
//            sb.UserID = "sa";
//            sb.Password = "sasa@123";
//            sb.TrustServerCertificate = true;

//            SqlConnection connection = new SqlConnection(sb.ConnectionString);
//            connection.Open();

//            string query = @"INSERT INTO [dbo].[Tbl_Customer] (
//                            [FirstName], 
//                            [LastName], 
//                            [Address], 
//                            [ZipCode], 
//                            [Gender], 
//                            [BirthDate], 
//                            [Email], 
//                            [MobileNo]
//                        ) VALUES 
//                        ('Zin', 'Mar', '78 Industry St, Mandalay', '05001', 'F', '1999-04-12', 'zin.mar@example.com', '09400123456'),
//                        ('Htet', 'Aung', '22 River Rd, Yangon', '11011', 'M', '2001-09-25', 'htet.aung@example.com', '09798765432'),
//                        ('Ei', 'Phyu', '90 Pagoda St, Bagan', '07021', 'F', '1997-12-05', 'ei.phyu@example.com', '09250112233'),
//                        ('Kyaw', 'Zin', '15 Bogyoke Rd, Mawlamyine', '12055', 'M', '1994-06-18', 'kyaw.zin@example.com', '09966554433'),
//                        ('Thiri', 'Win', '44 Hill View, Pyin Oo Lwin', '06088', 'F', '2003-01-30', 'thiri.win@example.com', '09509988776');";

//             SqlCommand cmd = new SqlCommand(query, connection);
//             int result = cmd.ExecuteNonQuery();

//             connection.Close();

//        }

//        public void Update()
//        {
//            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
//            sb.DataSource = "DESKTOP-TJF0H2P";
//            sb.InitialCatalog = "OrderManagementSystem";
//            sb.UserID = "sa";
//            sb.Password = "sasa@123";
//            sb.TrustServerCertificate = true;

//            SqlConnection connection = new SqlConnection(sb.ConnectionString);
//            connection.Open();

//            string query = @"UPDATE [dbo].[Tbl_Customer]
//                           SET [FirstName] = 'Chit'
//                              ,[LastName] = 'Hmue'
//                              ,[Address] = '78 New Road, Mandalay'
//                              ,[ZipCode] = '05011'
//                              ,[Gender] = 'F'
//                              ,[BirthDate] = '2000-05-15'
//                              ,[Email] = 'chit.hmue@example.com'
//                              ,[MobileNo] = '09123456789'
//                         WHERE [Email] = 'chit.thar@example.com';";

//            SqlCommand cmd = new SqlCommand(query, connection);
//            int result = cmd.ExecuteNonQuery();
//            connection.Close();

//        }

//        public void Delete()
//        {
//            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
//            sb.DataSource = "DESKTOP-TJF0H2P";
//            sb.InitialCatalog = "OrderManagementSystem";
//            sb.UserID = "sa";
//            sb.Password = "sasa@123";
//            sb.TrustServerCertificate = true;

//            SqlConnection connection = new SqlConnection(sb.ConnectionString);
//            connection.Open();

//            string query = @"DELETE FROM [dbo].[Tbl_Customer]
//            WHERE [Email] = 'ei.phyu@example.com';";

//            SqlCommand cmd = new SqlCommand(query, connection);
//            int result = cmd.ExecuteNonQuery();
//            connection.Close();

//        }
//    }
//}







// Note :ADO.net CRUD Code Changes For Object Initialization Simplified

namespace JuneIntake.ConsoleApp1
{
    internal class AdoDotNetService
    {
        //SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        private readonly SqlConnectionStringBuilder sb;
        public AdoDotNetService()
        {
            sb = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-TJF0H2P", // "." // "(local)
                InitialCatalog = "OrderManagementSystem", //database name
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
        }
        
        public void Read()
        {
            Console.WriteLine($"Connection String : {sb.ConnectionString}");

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection opening ...");
            connection.Open();
            Console.WriteLine("Connection Opened ...");

            string query = @"SELECT 
                           [CustomerID]
                          ,[FirstName]
                          ,[LastName]
                          ,[Address]
                          ,[ZipCode]
                          ,[Gender]
                          ,[BirthDate]
                          ,[Email]
                          ,[MobileNo]
                      FROM [dbo].[Tbl_Customer]";



            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Console.WriteLine("Connection closing ...");
            connection.Close();
            Console.WriteLine("Connection closed ...");

            // DataSet
            // DataTable
            // DataRow
            // DataColumn

            // to avoid date format conflicts, user year-month-date (yyyy-MMM-dd)
            // 12-11-2025 (month-date-year / date-month-year)
            // 2025-11-12 (year-month-date)

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["CustomerID"]);
                Console.WriteLine(item["FirstName"]);
                Console.WriteLine(item["LastName"]);
                Console.WriteLine(item["Address"]);
                Console.WriteLine(item["ZipCode"]);
                //Console.WriteLine(item["BirthDate"]);
                DateTime dtDob = Convert.ToDateTime(item["BirthDate"]);
                Console.WriteLine(dtDob.ToString("dd-MMM-yyyy"));
            }
        }

        public void Create()
        {

            Console.WriteLine($"Connection String : {sb.ConnectionString}");

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"INSERT INTO [dbo].[Tbl_Customer] (
                            [FirstName], 
                            [LastName], 
                            [Address], 
                            [ZipCode], 
                            [Gender], 
                            [BirthDate], 
                            [Email], 
                            [MobileNo]
                        ) VALUES 
                        ('Zin', 'Mar', '78 Industry St, Mandalay', '05001', 'F', '1999-04-12', 'zin.mar@example.com', '09400123456'),
                        ('Htet', 'Aung', '22 River Rd, Yangon', '11011', 'M', '2001-09-25', 'htet.aung@example.com', '09798765432'),
                        ('Ei', 'Phyu', '90 Pagoda St, Bagan', '07021', 'F', '1997-12-05', 'ei.phyu@example.com', '09250112233'),
                        ('Kyaw', 'Zin', '15 Bogyoke Rd, Mawlamyine', '12055', 'M', '1994-06-18', 'kyaw.zin@example.com', '09966554433'),
                        ('Thiri', 'Win', '44 Hill View, Pyin Oo Lwin', '06088', 'F', '2003-01-30', 'thiri.win@example.com', '09509988776');";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

        }

        public void Update()
        {
            Console.WriteLine($"Connection String : {sb.ConnectionString}");

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"UPDATE [dbo].[Tbl_Customer]
                           SET [FirstName] = 'Chit'
                              ,[LastName] = 'Hmue'
                              ,[Address] = '78 New Road, Mandalay'
                              ,[ZipCode] = '05011'
                              ,[Gender] = 'F'
                              ,[BirthDate] = '2000-05-15'
                              ,[Email] = 'chit.hmue@example.com'
                              ,[MobileNo] = '09123456789'
                         WHERE [Email] = 'chit.thar@example.com';";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void Delete()
        {
            Console.WriteLine($"Connection String : {sb.ConnectionString}");

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"DELETE FROM [dbo].[Tbl_Customer]
            WHERE [Email] = 'ei.phyu@example.com';";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}

