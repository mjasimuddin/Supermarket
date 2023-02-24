![.NET Core](https://github.com/mjasimuddin/Supermarket)

# Ecommerce App using ASP.NET Core and Angular

## Introduction
In this section, you will learn how to build full fledged Ecommerce app using asp.net core and angular 9. Below are the key takeaways from this project. Anyone who wants to learn and write professional enterpise projects can refer this project. This project not only illustrates how to implement all layers to the point rather it adheres to best practices as followed by industry.
 
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


## About the project

Master branch is development cut and production branch is production cut. In order to understand best practices and differences between them try comparing both.


## Working solution

![1st](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/home.png)

![2nd](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/shop.png)

![3rd](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/shop_1.png)

![4th](https://github.com/mjasimuddin/Supermarket/blob/master/client/src/assets/images/screenshot/login_page.png)



