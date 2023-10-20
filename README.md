<h1 align="center">
  <br>
  
   ASP Net Core Microservice

   ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
   ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
   ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

</h1>

<p align="center">
  <a href="#%E2%84%B9%EF%B8%8F-introduction">Introduction</a> •
    <a href="#microservices-architecture">Microservices Architecture</a> •
    <a href="#monolithic-vs-microservices-architecture">Monolithic vs Microservices Architecture</a> •
    <a href="#license">License</a> •
    <a href="#contributors">Contributors</a> 
</p>

<div align="center">

![GitHub Repo stars](https://img.shields.io/github/stars/Ctere1/asp-core-microservice)
![GitHub forks](https://img.shields.io/github/forks/Ctere1/asp-core-microservice)
![GitHub watchers](https://img.shields.io/github/watchers/Ctere1/asp-core-microservice)

</div>

## ℹ️ Introduction

This is a simple microservice project using ASP.NET Core 6.0. The project is based on the following article: [Microservices Architecture](https://www.c-sharpcorner.com/article/microservice-using-asp-net-core/).

## Microservices Architecture

- A microservice is a software development technique that structures an application as a collection of small, independent services that communicate with each other through APIs. Each microservice is designed to perform a specific business function and can be deployed independently of the other services in the application.        

- The following picture from Microsoft Docs shows the microservices architecture style.     
    ![ss](images/Microservice%20Using%20ASP.NET%20Core.png)             


- There are various components in a microservices architecture apart from microservices themselves:     
    - <b>Management:</b>Maintains the configuration and operational data for the microservices.     
    - <b>API Gateway: </b>Provides a single entry point for clients to access all the microservices.     
    - <b>Service Discovery:</b> Maintains a list of all the microservices instances that are currently running.      
    - <b>Identity Provider:</b> Provides authentication and authorization for the microservices.     
    - <b>CDN:</b> Provides caching and content delivery services.        
    - <b>Static Content: </b>Provides static content to the clients.     

- Microservices are deployed independently with their own database per service so the underlying microservices look as shown in the following picture.  
    ![ss](images/Microservice%20Using%20ASP.NET%20Core02.png)

## Monolithic vs Microservices Architecture

- A monolithic application is a traditional software development approach where an application is built as a single, indivisible unit. All the components of the application are tightly coupled and run as a single process. Monolithic applications are typically large and complex, making them difficult to maintain and scale.

- Following is the diagrammatic representation of monolithic architecture being package completely or being service based.  
    ![ss](images/Microservice%20Using%20ASP.NET%20Core03.png)

- Microservice is an approach to create small services each running in their own space and can communicate via messaging. These are independent services directly calling their own database.

- Following is the diagrammatic representation of microservices architecture.   
    ![ss](images/Microservice%20Using%20ASP.NET%20Core04.png)


## ©License
![GitHub](https://img.shields.io/github/license/Ctere1/asp-core-microservice?style=flat-square)


## 📌Contributors

<a href="https://github.com/Ctere1/">
  <img src="https://contrib.rocks/image?repo=Ctere1/Ctere1" />
</a>
