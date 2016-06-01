#MVC6 Web Api Data Access with Entity Framework 7#

* As of the writing of this document MVC6 is in Release Candidate 2. A starter template was created that dealt with several configuration issues and provided a starting point for data access using Entity Framework 7.
* The Web Api Template can be found here: [Api Template](https://github.com/lynnsamuelson/ASP.NET_WebApi_Template) 
* Entity Framework 7 is included in MVC 6 apps so it is not necessary to install a nuget package to get the Entity Framework associated assemblies. 

##What is MVC6 Web API##
* ASP.NET MVC and ASP.NET Web Api have become one (MVC + Web API = MVC 6)and now uses the same libraries
* MVC6 Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browsers and mobile devices.
* MVC6 Web API is an ideal platform for building RESTful applications on the .NET Framework
* MVC6 is open source and is available on GitHub at: [ASP.NET on GitHub](https://github.com/aspnet)
* MVC6 framework which enables cross-platform runtimes for Mac OS X and Linux as well as Windows
* MVC6 is a small optimized runtime that is very modular and portable. It includes a subset of the traditional .NET Framework libraries and can be packaged and deployed together with your application. 

###Example of a MVC6 Project###
![MVC6 Solution Example](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/Asp.NETCOREProject.png)
* As you can see there have been made significant changes to the default empty web application project structure which consists of two folders: “Solution Items” with a global.json file and “src” which contains the web project itself. Just get a thorough overview:
* To read more about the changes related to MVC6 the following resource is useful: [Brace yourself, ASP.NET Core 1.0 is coming!](https://www.jayway.com/2016/02/12/brace-yourself-asp-net-core-1-0-is-coming/)
* Your connection string will no longer be housed in a web.config file. It now resides it the appsettings.json file. 

###Where is the connection string to the Database?###
![MVC6 Solution Example](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/ConnectionString.png)

### Database Context ###
* Still has an entity set (collection of model to table mappings)
* In this example only one table is being mapped to but you can map to as many tables you need from the database. You don't need to include all tables if not needed for your app. 

![DB Context Example](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/dbcontextMVC6.png)

* In asp.net mvc 5 the DBContext name had to match the name in the web config. Now the name of the connection is mapped to the DBContext in the "ConfigureServices" method of the "Startup.cs" file. 
* ![Configure Services ](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/configureServices.png)

* Models that represent your tables look and behave the same way they did in asp.net mvc web applications.
![Model Class](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/AlbumModel.png)

###The Controller##
* In MVC 6 the controller for web is not a seperate api controller, it can just implement Controller.
* In this example the db context is being injected into the constructor.
* The "GetAll" action returns a json representation of all of the albums in the database.
* 
![Simple Controller Class](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/WebApiController.png)

### Route Configuration ###
*Route Configuration is now done in the "Startup.cs" file.
```

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=GetAll}/{id?}");
            });
```

### When the action is called via the url the results of the query appear

![Results of calling the GetAll Action](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/JsonResultsInPostman.png)


