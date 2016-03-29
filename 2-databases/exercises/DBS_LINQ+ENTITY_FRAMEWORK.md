# LINQ / Entity Framework Exercise

### Explain in plain english:
 * what is the difference between LINQ and Entity Framework?
 * what is the relationship between LINQ and Entity Framework?

### Draw a diagram that illustrates how LINQ and Entity Framework can be used together to manage the relationship between a database and C# .NET code.

### Exercise needs to be pulled out from Migrations to just do EF/LINQ, but there are problems:

DBS Exercise for Entity Framework and Migrations
29 March 2016  -  Jo Ann Brooks

The [draft] exercise is at:  https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/master/2-databases/exercises/DBS_V9-MIGRATIONS.md
There is also an annotated version which has some more details filled in about what is actually required, at: https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/master/2-databases/exercises/DBS_V9-MIGRATIONS-annotated.md
The main idea is to get a SQL Express database working as part of a command-line [C#] app in Visual Studio.  To get this to happen, you need to:
1) set up basic command-line C# app in VS
2) have a data connection established with a server"The type or namespace 'DbContext' does not exist in the namespace 'System' (are you missing a using directive or an assembly reference?)"
3) get LINQ working with Entity Framework to access the DB
4) ...

I have pushed up a first-approximation of such a project to https://github.com/jbrooks036/zoolandia-db1
and run into the following issues:
1) It seemed a bit tricky to get the program (once coded) to push to GitHub.  I needed to use the Microsoft Windows GitHub app to sync my local repo w/ the one up on GitHub for the initial push.  
2) The program won't compile.  Error messages:
 - wrt "DbContext":  "The type or namespace 'DbContext' does not exist in the namespace 'System' (are you missing a using directive or an assembly reference?)"
 - wrt "DbSet": ditto
  - I have installed EntityFramework (EF 6.1.3 via NuGet Package Manager)
  - Have tried including all the following 'using's:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

According to MSDN, DbContext class is in System.Data.Entity namespace: https://msdn.microsoft.com/en-us/library/system.data.entity.dbcontext%28v=vs.113%29.aspx
BUT "using System.Data.Entity;" triggers a compile error on 'Data':  "The type or namespace 'Data' does not exist in the namespace 'System' (are you missing an assembly reference?)"  I've tried adding System.Data.Entity but it doesn't show up under my References, and the same error still occurs.  
There's a StackOverflow post that recommends not using System.Data.Entity with EntityFramework [although we apparently did use both in Cohort 10's Jitter project]. http://stackoverflow.com/questions/7896024/entityframework-dll-vs-system-data-entity-dll-ambiguity
The other 'using's are all rejected as "unnecessary."  
I've tried adding and deleting every 'using' that seems relevant, but still can't get it to compile.
