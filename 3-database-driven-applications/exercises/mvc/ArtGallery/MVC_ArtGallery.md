# Art Gallery
As owners of several art galleries, we need a web page to advertise our available art and keep them informed of upcomming events.  In addition, we need to manage our inventory, sales and profits.  Your task is to provide a solution based on the below user stories using your knowledge of databaes and ASP.NET MVC.  

User Stories:

As a customer I will:
1. be able to view all the art currently for sale (with images)
2. be able to select a piece of art and view the details (Image, price dimensions, number in inventory and location) for that piece
3. view only the art for an artist, medium or price range of my choosing

Bonus:
1. Find the details of upcomming events including gallory openings 
2. Be able to view all avaliable pieces by catagory
3. View the art I've purchased, the price I paid for each and the total I have spent.
4. Mark pieces that I would like to purchase and have them save for me to check out later (equivalent to "watch" on ebay)

As a gallery owner I will:
1. be able to view my inventory, the current asking price and the price the gallery paid for the art
2. be able to view all sold artwork, the price paid and the profit made
3. be able to view the total sales (for the week/month/year)
4. Add, Edit and Remove Art to the inventory

Bonus:
1. View the current profit (for the week/month/year) 
2. Add and Edit Art agents and customers to/in the database
3. View all the agents, their sales and their profit
4. be able to implement a sale on the artwork.  I should be able to preview the sale prices, original cost and highlight in red the pieces that will loose the gallery money if reduced to the amount of the  sale.

As product owners, we have provided:

1. A partial ERD diagram - This is to use as a reference, but you will need to make changes to complete the project.
2. Screen shots
3. Spreadsheet of the data the gallery owner currently has that needs to be included.

Notes: 
 1. Working on a team and having a local database can be challenging.  Be sure to have a stategy for this probelm early in the project.  One strategy is to script an sql file that will create the local database and add that data.  Remember to make sure that the tables are created in an order that does not add a foreign key before the table being referenced is created.  The same goes for the data.  Another method is to use code first in which everyone pulls down the Models and does migragtions to creat a local dababase with the seed data.

 2. Since each team member will have their own local database for the project, remember to either add the file where the connection string is to the git ignore or you will need to replace the connection string each time you merge and pull down.
