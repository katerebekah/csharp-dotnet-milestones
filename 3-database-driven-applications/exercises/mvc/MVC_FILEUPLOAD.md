
###Upload And Save a File to the Database
##Learning Objectives
* Create a view that displays all of the documents in the database table and order by upload date.
* Give the user and opportunity to upload a new file and give the file a name.
* Create the ability to download the file.
##Bonus
* Limit the type of files the user can upload to a particular type of file like jpeg, pdf, or excel.
* Add a foreign key to another table in your database and display some data from both tables. 

##Steps
* Create a table in your Chinook or Zoolandia database that fits this definition:
```
CREATE TABLE [dbo].[Document] (
    [DocumentId]   INT             IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (100)   NOT NULL,
    [Contents]     VARBINARY (MAX) NOT NULL,
    [FileName]     VARCHAR (200)   NOT NULL,
    [UploadDate]   SMALLDATETIME   NOT NULL,
    [UploadUserId] VARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([DocumentId] ASC)
);
```
* Create a new asp.net mvc application by choosing file/new project/ asp.net web application. When the next screen displays choose "Empty" then check the box for "MVC".
* Create the DbContext class and the model you will need for the "Document" database table.
* Add your connection string to the web config.
* Add a new controller called "Document".
* Make sure your "Route.Config" file points to the controller called "Document" and the action called "Index".
* Your are going to need a view model class to specify the data needed to display on the view. It need to look like this:
```
  public class DocumentDetailsViewModel
    {
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public byte[] Contents { get; set; }
        public DateTime UploadDate { get; set; }
        public string UploadUserId { get; set; }
        public List<Document> Documents { get; set; }
    }
```
* Go to the action called "Index" in your controller. Add an attribute above the action, that will indicate that this action will get data rather than post.
```
   [HttpGet]
```
* Within your index action you need to create an instance of your DBContext and write a linq query that gets all the data from the 
"Documents" and orders them by upload date. Make sure you do not bring back the column called "Contents" since it holds the binary data of uploaded files and can cause
slow queries.
* Create the index view by right clicking on the name of the action result called "Index" and add a view. Accept the defaults when propmted.


