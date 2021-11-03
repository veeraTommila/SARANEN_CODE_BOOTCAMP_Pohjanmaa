To scaffold the Northwind database, run the command:

Scaffold-DbContext "Server=localhost\SQLEXPRESS2021;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models