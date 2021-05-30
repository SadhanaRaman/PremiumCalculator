



# Premium Calculator Solution

This is a readme file for the solution design for the TAL tech challenge.
The solution is build with HTML with Angular front end and .Net core Web API for the backend and with SQL as the database.

The solution takes in the following parameters to display a calculated premium on screen.

* Name
* Date of Birth
* Sum Insured - This is a number field where user can enter any positive integer.
* Occupation

Based on the above fields, the system calculates the Age and then the premium according to the below formula.

*Death Premium = (Death Cover amount * Occupation Rating Factor * Age) / (1000 * 12)*

The premium is not stored anywhere currently, hence the Name of the customer is not being recorded.

There are two parts to the solution, namely:

* **The UI** - A simple angular form that accepts the User parameters and issues a post request to the API back end, and displays the calculated premium returned back.

* **.Net Core API Backend** - It exposes a single endPoint: 
    * FetchPremium() - It takes in the following parameters - Date of Birth, Occupation, Suminsured and returns back the calculated Premium.
    * It issues a call to the PremiumService, which abstracts the calculation logic

After the end point is called the controller calls the Premium Service. The below lists the other components of the back end design, from the controller :

### Services
The application makes use of a single service.
* *PremiumService* - Responsible for calculating the premium according to the parameters supplied in the PremiumController. 
* The service uses a repository to get the Rating Factor associated with the occupations.
### Repository
The application makes use of a repository to abstract the DB calls.
The Repository is responsible for issuing the DB calls and returning them back to the PremiumService.

### Database - EF Code First

There are two tables currently in the solution. Both created in SQL through EF Code first.

* The tables are tblOccupations and tblRatings, with RatingID as the foreign key.
* The models used to create the tables are mapped to the DTOs using Automapper

### Logging 

Logging happens globally using a custom exception handler and nLog to write to a file. 

###  Comments
I have mentioned implementation details through the code as comments.  As it stands I was only able to get started on the design, however given more time the solution could be expanded onto be able to:

* Record each customer request on the DB (which could be potential leads).
* Store and retrive the connection string and the premium calculation formula securly (Azure Key Valult).
* Seperate the API and the front end into different projects, making the API reusable, Add Swagger to the API etc.
