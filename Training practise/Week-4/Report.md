# DevOps, Continuous Integration, Continuous Delivery, and Continuous Deployment

# DevOps - - Jamaal Fisher

### DevOp-LifeCycle:

<img src="https://pimages.toolbox.com/wp-content/uploads/2021/08/26123909/DevOps-Lifecycle.png" width="600">

## Definition of DevOps

DevOps is a collaborative culture with a set of practices, ideas, tools, technologies, and processes that streamline the product development process.
This huge cultural shift lays emphasis on effective communication, integration, and better collaboration among teams for delivering quality products.
Basically, DevOps is a methodology that helps organizations build software - and their production teams - in a way that enables continuous rapid deployment.
In the words of Patrick Debois, the Godfather of DevOps, “it is a movement of people who think it’s time for a change in the IT Industry - time to stop wasting money, time to start delivering great software, and building systems that scale and last”.

## Key Disadvantages of DevOps

- Organizational: Focusing more on delivering working software than on documentation is preferred by both DevOps and its foundational Agile roots, but it may become more difficult for developers and operators to keep track of their advances as well.
- Processes: It will take time for users to adjust to a change in velocity.  Procedurally, the organization will need to be more fault-tolerant at least in the early going. Mistakes must be made and observed to stimulate rapid learning and resolution. This will be uncomfortable to some.
- Technology: While automation can be a good thing to ensure that the pace of operations can keep up with the DevOps continuous feedback cycle, it can have unintended consequences if the automation is not set up properly and monitored.
- Speed and Security: Speed and security don’t necessarily get along with each other very well. Rapid development can lead to severe security shortfalls if there is not a separate plan of action to ensure that speed is not outpacing the security systems designed to protect the products.

### Key Groups:

<img src="https://cdn.mos.cms.futurecdn.net/8jcis7FAV29qaanUV7E7Wj-970-80.jpg.webp" width="600">

## Key Groups of DevOps Culture:

- Development
  - Development gives Operations continuous feedback, while Operations gives Development automated provisioning.

- Operations
  - Operations gives QA continuous feedback, while QA gives Operations automated testing.

- Quality Assurance (QA)
  - QA gives Development continuous feedback, while Development gives QA automated build and deploy.

### Key Phases

<img src="https://i.imgur.com/u6RqFJp.png" width="600">

## Key Phases of DevOps Culture:

- Planning phase: development decides on plans, keeping in mind the application objectives to deliver to the customer
- Coding phase: teams works on the same code, then stores the original code and different versions of the code in a repository, and merge when required in a process called version control.
- Build phase: the code is made executable.
- Test phase: the code is tested for any bugs or errors through automation.
- Deploy phase: ready for deployment, sent to operations.
- Operate phase: deploys for the working environment.
- Monitor phase: the product is continuously monitored.  the feedback received is sent back to the planning phase.
- Integration phase: the core of the DevOps life cycle.  if the code adjustments pass the test, it is sent back through the phases in a process called continuous integration (CI).

# Continuous Integration - Blake Anderson
### CI Flow Chart:

<img src="CI_Flow_Chart.png" width="500">

## Continuous Integration


Highly misunderstood. People often think they are doing it when they are not.
Essentially it is the process of continuously merging and testing small, incremental changes to the code base that all developers on a team are working on. 

## Before Continuous Integration

 People worked individually for extended periods of time until a whole feature was done and their code diverged and caused merge conflicts.
 This was problematic
 Some call it “merge hell”

## How to Fix Merge Hell?

In short, continuous integration.
 As soon as some small aspect of the code works, it is merged.
 Everyone is working on the same code base in principle.
 Everyone is merging so often that the code doesn’t diverge.

## Testing

Continuous integration can lead to things being continuously broken
 That’s where testing comes in.
Testing is the safety net.
 Code only merges if tests pass, so you always have a testable build.

## In Summary

 CI is the process of automating the building and testing of an application after each incremental and functional change to the code base.
 These changes only impact the code base if they are functional (meaning they pass the automated tests set in place).
# Continuous Delivery-  Daniel Oszczapinski
### CD - Lifecycle:

<img src="https://content.altexsoft.com/media/2017/08/CD-1024x699.png" width="600">

## What is Continuous Delivery?


- Continuous Delivery occurs and the end of the Continuous Integration cycle.
- Continuous Delivery takes Continuous Integration one step further, After a build and automated unit tests are successful, then it can be depolyed in an enviorment where there is more in-depth testing and move to any other additional stages/environments.
- This also includes continous feedback from users to implement necessary fixes to ensure the code is alwaya in a deployable state.

## Why use Continuous Delivery

- Time-to-Value Proportion - which means the team spends less time on debugging and more time on valuable funcinality. This means shorter times between user interaction and updates.

- Maximum automation - this means that testing and depoloyment stages are automated.

- High quality and low risk - The number of bugs or mistakes are reduced significantly because there is every stage goes through Continuous automated verification of deployment.

- Reduced cost - Reduce the cost by revealing bugs as early as possible.

## Pros and Cons of Ci/CD

Pros:
- Speed of deployment
- Faster testing and analysis
- Smaller code changes
- Better and faster fault isolation
- Increased code coverage
- Automatic deploy to production
- Never ship broken code
- Process is repeatable
- Faster mean time to resolution
- Smaller backlog
- Improved customer satisfaction

Cons:
- New skill sets must be learned
- Steep learning curve to implement automation
- Big upfront investment
- Legacy systems rarely support CI/CD
- High degree of discipline and dedication to quality

### References:

[Microsoft-CI/CD](https://docs.microsoft.com/en-us/aspnet/aspnet/overview/developing-apps-with-windows-azure/building-real-world-cloud-apps-with-windows-azure/continuous-integration-and-continuous-delivery)

[Youtube-Devop](https://www.youtube.com/watch?v=Xrgk023l4lI)

[Youtube-CI](https://www.youtube.com/watch?v=_zCyLT33moA)

[Youtube-Ci-Second](https://www.youtube.com/watch?v=1er2cjUq1UI&t=73s)

[Youtube-CD](https://www.youtube.com/watch?v=2TTU5BB-k9U)

[IBM-CompleteGuideDevops](https://www.ibm.com/cloud/learn/devops-a-complete-guide)

[Agile-Devops](https://theagileadmin.com/what-is-devops/)

[RedHat-CI/CD](https://www.redhat.com/en/topics/devops/what-is-ci-cd)

[Itporportal-DevopsvsCI/CD](https://www.itproportal.com/features/stop-messing-up-with-cicd-vs-devops-and-learn-the-difference-finally/)

[Altexsoft-CI/CD](https://www.altexsoft.com/blog/business/continuous-delivery-and-integration-rapid-updates-by-automating-quality-assurance/)

[PillarGlobal-AdvantagesofDevOps](https://www.3pillarglobal.com/insights/disadvantages-of-using-devops/)