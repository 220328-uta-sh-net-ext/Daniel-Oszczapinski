# Notes that inclide SOA, HTTP, REST, ASP.NET, Security

## SOA Definition

- SOA stands for Service Oriened Architecture
  - Which is an Architecture for developing distributed and interoperable appliations
  - This means that you structure your application by decomposing it into multipe services that can be classifed as diffrent types like subsystems or tiers.

## SOA Principles (Contract, Composability, Loosely Coupled, Abstraction)

- [Contract] - Services adhere to a service description. A service must have some sort of description which describes what the service is about. This makes it easier for client applications to understand what the service does.

- [LooseCoupling] - Less dependency on each other. This is one of the main characteristics of web services which just states that there should be as less dependency as possible between the web services and the client invoking the web service. So if the service functionality changes at any point in time, it should not break the client application or stop it from working

- [Abstraction] - Services hide the logic they encapsulate from the outside world. The service should not expose how it executes its functionality; it should just tell the client application on what it does and not on how it does it.

- [Composability] - Services break big problems into little problems. One should never embed all functionality of an application into one single service but instead, break the service down into modules each with a separate business functionality.

## C# - Asynchronous Programming (thread, task, async/await)

- The core of async programming is the Task, which model asynchronous operations. They are supported by the [async] and [await] keywords.
- The [await] keyword is where the magic happens. It yields control to the caller of the method that performed [await], and it ultimately allows a UI to be responsive or a service to be elastic
- The [async] keyword turns a method into an async method, which allows you to use the [await] keyword in its body.

## C# - Reflection

- Reflection provides objects (of type Type) that describe assemblies, modules, and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties.

## Rest Definition

- [Representational-State-Transfer](REST) - is an architectural aproach to designing web services

- Primary advantage of REST is that it uses open standards, and does not bind the implementation of the API or the client applications to any speccific implementation.

- Sometimes a [POST], [PUT], [PATCH], or [DELETE] operation might require processing that takes a while to complete
- You should expose an endpoint that returns the status of an asynchronous request, so the client can monitor the status by polling the status endpoint

## *Important* Rest - Principles(Stateless, Cacheable, Uniform Interface, Client-Server, Layered System)

- [Uniform-Interface] - By applying the principle of generality to the components interface, we can simplify the overall system architecture and improve the visibility of interactions
  - *Identification of resources* - The interface must uniquely identify each resource involved in the interaction between the client and the server.
  - *Manipulation of resources through representations* – The resources should have uniform representations in the server response. API consumers should use these representations to modify the resources state in the server.
  - *Self-descriptive messages* – Each resource representation should carry enough information to describe how to process the message. It should also provide information of the additional actions that the client can perform on the resource.
  - *Hypermedia as the engine of application state* – The client should have only the initial URI of the application. The client application should dynamically drive all other resources and interactions with the use of hyperlinks.

- [Client-Server] - The client-server design pattern enforces the separation of concerns, which helps the client and the server components evolve independently.
  
- [Stateless] - mandates that each request from the client to the server must contain all of the information necessary to understand and complete the request.

- [Cacheable] - The cacheable constraint requires that a response should implicitly or explicitly label itself as cacheable or non-cacheable.

- [Layered-System] - The layered system style allows an architecture to be composed of hierarchical layers by constraining component behavior.

- [Code-on-Demand] (optional)
Allows client functionality to be extended by downloading and executing code in a form of applets.

## HTTP - Overview

- Hyper Text Transfer Protocol(HTTP) - HTTPS(Secured)
- Protocol where the computer followd in order to understand and work to display on a website

## HTTP - Request LifeCycle

 1. Open a TCP connection: The TCP connection is used to send a request, or several, and receive an answer. The client may open a new connection, reuse an existing connection, or open several TCP connections to the servers.
 2. Send an HTTP message: HTTP messages (before HTTP/2) are human-readable. With HTTP/2, these simple messages are encapsulated in frames, making them impossible to read directly, but the principle remains the same.
 3. Read the response sent by the server
 4. Close or reuse the connection for further requests.

## REST - HATEOAS(Hypertext as the Engine of Application State)

