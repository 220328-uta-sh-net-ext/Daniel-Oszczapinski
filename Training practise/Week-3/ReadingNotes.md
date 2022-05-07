# [Content Negotiation](https://restfulapi.net/content-negotiation/)

- If the selection of the best representation for a response is made by an algorithm located at the server, it is called [server-driven-negotiation].
  - Server Driven not vary useful
  - More complex
- If that selection is made at the agent or client-side, it is called [agent-driven-negotiation].
  - Rest Api relies on agent-Driven
  - Depend on HTTP request headers or resource URL Patterns

## [HATEOAS](https://restfulapi.net/hateoas/)

- HATEOAS (Hypermedia as the Engine of Application State)
  - is a constraint of the REST application architecture. HATEOAS keeps the REST style architecture unique from most other network application architectures.
  - The advantage of the above approach is that hypermedia links returned from the server drive the application’s state and not the other way around.
  - HATEOAS allows the server to make URI changes as the API evolves without breaking the clients.

- RFC 5988 puts forward a framework for building links that define the relationships between resources on the web.
Properties:
  - Target URI: Each link should contain a target
  - Link relation type: The link relation type describes how the current context (source) is related to the target resource
  - Attributes for target IRI: The attributes for a link included hreflang, media, title, and type, and any extension link parameters.

- JSON HAL is a promising proposal that sets the conventions for expressing hypermedia controls, such as links, with JSON or XML. It is in the draft stage at this time.
Properties:
  -Target URI: It indicates the target resource URI. 
  -Link relation: The link relation type describes how the current context is related to the target resource
  -Type: This indicates the expected resource media type. This is represented by the type attribute.

## [Caching](https://restfulapi.net/caching/)

- When a consumer requests a resource representation, the request goes through a cache or a series of caches (local cache, proxy cache, or reverse proxy) toward the service hosting the resource.

- Being cacheable is one of the architectural constraints of REST.
  - GET requests should be cachable by default
  - POST requests are not cacheable by default but can be made cacheable if either an Expires header or a Cache-Control header with a directive,
  - Responses to PUT and DELETE requests are not cacheable at all.