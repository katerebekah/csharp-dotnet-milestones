# Step by Step Use Entity Framework7 and MVC6 to Retrieve Chinook Music Database Data#
* Fork or download the Web Api Template located here: [Api Template](https://github.com/lynnsamuelson/ASP.NET_WebApi_Template) 
* Modify the connection string to link to your local chinook database. The string is located in the app.settings.json file. 
* Make a model from the album table. You can modify the file called "Modelone" in the template, within the models folder.
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
* Run your app. Check your results in PostMan or other app that allows you to view JSON results.

![Results of calling the GetAll Action](https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/WebApiCrud_5_31/4-api-era/resources/Other%20Resources/JsonResultsInPostman.png)

###Now you need create actions that return the following information:
 * Bring back 100 artists and order by name (hint new model class, new entry to the entityset in the DBContext class)
 * Pass in a search phase to the Artist table, query the artist table by the search phrase, output the results. 
 * List all the artist on a particular album you like(hint, will need to pass an album id in the calling url to the action)
 * List all of the albums by your favorite artist.
 * Create a class that will hold information regarding concerts you would like to attend. Create a list containing
    your concerts of choice. Set up several properties. Query your favorite concert list.