- The system is effectively a finite state machine, and the response to each request contains the information necessary to move from one state to another; no other information should be necessary.

## HTTP - Verbs, Methods

- Common methods used [GET], [HEAD], [POST], [PUT],[DELETE],[CONNECT],[OPTIONS],[TRACE]
  - These methods are used in the controller class

## REST - HttpClient

- Provides a class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
- The [HttpClient] class instance acts as a session to send HTTP requests. An HttpClient instance is a collection of settings applied to all requests executed by that instance. In addition, every HttpClient instance uses its own connection pool, isolating its requests from requests executed by other HttpClient instances.
- HttpClient is intended to be instantiated once and re-used throughout the life of an application.

## HTTP - Status Codes

 -Gives the result of the HTTP request
1XX - informational
2XX - Success
3XX - Redirection
4XX - Client error
5XX - Server error

## ASP.NET - Definition

- In computer programming, an application programming interface (API) is a set of subroutine definitions, protocols, and tools for building software and applications.
- To put it in simple terms, API is some kind of interface which has a set of functions that allow programmers to access specific features or data of an application, operating system or other services.

## ASP.NET - Controllers

- It handles incoming HTTP requests and send response back to the caller.
- Web API controller is a class which can be created under the Controllers folder or any other folder under your project's root folder. The name of a controller class must end with "Controller" and it must be derived from System.Web.Http.ApiController class. All the public methods of the controller are called action methods.

## HTTP - Model Binding

- It is a way to bind data (JSON objects) coming from HTTP request to be automatically mapped into a C# model
- Whenever an Action method expects a parameter value, model binder comes into the picture
- the following steps
  1. Finds the first parameter of the method. could be an int or string
  2. looks through the available sources in the HTTP request
  3. Converts the query to correct parameter
  4. Finds the next parameter of the method
  5. Looks through the sources and finds the query string.
  6. Converts the query.

## ASP.net Routing

- Allows ASP.NET to know where to take the user's http reques
- It uses routing middleware to be able to find the appropriate controller and then the appropriate action within the controller to handle the request

## ASP.NET - Middleware

- Middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:
  - Chooses whether to pass the request to the next component in the pipeline.
  - Can perform work before and after the next component in the pipeline.
- ach middleware component in the request pipeline is responsible for invoking the next component in the pipeline or short-circuiting the pipeline

## ASP.NET - Caching

- Caching can significantly improve the performance and scalability of an app by reducing the work required to generate content. Caching works best with data that changes infrequently and is expensive to generate. Caching makes a copy of data that can be returned much faster than from the source. Apps should be written and tested to never depend on cached data.

## ASP.NET - OpenAPI

- Swagger (OpenAPI) is a language-agnostic specification for describing REST APIs. It allows both computers and humans to understand the capabilities of a REST API without direct access to the source code. Its main goals are to:
  - The two main OpenAPI implementations for .NET are Swashbuckle and NSwag

## C# - Delegates

- Notes

## C# - LINQ

- Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.
- Query expressions are written in a declarative query syntax. By using query syntax, you can perform filtering, ordering, and grouping operations on data sources with a minimum of code.
- You can write LINQ queries in C# for SQL Server databases, XML documents, ADO.NET Datasets

## ASP.NET - Filters

- They are used to create your own custom logic (your own code) if a certain event has happened
- Filters run within the ASP.NET Core action invocation pipeline, sometimes referred to as the filter pipeline.

- Authorization filters:
  - Run first.
  - Determine whether the user is authorized for the request.
  - Short-circuit the pipeline if the request is not authorized.

- Resource filters:
  - Run after authorization.
  - OnResourceExecuting runs code before the rest of the filter pipeline. For example, OnResourceExecuting runs code before model binding.
  - OnResourceExecuted runs code after the rest of the pipeline has completed.

- Action filters:
  - Run immediately before and after an action method is called.
  - Can change the arguments passed into an action.
  - Can change the result returned from the action.
  - Are not supported in Razor Pages.
  - Exception filters apply global policies to unhandled exceptions that occur before the response body has been written to.

- Result filters:
  - Run immediately before and after the execution of action results.
  - Run only when the action method executes successfully.
  - Are useful for logic that must surround view or formatter execution.
