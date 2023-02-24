# Ecommerce App using ASP.NET Core and Angular

## Introduction
Here I am trying to show project architecture for backend and clent with projcet architecture. And then show to Clent view that's it.
 
Here, you will learn variety of technologies like

-	Angular Lazy loading
-	Angular Routing
-	Angular Reactive Forms
-	Angular Creating a MultiStep form wizard
-	Angular Re-usable Reactive form components
-	Angular validation 
-	Async Validation
-	.Net Core
-	Angular
-	C# Generics
-	Repository Pattern

I have shipped master branches in Github. Here, I was used
 
-	Multiple DbContext to separate business logic with Identities
-	JWTs token using ASP.NET Identity
-	Load lazy loaded routes.
-	Automapper
-	Cool theme from bootstrap 
-	Reactive Forms
-	interceptors
-	Paging, Sorting, Searching and Filtering
-	Reusable reactive forms
-	Input and Output Binding
-	Various observables
-	Generics
-	API error handling more consistent and generic
-	Seprate multi layer .net project with its responsibility 
-	Angular material component with bootstrap

## How Project is structured 

Below, I have Pasted the high level glimpse project structure.

![14th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/API-archicture-1.png)

APIs Structure goes like

![16th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/API-archicture-2.png)

Here, you will get Custom middleware implementation, extension methods, DTOs, Custom Error Handling and few Helper methods as well.
 
Angular Project looks like 

![17th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/Clien_archicture_1.png)


# Client

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 15.1.6.

## Development server

This project is built using dotnet 7. you can cd into API directory and say dotnet restore and  then dotnet watch run.

dotnet ef migrations add InitialCreate -p DAL -s API -o Data/Migrations
cd API
dotnet ef database update
dotnet ef database drop -p DAL -s API

Identity 
dotnet ef migrations add IdentityInitial -p DAL -s API -c AppIdentityDbContext -o Identity/Migrations
cd API
dotnet ef database update --context AppIdentityDbContext

## Server Side Technologies

- .Net 7
- N-tier architecture.
- Entity Framework (Code First)
- Generic Repository Patterns
- Specification Pattern
- Seed data
- MSSQL in Production
- Swagger


## Client Side Technologies

- Angular 15
- Bootstrap 5
- ngx-bootstrap
- Font Awesome
- Lazy Loading
- Caching
- RXJS
- Design Components

## Database Location

- https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/Database/supermarket_db.bak
- https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/Database/identity_db.bak


## About the project

Here is showing all products brandwise and typewise product also shwoing. Click any product then going to product details page. BreadCrumbs, lagylaoding, spinner, pagination, searching, shorting are also avilable here.


## Working solution

![1st](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/home.png)

![2nd](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/shop.png)

![3rd](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/shop_1.png)

![4th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/login_page.png)

![5th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/register_page.png)



