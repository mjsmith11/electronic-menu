# electronic-menu
## Partial README
Electronic replacement for menus and ordering in a restaurant setting.

The system is structured as a Visual Studio Solution containing 4 projects.

### data_models
This project is responsible for the data in the system and represents the models portion of the MVC architecture.  Each class in the root of the Models directory of this project corresponds to a table in the database. 
Model classes in subdirectories do not correspond to database tables. This project contains two database context classes that aim to function the same. One is for use in projects targeting .NET Framework,
 and the other is for projects targeting .NET Core. Other items included in this project include classes to manage databse connection info, a sql script to create the necessary tables, and a class to add data to the database for testing purposes.
 
### menu_manager
This project runs is a Windows application for use by managers to maintain the menu.  It provides basic CRUD operations for the items on the menu. It uses a .NET Framework form as a view, and a C# class that acts as a controller to interact with the MenuItem data model in the data_models project.

menu_manager also has a controller for css and allows the manager to choose the css template for the site.

 
### playground
This project serves no purpose in the functionality of the electronic-menu system.  It was used as a proof of concept for sharing the same set of models between an ASP.NET web application and .NET Framework application for Windows.

### web-menu
This is an ASP.NET MVC web application.  Views and controllers are contained in this projects, and models are external in the data_models project. Features in this project include:

 - Managing the availability status of tables
 - Viewing which tables have unpaid bills
 - Marking bills as paid
 - Diners sending requests to restaurant staff
 - Viewing Menu by Category
 - Adding items to order including quantity and side dish choices
 - Removing items from an order
 - Submiting an order
 - Report on total sales for orders in the database
 - Show itemized bill.
 - Use css specified by database.
