# VS+DB Migrations Exercise

This exercise builds upon the LINQ and EntityFramework exercise, and similarly needs a good review/editing before it is ready for the students!

1. Create a project to develop an animal database as you did for Entity Framework and LINQ.   
1. Add a column to your model for 'habitat', and add a migration for it.
1. Add another column to your model for 'diet' and add a migration for it.
1. View your database through Server Explorer and confirm that the two additional columns have been added.
1. View your migrations files and confirm that you can find the up migrations in your codebase.
1. Remove the project's Data Connections in your Server Explorer.  Try running your app and see what happens.
1. Refresh the project's Data Connections in the Server Explorer and try to run your app again.  What happens?
1. Delete all the data in your database but keep the database itself.
1. Using Windows File Explorer, locate your database files and delete them.  Then do whatever is necessary to start over and re-develop your database as you did initially to first include three columns, and then all five columns.
