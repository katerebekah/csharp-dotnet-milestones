# Bangazon, the Command Line Ordering System

In this exercise, you will be allowing a user to interact with a basic product ordering database.

## Setup

1. Create a new Visual Studio console solution named *Bangazon*.

## Instructions

You will create a series of prompts that will allow the user to create various types of data in your Invoices database.

### Main Menu

```bash
********************************************************
**  Welcome to Bangazon Command Line Ordering System  **
********************************************************
1. Create an account
2. Create a payment option
3. Order a product
4. Complete an order
> 
```

### Create Customer

```bash
Enter customer name
>

Enter street address
>

Enter city
>

Enter state
>

Enter postal code
>

Enter phone number
>
```

### Create Payment Option

```bash
Which customer?
1. John Q. Public
2. Svetlana Z. Herevazena
> 

Enter payment type (e.g. AmEx, Visa, Checking)
>

Enter account number
>
```

### Order a Product

> **Note:** These are examples. Add your own products to the *Product* table.

To make it easier to add multiple products, when the user selects a product to order, display the menu of products again. Make sure the last option of *Back to main menu* so the user can specify that no more products are needed.

```bash
1. Diapers
2. Case of Cracking Cola
3. Bicycle
4. AA Batteries
...
9. Back to main menu
```

### Complete an Order

##### If no products have been selected yet
```bash
Please add some products to your order first. Press any key to return to main menu.
```

##### If there are current products in an order
```bash
Your order total is $149.54. Ready to purchase
(Y/N) >

# If user entered Y
Which customer is placing the order?
1. John Q. Public
2. Svetlana Z. Herevazena
> 

Choose a payment option
1. Amex
2. Visa
>

Your order is complete! Press any key to return to main menu.

# If user entered N, display the main menu again
```

Once the order is complete, show the main menu again, where the user can start creating another order.






