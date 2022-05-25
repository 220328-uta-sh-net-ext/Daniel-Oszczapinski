# Docker, DevOp, HTML, CSS and, JavaScript Questions

## 6 Stages of SDLC

- [Planning/Requirement-Analysis] - The client defines a problem that needs to be solved, which further forms the basis for finalizing the requirements.
- [Define-the-Project-Requirement] - You define and docuement that product requirements of the project and get them approved by the customer/client
- [Design-Product-Architecture] - This phase of the software development life cycle focuses on creating software architecture, prototype, and user experience design.
- [Building/Developing-the-product] - This phase is executed by the coders who work on bringing the concept into reality. Build the application
- [Testing-the-product] - This phase of the application development life cycle focuses on testing the written code for bugs and other inconsistencies. the testing and quality assurance team works together to test and report the bugs to the development team.
- [Deployment-and-Maintenance] - This is when you finally deploy your app to the appropriate market

## What Scrum and Agile

### Agile

- Agile is a mindset that drives an approach to software development.
- Agile practices on the other hand, are techniques applied during phases of the software development lifecycle.
- It is all about creating a working software than spending your time creating extensive documentation

### Scrum

- Implementation of Agile concept
- Scrum prescribes three specific roles: the product owner, the scrum master, and the scrum team.
  - Product-Owner - Responsible for what the team is building, and why they're building it. The product owner is responsible for keeping the backlog up-to-date and in priority order.
  - Scrum-master - Responsible to ensure the scrum process is followed by the team. Scrum masters are continually on the lookout for how the team can improve, while also resolving impediments and other blocking issues that arise during the sprint. Scrum masters are part coach, part team member, and part cheerleader.
  - Scrum-Team - These are the individuals that actually build the product. The team owns the engineering of the product, and the quality that goes with it.

- [Product-Backlog] - The product backlog is a prioritized list of value the team can deliver. The product owner is responsible for the backlog and adds, changes, and reprioritizes as needed. The items at the top of the backlog should always be ready for the team to execute on.

- [Daily-Standup] -daily scrum, often called the daily standup. The daily scrum is daily meeting limited to fifteen minutes. Team members often stand during the meeting to ensure it stays brief. Each team member briefly reports their progress since yesterday, the plans for today, and anything impeding their progress.

## What is Cloud Computing?

- computing services over the internet or the cloud
  - this provides Scalability, flexibility and innovation
  - The pros are the cost, scaling and seurity.
- The types of cloud servie types are IaaS, PaaS, SaaS
  - [IaaS] - Infrastructure as a service is a type of cloud computing service that offers essential compute, storage, and networking resources on demand
  - [PaaS] - Platform as a service (PaaS) is a cloud environment in which customers can develop, manage, and deliver applications. Azure services is an example of PaaS
  - [SaaS] - Software as a service grants access to a vendor’s cloud-based software

- Access Modifiers in Cloud Computing
  - [Private] - Only accessible by a certain organization
  - [Public] - Open for use by the general public
  - [Hybrid] - Some resources are private and some resources are public
  - [Community] - Sharing resources when you are part of a community

## What is Docker? How do you use it and why do you use it?

- Docker is an open platform for developing, shipping, and running applications. Docker enables you to separate your applications from your infrastructure so you can deliver software quickly. It is a containerization ecosystem which helps to build and ship the package. Containers are lightweight and contain everything needed to run the application, so you do not need to rely on what is currently installed on the host.

## What is Containerization and Virtualization

- [Containerization] - Involved bundling an application together with all the configuration files, libraries, and dependencies required. Containers allocate resources dynamically use as much resources the container needs to run the application
- [Virtualization] - Virtual machine that simulates a real computer with an operating system. The allocated resources are static, so when you choose the amount of resources, they cannot change

## What terminolgy is used in Docker?

- [Images] - An image is a read-only template with instructions for creating a Docker container. They are immutable file and represents an application and its virtual environment at a specific point in time
- [Container] - A container is a runnable instance of an image. You can create, start, stop, move, or delete a container using the Docker API or CLI.
- [Registry] - server-side or cloud application where you can store your images and make it easy to distribute
- [ignore] - ignore files like you would for gitignore
- [Configuration] - information to tell the docker container on how to run the image
- [daemon] - listens for Docker API requests and manages Docker objects such as images, containers, networks, and volumes

## What is Devops?

### Devops

- A compound of development (Dev) and operations (Ops), DevOps is the union of people, process, and technology to continually provide value to customers.
DevOps influences the application lifecycle throughout its plan, develop deliver, and operate phases.
  - [Plan] - DevOps teams ideate, define, and describe features and capabilities of the applications and systems they are building. Manage using boards like trello.
  - [Develop] - The develop phase includes all aspects of coding—writing, testing, reviewing, and the integration of code by team members—as well as building that code into build artifacts that can be deployed into various environments. Teams use version control, usually Git, to collaborate on code and work in parallel
  - [Deliver] - Delivery is the process of deploying applications into production environments in a consistent and reliable way, ideally via continuous delivery. The deliver phase also includes deploying and configuring the fully governed foundational infrastructure that makes up those environments.
  - [Operate] - The operate phase involves maintaining, monitoring, and troubleshooting applications in production environments, usually hosted

## What is a CI/CD Pipeline(Trigger, Job, Approval, Step)

- [Continuous-Integration] - is the process of automating the building and testing of an application after each incremental and functional change to the code base.
- [Continuous-Delivery] - it is the automated process of delivering the new changes in the main branch to the people, release manager that will check on everything
- [Continuous-Deployment] - start deploying it after all the testing are done and passed, no release manager is needed.

