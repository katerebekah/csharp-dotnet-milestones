# Entity Framework

* http://www.tutorialspoint.com/entity_framework/entity_framework_overview.htm
* http://tektutorialshub.com/introduction-to-entity-framework/
* http://stackoverflow.com/questions/1279613/what-is-an-orm-and-where-can-i-learn-more-about-it

### What is an ORM (Object Relational Mapper)
* ORMS solve the problem of mismatch between relational data and objects found in code.
* There are many ORMS but Entity Framework is frequently used in .NET applications
* ORMS connect to databases and manage communication between the database and your C# code that will be querying, updating, creating, deleting records int he database.
* ORMs save developers from having to embed sql in their programs as strings
* ORMS map to tables allowing developers to easily create objects that will have the matching properties making inserting new data easier since there are classes often called models that directly reflect the database table they represent. 

*![Entity Framework](http://www.entityframeworktutorial.net/Images/ORM.png)

### What is Entity Framework?:
* Popular ORM used in .NET applications
* There are many techniques for using it so looking for specific examples can be tricky
* It is typically added to your .NET app via Nuget Package Manager. 

### Why use and ORM (Object Relation Mapper) like Entity Framework:
* Promotes a consistent way for a team to access data
* Can use LINQ vs embedded sql or calling stored procedures
* Can use objects to represent data which makes querying and manipulating data much easier. 
* Using objects enables developers to debug in a way that embedded sql or stored procedures cannot.
* Promotes a cleaner code base by allowing developers to develop against common objects that represent relational data.
### How It Works
* An application that used Entity Framework will used what is called "DBContext" DBContext is used to not only to make a connection to to a database but also directly maps tables in the database to objects often called "domain objects" or "models". 
* The code sample below shows a typical example of a DBContext. You can see that the model called "Employee" is being directly assocated with a table in the database called "Employee".
```

namespace MyDatabase.Models
{
    public class MyStoreContext: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<Department>()
              .ToTable("Department")
              .HasKey(d => d.DepartmentId);
        }
    }
}
