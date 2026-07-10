// See https://aka.ms/new-console-template for more information


using DatabaseFirst.ClassLibrary.AppDbContextModels;
using June2026.EntityFrameworkCore;
using JuneIntake.DatabaseScaffoldTest.TestAppDbContextModels;

June2026AppDbContext2 db = new June2026AppDbContext2();

// LINQ
// EFcore - no need SQL queries to execute
List<SalemanEntity> lst = db.Salemans.ToList();

//foreach (var item in lst)
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Name);
//    Console.WriteLine("--------------");
//}

//var saleman2 = db.Salemans.Where(x => x.Id == 10).FirstOrDefault();

//SalemanEntity? saleman3 = db.Salemans.Where(x => x.Id == 4).FirstOrDefault();
//if(saleman3 is null)
//{
//    Console.WriteLine("Saleman not found");
//} 
//else
//{
//    saleman3.Name = "Han Thar"; // update
//    int res = db.SaveChanges();
//}


// insert

/*
SalemanEntity salemanEntity = new SalemanEntity()
{
    Name = "Ko Khant"
};
db.Salemans.Add(salemanEntity);
db.SaveChanges(); //save to database
*/


/*
var saleman1 = db.Salemans.Where(x => x.Id == 1).FirstOrDefault();
if(saleman1 is null)
{
    Console.WriteLine("Saleman not found");
    return;
}
db.Salemans.Remove(saleman1); //delete
db.SaveChanges();
*/

//AppDbContext db2 = new AppDbContext();
//List<TblBrand> brandList = db2.TblBrands.ToList();
//List<TblCustomer> customerList = db2.TblCustomers.ToList();
//List<TblOrderDetail> orderDetailList = db2.TblOrderDetails.ToList();
//List<TblOrder> orderList = db2.TblOrders.ToList();
//List<TblProduct2> productList = db2.TblProduct2s.ToList();
//List<TblSaleman> salemanList = db2.TblSalemen.ToList();
//List<TblUser2> userList = db2.TblUser2s.ToList();


// using JuneIntake.DatabaseScaffoldTest database layer
AppDbContext2 TestDb = new AppDbContext2();
List<User> userLst = TestDb.Users.ToList();

foreach(var user in userLst)
{
    Console.WriteLine($"{user.Username} - {user.Email}");
}

List<Department> depLst = TestDb.Departments.ToList();

//List<Book> bookLst = TestDb.Books.ToList();

//foreach (var book in bookLst)
//{
//    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedYear}");
//}

Console.ReadLine();

