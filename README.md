# June2026

## SQL Injection Demonstration

This project demonstrates how SQL injection vulnerabilities occur when using string concatenation in SQL queries.

![SQL Injection Demonstration](./JuneIntake.SQLInjection/images/photo_2026-07-07_23-17-38.jpg)

### Vulnerability Explained
As shown in the screenshot, the application is susceptible to SQL injection because it concatenates user input directly into the query string:

```csharp
var users = db.Query($"select * from Tbl_User where UserName = '{username}'");