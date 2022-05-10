# OC Questions

## What is SOA? and the principles

- SOA stands for Service Oriented Architecture
- Which is an Architecture for developing distributed and interoperable appliations
  - This means that you structure your application by decomposing it into multipe services that can be classifed as diffrent types like subsystems or tiers.
  
### SoA Priciple

- [Contract] - Services adhere to a service description. A service must have some sort of description which describes what the service is about. This makes it easier for client applications to understand what the service does.

- [LooseCoupling] - Less dependency on each other. This is one of the main characteristics of web services which just states that there should be as less dependency as possible between the web services and the client invoking the web service. So if the service functionality changes at any point in time, it should not break the client application or stop it from working

- [Abstraction] - Services hide the logic they encapsulate from the outside world. The service should not expose how it executes its functionality; it should just tell the client application on what it does and not on how it does it.

- [Composability] - Services break big problems into little problems. One should never embed all functionality of an application into one single service but instead, break the service down into modules each with a separate business functionality.

## What are the Rest Principles?

[Representational-State-Transfer](REST) - is an architectural aproach to designing web services

- Primary advantage of REST is that it uses open standards, and does not bind the implementation of the API or the client applications to any speccific implementation.

- Sometimes a [POST], [PUT], [PATCH], or [DELETE] operation might require processing that takes a while to complete
- You should expose an endpoint that returns the status of an asynchronous request, so the client can monitor the status by polling the status endpoint

- [Uniform-Interface] - By applying the principle of generality to the components interface, we can simplify the overall system architecture and improve the visibility of interactions
  - *Identification of resources* - The interface must uniquely identify each resource involved in the interaction between the client and the server.
  - *Manipulation of resources through representations* – The resources should have uniform representations in the server response. API consumers should use these representations to modify the resources state in the server.
  - *Self-descriptive messages* – Each resource representation should carry enough information to describe how to process the message. It should also provide information of the additional actions that the client can perform on the resource.
- *Hypermedia as the engine of application state* – The client should have only the initial URI of the application. The client application should dynamically drive all other resources and interactions with the use of hyperlinks.
- [Client-Server] - The client-server design pattern enforces the separation of concerns, which helps the client and the server components evolve independently.
  
- [Stateless] - mandates that each request from the client to the server must contain all of the information necessary to understand and complete the request.

- [Cacheable] - The cacheable constraint requires that a response should implicitly or explicitly label itself as cacheable or non-cacheable.

- [Layered-System] - The layered system style allows an architecture to be composed of hierarchical layers by constraining component behavior.

## Diffrences between Soap and Restful

- [Soap] - is compatible with diffrent protocols, like http, TCP..
- Messaging Structure is only XML which is why they were heavy and slow in performance
- SOAP used more bandwidth as the messages were in xml

- [Restful] - Compatible with only http(s) protocol
- Its uses REST Architecture
- Can use any messaging format like json, xml, custom
- Has more reachabilty to the clients

## Describe the HTTP LifeScycle.

Hyper Text Transfer Protocol (Secured)
The protocol that both computers have to follow in order to understand/communicate with each other and work together to display a nice looking website in your browser, register an account, login, etc.

1. Client (your browser) will send a request (the url you sent)
2. The server will receive that request and will do some processes
3. The server will send an appropriate response (html, css, js, json, etc.)
4. The client will receive the response and the browser will process that response

## What is Asynchronous Programming?

They are supported by the async and await keywords.
The async keyword turns a method into an async method, which allows you to use the await keyword in its body.
the await  yields control to the caller of the method that performed await, and it ultimately allows a UI to be responsive or a service to be elastic.

## What are the different HTTP Verbs/Methods?

[GET] - The GET method is used to retrieve information from the given server using a given URI. Requests using GET should only retrieve data and should have no other effect on the data
[HEAD] - Same as GET, but transfers the status line and header section only.
[POST] - A POST request is used to send data to the server, for example, customer information, file upload, etc. using HTML forms.
[PUT] - Replaces all current representations of the target resource with the uploaded content.
[DELETE] - Removes all current representations of the target resource given by a URI.
[CONNECT] - Establishes a tunnel to the server identified by a given URI.
[OPTIONS] - Describes the communication options for the target resource.
[TRACE] - Performs a message loop-back test along the path to the target resource.

## What are the types of HTTP status codes?

Http handles exception through status codes.
By default, most exceptions are translated into an HTTP response with status code 500
 -Gives the result of the HTTP request
 Exception filters are the easiest solution for processing the subset unhandled exceptions related to a specific action or controller.
1XX - informational
100 - continue - continue the request or ignore the response if the request is already finished.
2XX - Success
200 - Ok- The request succeeded
201-Created -The request succeeded, and a new resource was created as a result.
3XX - Redirection
303 - Found - This response code means that the URI of requested resource has been changed temporarily.
4XX - Client error
400 - Bad Request - The server cannot or will not process the request
401 - Unauthorized - client must authenticate itself to get the requested response.
5XX - Server error
500 - Internal Server Error - The server has encountered a situation it does not know how to handle.

## What is ASP.NEt?

ASP.NET eb framework for building web apps on the .NET framework
ASP.NET works on top of the HTTP protocol, and uses the HTTP commands to communicate
We can use Controllers which handle the HTTP Requests and formulate an appropraite http response 

## Types of Filters

Action - Will perform your custom code after or before a controller action
Authorization - Used to determine whether the user is authorized for the request
Resource - Used for logging, caching, and other resource related operations
Exception - Will perform your custom code after or before an exception
Result - Will perform some code after or before the execution of giving a view or IActionResult

## What are the different HTTP Headers

Request Headers is an HTTP header that can be used in an HTTP request to provide information about the request context, so that the server can tailor the response.
A response header is an HTTP header that can be used in an HTTP response and that doesn't relate to the content of the message.

## What is content negotiation in Rest

- the process of selecting the best representation for a given response when there are multiple representations available. The primary mechanism for content negotiation in HTTP are these request header
- We have Accept, Accept-Charset, Acceppt-Encoding, Accept-Language.

## Server-side vs Agent-Side

Server-side is when the response is located at the server

Agent-driven - when selection is made on the client-side
most REST API implementations rely on agent-driven content negotiations. Agent-driven content negotiation depends on the usage of HTTP request headers or resource URI patterns.