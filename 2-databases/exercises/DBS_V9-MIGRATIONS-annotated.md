# VS+DB Seeding and Migrations Exercise
This exercise probably needs a good review/editing before it is ready for the students!


1. Create a project to develop an animal database   
  * set up repo on github (no .gitignore needed?) and clone to your machine
  * VS Start => New project => ConsoleApp, save to new project folder on your machine (fig. 1)
  *

2. Create the database:
 * Server Explorer => Create database
    * In Windows File Explorer, copy the path of the project, then paste it into the database file name field in the dialog box, appending your solution's name to the end of it
    * When you click ok, it will say 'that doesn't exist, do you want to create it?'  Say 'yes'.

3.  You will need to open NuGet package manager to find and install Entity Framework.   

2. Seed the database with two (or more) instances of the objects you've already created

3. Ensure you can view them via the Server Explorer.

2. Add a column to your model for 'habitat', and add a migration for it.

3. Add another column to your model for 'diet' and add a migration for it.

4. View your database through Server Explorer and confirm that the two additional columns have been added.

5. View your migrations files and confirm that you can find the up migrations in your codebase.

6. Remove the project's Data Connections in your Server Explorer.  Try running your app and see what happens.

7. Refresh the project's Data Connections in the Server Explorer and try to run your app again.  What happens?

8. Delete all the data in your database but keep the database itself.

9. Using Windows File Explorer, locate your database files and delete them.  Then do whatever is necessary to start over and develop your database as you did initially to first include three columns, and then all five columns.
