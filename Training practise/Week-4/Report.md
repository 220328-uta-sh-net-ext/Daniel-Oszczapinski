# DevOps, Continuous Integration, Continuous Delivery, and Continuous Deployment

DevOp-LifeCycle:

<img src="https://pimages.toolbox.com/wp-content/uploads/2021/08/26123909/DevOps-Lifecycle.png" width="600">

## Definition of DevOps - Jamaal Fisher

DevOps is a collaborative culture with a set of practices, ideas, tools, technologies, and processes that streamline the product development process.
This huge cultural shift lays emphasis on effective communication, integration, and better collaboration among teams for delivering quality products.
Basically, DevOps is a methodology that helps organizations build software - and their production teams - in a way that enables continuous rapid deployment.
In the words of Patrick Debois, the Godfather of DevOps, “it is a movement of people who think it’s time for a change in the IT Industry - time to stop wasting money, time to start delivering great software, and building systems that scale and last”.

## Key Groups of DevOps Culture:

- Development
Development gives Operations continuous feedback, while Operations gives Development automated provisioning.

- Operations
Operations gives QA continuous feedback, while QA gives Operations automated testing.

- Quality Assurance (QA)
QA gives Development continuous feedback, while Development gives QA automated build and deploy.

## Key Phases of DevOps Culture:

- Planning phase: development decides on plans, keeping in mind the application objectives to deliver to the customer
- Coding phase: teams works on the same code, then stores the original code and different versions of the code in a repository, and merge when required in a process called version control.
- Build phase: the code is made executable.
- Test phase: the code is tested for any bugs or errors through automation.
- Deploy phase: ready for deployment, sent to operations.
- Operate phase: deploys for the working environment.
- Monitor phase: the product is continuously monitored.  the feedback received is sent back to the planning phase.
- Integration phase: the core of the DevOps life cycle.  if the code adjustments pass the test, it is sent back through the phases in a process called continuous integration (CI).

CI/CD Pipeline:
<img src="https://www.redhat.com/cms/managed-files/styles/wysiwyg_full_width/s3/ci-cd-flow-desktop.png?itok=2EX0MpQZ" width="800">

## What is Continuous Delivery? - Daniel Oszczapinski

CD - Lifecycle:

<img src="https://content.altexsoft.com/media/2017/08/CD-1024x699.png" width="600">

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

[IBM](https://www.ibm.com/cloud/learn/devops-a-complete-guide)

[Agile](https://theagileadmin.com/what-is-devops/)

[RedHat](https://www.redhat.com/en/topics/devops/what-is-ci-cd)

[Itporportal](https://www.itproportal.com/features/stop-messing-up-with-cicd-vs-devops-and-learn-the-difference-finally/)

[Altexsoft](https://www.altexsoft.com/blog/business/continuous-delivery-and-integration-rapid-updates-by-automating-quality-assurance/)
