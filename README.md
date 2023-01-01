# Attendence System
An ASP.NET MVC application which performs basic CURD operations and illustrates connection between application and database.

# Getting Started
To get started with this project, follow these steps:

1) Clone or download the repository to your local machine.<br>
```cmd
  git clone https://github.com/notwld/AttendenceSystem
```
2) Run `database_init.sql` and `stored_procedure.sql` scripts in SQLServer.
3) Open the solution file in Visual Studio.<br>
4) Change the connection string in `ConnectionString.cs`
```cmd
  "Data Source=*insert your server name*; Initial Cadtalog=*insert your database name*;Integrated Security = True;"
```
or
```cmd
  "Data Source=*insert your server name*; Initial Cadtalog=*insert your database name*;User=*insert your username*;Password=*insert your password*;"
```
`Note: If there's an error in initializing a connection to SQLSever, make sure to start sql services and TCP/IP protocol enabled via SQL Server Configration Manager.`<br>
5) Run the application by pressing F5 or by clicking the Start button.

