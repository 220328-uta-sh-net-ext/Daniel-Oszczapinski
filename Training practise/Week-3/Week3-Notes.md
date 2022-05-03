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

- The core of async programming is the Task and Task<T> objects, which model asynchronous operations. They are supported by the [async] and [await] keywords.
- The [await] keyword is where the magic happens. It yields control to the caller of the method that performed [await], and it ultimately allows a UI to be responsive or a service to be elastic
- The [async] keyword turns a method into an async method, which allows you to use the [await] keyword in its body.

## C# - Reflection

- Reflection provides objects (of type Type) that describe assemblies, modules, and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties.

## Rest Definition

- [Representational-State-Transfer](REST) - is an architectural aproach to designing web services

- Primary advantage of REST is that it uses open standards, and does not bind the implementation of the API or the client applications to any speccific implementation.

- Sometimes a [POST], [PUT], [PATCH], or [DELETE] operation might require processing that takes a while to complete
- You should expose an endpoint that returns the status of an asynchronous request, so the client can monitor the status by polling the status endpoint

## Rest - Principles(Stateless, Cacheable, Uniform Interface, Client-Server, Layered System)

- [Uniform-Interface] - By applying the principle of generality to the components interface, we can simplify the overall system architecture and improve the visibility of interactions
  - Identification of resources - The interface must uniquely identify each resource involved in the interaction between the client and the server.
  - Manipulation of resources through representations – The resources should have uniform representations in the server response. API consumers should use these representations to modify the resources state in the server.
  - Self-descriptive messages – Each resource representation should carry enough information to describe how to process the message. It should also provide information of the additional actions that the client can perform on the resource.
  - Hypermedia as the engine of application state – The client should have only the initial URI of the application. The client application should dynamically drive all other resources and interactions with the use of hyperlinks.

- [Client-Server] - The client-server design pattern enforces the separation of concerns, which helps the client and the server components evolve independently.
  
- [Stateless] - mandates that each request from the client to the server must contain all of the information necessary to understand and complete the request.

- [Cacheable] - The cacheable constraint requires that a response should implicitly or explicitly label itself as cacheable or non-cacheable.

- [Layered-System] - The layered system style allows an architecture to be composed of hierarchical layers by constraining component behavior.

## Design Pattern - Factory Method