- Keywords
  - [Trigger] - Event that happens to execute the CI/CD process
  - [Job] - The work that need to be done to start the process
  - [Steps] - operations that are required to finsih the job
  - [Approval] - checks if the process is working correctly

## What is HTML(Hypertext Markup Language) and the parts that are required?

- HTML is a language made up of elements, which can be applied to pieces of text to give them different meaning in a document
  - [Tags] - are used to format content and these tags are enclosed within angle braces. Except a few tags, most of the tags have their corresponding closing tags.
  - [Element]- may contain a data item or a chunk of text or an image, or perhaps nothing
  - [Head] - of an HTML document is the part that is not displayed in the web browser when the page is loaded.
  - [attributes] - Extra info used in tags like the src attribute.
  - four core attributes are:
    - Id - used to uniquely identify any element within an HTML page.
    - Title - gives a suggested title for the element.
    - Class - used to associate an element with a style sheet, and specifies the class of element.
    - Style - attribute allows you to specify Cascading Style Sheet (CSS) rules within the element.

## What is CSS(Cascading Style Sheets) and the parts?

- [CSS] - is used to style and lay out web pages — for example, to alter the font, color, size, and spacing of your content, split it into multiple columns, or add animations and other decorative features.
- [Selectors] - allowing for fine-grained precision when selecting elements to style.
  - three basic fundamental selectors:
    - [Element] - is sometimes referred to as a tag name selector or element selector because it selects an HTML tag/element in your document.
    - [Class] - that will target specific elements with the class applied.
    - [Id] - an ID can be used only once per page, and elements can only have a single id value applied to them. It can select an element that has the id set on it

Responsive Web Design - changes the deign based on the viewport like a phone or computer. we are using bootstrap

## What is JavaScript and the parts?

- [JavaScript] - is a programming language that allows you to implement complex things on web pages. Every time a web page does more than just sit there and display static information for you to look at—displaying timely content updates

- [Datatypes] - they are Numbers, Boolean, Strings, Objects, Null( Lack of value), Undefined(no value was set)

- [Expressions] - is any valid unit of code that resolves to a value.they can appear anywhere in a program where JavaScript expects a value such as the arguments of a function invocation. example: Arithmetic expressions evaluate to a numeric value.

- [Operators/keywords]
  - [this] keyword to refer to the current object. In general, [this] refers to the calling object in a method.
  - [Grouping] - grouping operator ( ) controls the precedence of evaluation in expressions.
  - [new] - operator to create an instance of a user-defined object type or of one of the built-in object types.
  - [super] - is used to call functions on an object's parent.

### Control flow with statements id JS

- [Statements] - are used in JavaScript to control its program flow. statements are designed to work independently of any JavaScript object. That means you can use a statement whether you're working with the object
  - [Block] - A block statement is used to group zero or more statements
  - [throw] - Throws a user-defined exception.
  - [switch] - Evaluates an expression, matching the expression's value to a case clause, and executes statements associated with that case.

- [Declarations]
  - [var] - Declares a variable
  - [let] - Declares a block scope local variable
  - [const] - Declares a read-only named constan

- [Functions]
  - [function] - Declares a function with the specified parameters
  - [async-function] - Declares an async function with the specified parameter
  - [return] - Specifies the value to be returned by a function

### DOM(Document Object Model)

- It represents the page so that programs can change the document structure, style, and content. The DOM represents the document as nodes and objects; that way, programming languages can interact with the page

### JS Classes(OOP) and Inheritance

- [Prototype] - Prototypes are the mechanism by which JavaScript objects inherit features from one another. 
- You can declare a [class] using the class keyword
- The [constructor] is defined using the constructor keyword. Just like a constructor outside a class definition
- we can and often do create objects without any separate class definition. This can make working with objects much more lightweight than it is in classical OOP.
Implements OOP  easily except abstraction

### JS Events(Types, Handlers, Propagation)

- [Events] - are fired to notify code of "interesting changes" that may affect code execution. These can arise from user interactions such as using a mouse or resizing a window
- there are many types of events like [onclick], [onsubmit], [onmouseover]

- [Handlers] - To react to an event, you attach an event handler to it. This is a block of code that runs when the event fires.

- [Propagation] - Event propagation is how events propagate or travel through the DOM. The event needs to pass through every node on the DOM until it reaches the end, or if it is forcibly stopped.

### JS Promises

- The [Promise] object represents the eventual completion (or failure) of an asynchronous operation and its resulting value. It allows you to associate handlers with an asynchronous action's eventual success value or failure reason.
Three states of promise
  - [pending] - initial state, neither fulfilled nor rejected.
  - [fulfilled] - meaning that the operation was completed successfully.
  - [rejected] - meaning that the operation failed.

### Ajax

- Asynchronous JS and XML
  - Used to grab information only with XML type backend server hence the name, it is now updated that JSON is now used.
  AJAX's most appealing characteristic is its "asynchronous" nature, which means it can communicate with the server, exchange data, and update the page without having to refresh the page.
- [Fetch] - Similar to AJAX except less syntaxes or prepping needed to call on backend and the main difference from AJAX is it uses promises to achieve asynchrnous operations

### what is JS ES6?

- known as ECMAScript 2015 or ECMAScript 6 and is the newer version of JavaScript that was introduced.ECMAScript is the standard that JavaScript programming language uses. ECMAScript provides the specification on how JavaScript programming language should work.