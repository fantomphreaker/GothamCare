# Problem Statement: Gotham Cares Charitable Society


The Gotham Cares Charitable Society is planning to distribute food amongst the needy of Gotham in the coming months. The Society is planning to serve various types of ready to eat food packets through outlets across the city and are in dire need of volunteers for the distribution outlets.
They are planning to open a website solely to list the outlets and the street names. They expect interested volunteers to visit the website and then get in touch to volunteer for a suitable day at a distribution outlet of their choice.


They expect the following pages on the website and the features the page should have:
* Home Page
* An aesthetically pleasing home page with images, motto, and operating hours of the society.
* Contact information comprising of the address, email, and multiple phone numbers must be shown.
* Distribution Outlets
* A page which lists the outlets for the current and upcoming three days.
* The outlet name, street name, nearest landmark, total number of available food packets and required number of volunteers must be displayed.
* Each outlet must indicate the type of available food packets (Veg/Non-Veg/Both).
* The list must be sorted alphabetically based on the street name and ascending order of the day. //can be implemented during selecting data
* The outlets that serve both Veg & Non-Veg food must appear on top of the list. //first three rows will be for both Veg and Non-Veg and will be occupied by either of the other only if the number of packets of Veg & Non-Veg are 0 for all three outlets.
* Add an Outlet
* A page which allows adding an outlet with all the details that need to be displayed in the listing page and the date on which the outlet will be serving food. 
* The name of the outlet must be unique for the day. //functionality can be implemented in the source code. And not at the DB level. Perform check on the date if the outlet name entered is redundant and can be entered only if the date is different.
* Only a maximum of 10 outlets can be open in a day, of which only 3 can distribute both Veg & Non-Veg food packets.
* This page must only be accessible to authorised personnel of the society with their email and provided password.
* Edit or Delete an Outlet
* A page which allows editing the details of an existing outlet.
* An option must be provided to delete the outlet as well.
* This page must only be accessible to authorised personnel of the society with their email and provided password.
## Questions
Described above is a problem statement and relative use cases. If your team has been assigned the task of building a web application which can cater to the use cases, then:
1. Provided that you are going to use a relational database. 
	* List out the tables, their relationships, constraints, and indices. Create an ER diagram representing the relationships. The following videos helps you to get an understanding on how to draw ER diagrams. 
	https://www.youtube.com/watch?v=QpdhBUYk7Kk |
	https://www.youtube.com/watch?v=-CuY5ADwn24
	* Build SQL queries for creating the same.
2. With the aim of building a RESTful API service, define the possible API endpoints, their purpose and HTTP request methods. 
3. Create a .NET Core Web API project (use version .NET 5), develop the API endpoints. Write the controllers and actions and generate the Swagger API document. 
4. Develop the APIs in a three tier architecture format. 
5. Integrate Entity Framework as the ORM for data access in the project. Use the code first approach to design the entities, and create the migrations to generate the database.
6. Use dependency injection throughout the project to make the interactions between the layers loosely coupled.
7. Use proper naming conventions for variables, classes, method names across the project. Use comments to describe the intent of the code you are writing.
8. Push the source code, documents, and diagrams to a GitHub repository daily.

# Solution and Logic

## ER Diagram

ER diagram is drawn after listing out tables and their relationships.


![alt text](https://github.com/fantomphreaker/GothamCare/blob/master/ER%20and%20Queries.png?raw=true)

## API Endpoints

* List Outlets (current and upcoming three days) - GET
	- List outletname
	- Street Name
	- Nearest Landmark
	- No. of available food packets
	- Food Type
	- Required No. of volunteers.

* List a single Outlet by Id

* Add Outlet - POST
	- Outlet Name
	- Street Name
	- Nearest Landmark
	- Food Type
	- Required No. of volunteers.

* Edit Outlet - PATCH
	- Edit the details of an Outlet 

* Delete Outlet - DELETE
	- Delete the Outlet from the db


* Add Volunteer - POST

* Admin Authentication - POST
	- Verify email and password

## How to Migrate API

* Install postgreSQL and pgAdmin 4 in your system and make sure pgAdmin 4 is running.
* Create a new Login/Group Role with **superuser** privileges with the following data:

	Name: **gothamcare** |
	Password: **abcd**
 
* If you want to use another Login/Group Role, make sure it has superuser privileges, then go to the project folder and open the *appsettings.Development.json* file and make changes to the value of the key *ConnectionStrings* as per the following,

```json	
    "ConnectionStrings": {
        "GothamCareApiConnection": "User ID = <insert your group role name here>;Password=<insert your group role password here>;Server=localhost;Port=<insert port value here, default value is 5432>;Database=GothamCareApi.dev;Integrated Security=true; Pooling=true;"
    }
```
	Make sure not to include the ankle brackets as they are placeholders for the values you enter.

* Open the solution in Visual Studio 2019, go to Tools -> NuGet Package Manager -> Package Manager Console. 
* Make sure postgreSQL server is running in the background.

* After opening the Package Manager Console enter the following commands:
```console
PM>Add-Migration
```
Enter a Name(eg: InitialMigration) when it asks for it and press Enter. 

* After it is migrated successfully enter:
```console
PM>Update-Database
```
This will create the database and create tables. The connection between database and API is now established successfully. You can see the newly created database and the tables from pgAdmin 4 

