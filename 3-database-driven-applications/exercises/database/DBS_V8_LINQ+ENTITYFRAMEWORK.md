# LINQ / Entity Framework Exercises

## Coding Exercise

Completion of this exercise will be the first step for Migrations exercise later.

The main idea is to get a SQL Express database working, using Entity Framework and LINQ as part of a command-line [C#] app in Visual Studio.  I have not been able to do this, nor find anyone else who knows how (NSS classes have always waited until the MVC stage to work w/ EF & LINQ).  My efforts to get this to happen, with lots of trial and error include:

1. Create a C# command line app (project) to develop an animal database   
  * set up repo on github (no .gitignore needed?) and clone to your machine
  * VS Start => New project => ConsoleApp, save to new project folder on your machine (fig. 1)
  * once you get working on your project and wanting to push changes, you may need to use the Windows app for GitHub the very first time before being able to push from Windows Power Shell (posh).  I did. (learned this trick from Eliza)

2. Create the database:
 * Server Explorer => Create database
    * In Windows File Explorer, copy the full path of your project directory, then paste it into the database file name field in the dialog box, appending your solution's name to the end of it
    * When you click ok, it will say '... doesn't exist, do you want to create it?'  Say 'yes'.

3. Get LINQ working with Entity Framework to access the DB
  * You will need to open NuGet package manager to find and install Entity Framework.
  * This is where I ran into problems (see below).  

4. Seed the database with two (or more) instances of the objects you've already created

5. Ensure you can view them via the Server Explorer.

6. Write your program to populate the DB.

#### Problems getting basic program to compile:
I have pushed up a first-approximation of such a project to https://github.com/jbrooks036/zoolandia-db1
and run into problems getting the program to compile.  Error messages:
 * wrt "DbContext":  "The type or namespace 'DbContext' does not exist in the namespace 'System' (are you missing a using directive or an assembly reference?)"
 * wrt "DbSet": ditto

 * EntityFramework (EF 6.1.3) is installed via NuGet Package Manager
 * Have tried including all the following 'using's:
   * using System;
   * using System.Collections.Generic;
   * using System.Linq;
   * using System.Web;
   * using System.Data.Entity;
   * using Microsoft.Data.Entity;
   * using System.Core.dll;

 * There is one set of problems with `System.Data.Entity`
    * According to MSDN, `DbContext` class is in `System.Data.Entity` namespace:    
     * https://msdn.microsoft.com/en-us/library/system.data.entity.dbcontext%28v=vs.113%29.aspx

   * BUT "`using System.Data.Entity;`" triggers a compile error on "`Data`":  `"The type or namespace 'Data' does not exist in the namespace 'System' (are you missing an assembly reference?)"`  
   * I've tried adding "`using System.Data.Entity`" but it doesn't show up under my `References`, and the same error still occurs.  
   * There's a StackOverflow post that recommends not using `System.Data.Entity` with EntityFramework [although we apparently did use both in Cohort 10's Jitter project].
    * http://stackoverflow.com/questions/7896024/entityframework-dll-vs-system-data-entity-dll-ambiguity

* The other `using`s are all rejected as "unnecessary."  
 * I've tried adding and deleting each `using` that seems relevant, but still can't get it to compile.

## Two other exercises that might be useful, but do not involve Coding
#### 1) Explain in plain english:
  * what is the difference between LINQ and Entity Framework?
  * what is the relationship between LINQ and Entity Framework?

#### 2) Draw a diagram that
 * illustrates how LINQ and Entity Framework can be used together to manage the relationship between a database and C# .NET code.
=======
### Coding Exercise:
## Installing a local version of the Chinook Database
* We will be coding against the Chinook database.
* A sql script for installing can be downloaded from here. https://chinookdatabase.codeplex.com/
* Once you have downloaded the zip file. You will see several scripts.
* Open the one called "Chinook_SqlServer.sql"
* Open the file in a text editor. 
* Select and copy all of the text in the file.
* In Visual Studio open the "Sql Server Object Explorer Window"
* Right click on your server icon. It should be the same name as your computer.
* Choose "New Query"
* Paste the contents of "Chinook_SqlServer.sql" into the query window.
* Click the green arrow to the left of the window to run the sql.
* Once the code has executed successfully, refresh your server in the "Sql Server Object Explorer Window"
* You should now see the chinook database. 

Create an app to query the Chinook Database and practice various linq queries. 
* Create a console app.
* Go to "Tools/Nuget Package Manager and add "Entity Framework".
* Open your "App.config" file. You will need to add a connection string to your database. The easiest way to get the connection string is to right click on your chinook database in "Sql Server Object Explorer", you will need to add the following "connectionStrings" section to your app config file. You will need to modify the connection to match your local chinook database. 
 ```
 <connectionStrings>
    <add name="ChinookContext" connectionString="Data Source=alienware-pc\sqlexpress;Initial Catalog=Chinook;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  providerName="System.Data.SqlClient" />
  </connectionStrings>
 ```
* Add a folder to your project and call it "Models".
* Add a class and call it "Artist", it will have properties that model your database table called "Artist"
```
namespace BasicEntityFrameworkDataAccess.Models
{
   public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}

```
* Add a class to the models folder called "Genre"
```
namespace BasicEntityFrameworkDataAccess.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
```

* Add a class and call it "ChinookContext"
* Add the following code:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BasicEntityFrameworkDataAccess.Models
{
    public class ChinookContext: DbContext
    {
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .ToTable("Artist")
                .HasKey(c => c.ArtistId);


            modelBuilder.Entity<Genre>()
                .ToTable("Genre")
                .HasKey(c => c.GenreId);
        }


    }
}
```
* In program.cs instanciate an instance of the "ChinookContext" class. 
* Your code will look something like this:
```

        static void Main(string[] args)
        {
            Database.SetInitializer<ChinookContext>(null);

            ChinookContext dbContext = new ChinookContext();
            var artistSearch = "Sabbath";
            var artists = dbContext.Artist.Where(a => a.Name.Contains(artistSearch));
```
###Now you need to write linq queries that answer the following questions:
 * Bring back 100 artists and order by name
 * Is there a genre for TV show?
 * List the artist on a particular album you like(hint, will need to create a new model and set up in Chinook context)
 * List all of the albums by your favorite artist.
 * List the total bill and mailing address for the following customers with an id of (10, 38, 57)
 * Create a class that will hold information regarding concerts you would like to attend. Create a list containing
    your concerts of choice. Set up several properties. Query your favorite concert list.
