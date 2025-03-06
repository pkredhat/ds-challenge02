## Challenge 02 Introduction to Dev Spaces

### Scenario
You are working on your first dotnet application in Dev Spaces! 
* Your first challenge will be to build a new service that will print out the current Date and Time.
* You will need to expose your new service as an API END Point and verify it works with a unit test (examples all provided in code)

### Set Up + verification
* Open a terminal. Run the below command to clean the solution so you're running a fresh compile
    ```bash
    dotnet clean ./src
    ```

* Building your Dotnet Application
    ```bash
    dotnet build ./src
    ```

* Running your Dotnet Application
    ```bash
    dotnet run ./src
    ```

* Testing your Dotnet Application
    ```bash
    dotnet test ./test
    ```

* You will receive two prompts to enable Port Redirection, click 'yes' to both
* Open the "/Controllers/DsChallenge02Controller.cs" file. You will observe the method "GetCurrentDate" needs to be fixed
* All your tests can be written in "/test/Challenge02_Tests.cs"
* Use CalculateAndPrintStatisticsController as an example of how to structure your code/tests

### Success Criteria
* Write a service that will print out the Current Date (as of local machine time), you can format the date any way you like (UTC is fine as a default)
* Write a test-case in /tests/Challenge02_Tests.cs to verify your changes work, run 'dotnet test' and it should indicate "All 1 test is passing"
* Restart your workspace (if required) for setting to be reflected

* The live coding mode should show no errors 

### Resources
* Look for hidden clue(s) in source files that can help finish the task sooner!
* Dotnet Time Reference: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-9.0

### What did we learn?
* Quick introduction to Dev Spaces, using the IDE and building and compiling code
* Unless there is a documentation and or guidance (like this scenario sections), it will be trial-and-error
* No guidance also results in lost time, productivity and delays the joy of coding