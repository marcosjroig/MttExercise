# MTT Exercise
This code is a web API made with .NET Core and access a SQL Server database.

## Requirements for Installation
- Visual Studio 2019 or VS Code
- .NET Core 3.1framework
- SQL Server 2019

## Installation
This repo has 2 folders:
- __Database__: execute all the scripts in order to create the DB and populate the tales.
- __MTT__: is the Web API. So, you can open with Visual Studio and run it, or deploy in a server of your preference.

## Endpoints 

The endpoints in my local environments are these, you will probably have different ports depending of how you run or deploy the solution:
https://localhost:44332/api/categories
https://localhost:44332/api/products/1

## Considerations about the code
- I didn't create a client application to consume the API, but it can be easly tested in the browser by doing copy past of the URL or using tools like postman.
- There are Stored procedures to provide the data from the Database, but I didn't use then in my code as I used datasets and EF Core. This was just for lack of time, I considered a bit less important this part of the code as there are many ORM available in the market and also lot of example code about how the create the DAL (data access layer).
- I used the Repository pattern to create an intermidiate layer between the Controllers and the DataContext.
- For the error handling I implemented Try-catch in the services, I did used the "using" to automatically dispose the DbContext in case of error because the lifecycle of the object is handle by the IoC. I will use "using" to dispose the object when I create the object manually.
- I used async programming for handling data object as those could have some delay in the response.
- The code is short and clear separation of concerns.
- For testing I used XUnit framework and I tested the services and controllers.
- Regarding the DB: I created two tables: Category and Product related between them with a forign key, and both tables have a Primary Key and are indexed.
