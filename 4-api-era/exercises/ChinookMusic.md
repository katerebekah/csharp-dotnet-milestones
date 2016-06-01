# Step by Step Use Entity Framework7 and MVC6 to Retrieve Chinook Music Database Data#
* Fork or download the Web Api Template located here: [Api Template](https://github.com/lynnsamuelson/ASP.NET_WebApi_Template) 
* Modify the connection string to link to your local chinook database. The string is located in the app.settings.json file. 
* Make a model from the album table. Youc modify the file called "Modelone" in the template, within the models folder.
* Modify the DbContext class to use your "Album" model.
* Go to your home controller and inject the DbContext into the constructor for the "HomeController" class.

```
 public class HomeController :Controller
    {
        private ApplicationDbContext dbContext { get; set; }
        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }
```

*  Modify the GetAll method in the "GetAll() function to look like this:
```
 [HttpGet]
        public IEnumerable<Album> GetAll()
        {
            var products = dbContext.Album.ToList();
            return products;
        }
```
