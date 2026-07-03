using Dapper;
using JuneIntake.ConsoleApp2;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Reflection;

DapperCrudService service = new DapperCrudService();
service.Read();
//service.Delete();

//dynamic stu = new { Id = 1, Name = "Mg Mg " };
//stu.Id = 2; // Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: 'Property or indexer '<>f__AnonymousType0<int,string>.Id' cannot be assigned to -- it is read only'
//stu.jdsfhdnasl = 2;  //Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: '' <> f__AnonymousType0<int, string>' does not contain a definition for 'jdsfhdnasl''
//stu.Study();  // ''<>f__AnonymousType0<int,string>' does not contain a definition for 'Study''


public class Customer
{

    // must be same as datatypes in DB , otherwise Dapper causes error
    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public char Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string MobileNo { get; set; }
}