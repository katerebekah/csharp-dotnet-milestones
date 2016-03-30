# LINQ / Entity Framework Exercises

### Coding Exercise:

N.B. This exercise needs a good review and some help before it is ready for the students!
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
