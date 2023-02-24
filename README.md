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

![14th](https://user-images.githubusercontent.com/3886381/80864879-4f869780-8ca3-11ea-80b1-01481a1c895e.png)

APIs Structure goes like

![16th](https://user-images.githubusercontent.com/3886381/80864882-51505b00-8ca3-11ea-81aa-260347d156ed.png)

Here, you will get Custom middleware implementation, extension methods, DTOs, Custom Error Handling and few Helper methods as well.
 
Angular Project looks like 

![17th](https://user-images.githubusercontent.com/3886381/80864883-51e8f180-8ca3-11ea-988a-b83f2ecfbeb6.png)

Here is the detailed feature-wise detailing of angular project.

![18th](https://user-images.githubusercontent.com/3886381/80864885-52818800-8ca3-11ea-9cf9-5ff65da70210.png)

Then, we have Core implementation of project. This holds design pattern implementation like show below.

![19th](https://user-images.githubusercontent.com/3886381/80864886-52818800-8ca3-11ea-8e1c-b1da3a1b15f5.png)

Similarly, I have Infrastructure project which holds all repository, interface implementation. This also holds the seed project and data context as well.

![20th](https://user-images.githubusercontent.com/3886381/80864887-531a1e80-8ca3-11ea-9fb2-651e4494a185.png)

## Warning and Disclaimer

Every effort applied to make this project complete and accurate to the topic, but no warranty is implied. Any implementation in this project are MY OWN and also borrowed from best practices segment. ALL content presented AS-IS, for learning purposes only. Author will not be liable for any loss or damages arising from the information presented in this project. This also involves stripe implementation. Just use test card as explained in readme not actual card. Incase, if any amount get deducted from actual card, author won't be responsible for any loss or damage. 

## Client

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 9.0.1. You can cd into client folder and do npm i to install the packages then ng serve.

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

This project is divided into branches. Master branch is development cut and production branch is production cut. In order to understand best practices and differences between them try comparing both.


## Glimpse of the working solution

![1st](https://user-images.githubusercontent.com/3886381/80680036-b35e6400-8adb-11ea-8dc4-94ca34a1c222.png)

![2nd](https://user-images.githubusercontent.com/3886381/80680044-b5c0be00-8adb-11ea-8ea7-9d0e4318bbf6.png)

![3rd](https://user-images.githubusercontent.com/3886381/80680050-b6f1eb00-8adb-11ea-8d47-a5d4f09fa7d2.png)

![4th](https://user-images.githubusercontent.com/3886381/80680053-b8231800-8adb-11ea-8be7-e0e3dba71dca.png)

![5th](https://user-images.githubusercontent.com/3886381/80680054-b8bbae80-8adb-11ea-95a2-5ec5e611691b.png)

![6th](https://user-images.githubusercontent.com/3886381/80680056-b8bbae80-8adb-11ea-83e8-52e552842f97.png)

![7th](https://user-images.githubusercontent.com/3886381/80680058-b9544500-8adb-11ea-8b6c-e4b274e65a9d.png)

![8th](https://user-images.githubusercontent.com/3886381/80680060-b9ecdb80-8adb-11ea-9420-336fe8f76c12.png)

![9th](https://user-images.githubusercontent.com/3886381/80680061-ba857200-8adb-11ea-9a2b-6a221e687a7d.png)

![10th](https://user-images.githubusercontent.com/3886381/80680062-bb1e0880-8adb-11ea-9592-66c677b63702.png)

![11th](https://user-images.githubusercontent.com/3886381/80680064-bb1e0880-8adb-11ea-963a-7a591aef9759.png)

![12th](https://user-images.githubusercontent.com/3886381/80680067-bbb69f00-8adb-11ea-90c3-8682349cac0e.png)

