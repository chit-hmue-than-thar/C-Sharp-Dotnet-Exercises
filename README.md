# June2026

## SQL Injection Demonstration

This project demonstrates how SQL injection vulnerabilities occur when using string concatenation in SQL queries.

![SQL Injection Demonstration - Access](./JuneIntake.SQLInjection/images/photo_2026-07-07_23-17-38.jpg)

![SQL Injection Demonstration - Delete Database Data](./JuneIntake.SQLInjection/images/sqlinject_del_data.png)

![SQL Injection Demonstration - After injection,Database Data Deleted ](./JuneIntake.SQLInjection/images/database_data_del_preview.png)

![Prevent SQL Injection](./JuneIntake.SQLInjection/images/prevent_sql_injection.png)


### Vulnerability Explained
As shown in the screenshot, the application is susceptible to SQL injection because it concatenates user input directly into the query string:

```csharp
var users = db.Query($"select * from Tbl_User where UserName = '{username}'");