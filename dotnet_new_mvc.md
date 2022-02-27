Dotnet new MVC starting commands:

For .csproj file: 
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.5

For MyContext File:

using Microsoft.EntityFrameworkCore;
namespace Namespace.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        //public DbSet<Class> TableName { get; set; }
    }
}

For .json File:

,
    "DBInfo":
    {
        "Name": "MySQLconnect",
        "ConnectionString": "server=localhost;userid=root;password=root;port=3306;database=monsterdb;SslMode=None"
    }

For Startup.cs:

services.AddDbContext<MyContext>(options => options.UseMySql (Configuration["DBInfo:ConnectionString"]));

For HomeController.cs File:

private MyContext _context;

_context = context;