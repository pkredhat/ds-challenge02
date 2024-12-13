## Challenge-01

### Scenario
* This simulates the scenario of a developer who is given a task of enhancing an existing service that was created by another developer
* The challenge (pain) of understanding required extensions is borne by the developer that is assigned this enhancement task

### Set Up + verification
* Open a terminal. Run the below command to clean the solution so you're running a fresh compile
    ```bash
    dotnet clean ./src
    ```
* Run the below command to check for compilation errors. You will see the code compiles fine
    ```bash
    dotnet build ./src
    ```
* Run the dotnet application 
    ```bash
    dotnet run ./src
    ```

* You will receive two prompts to enable Port Redirection, click 'yes' to both
* Open the "/Controllers/DsChallenge01Controller.cs" file. You will observe the method "getcurrentcate" needs to be fixed.
* When you select all the code, right click and choose "Refactor"", the code does not format

### Success Criteria
* Fix the formatting by Installing Required extensions. Code is formatted with the extensions
* Restart your workspace (if required) for setting to be reflected
* Method getCurrentDate code is completed. The code should show dotnet intellisense in action
* Write a test-case in /tests/Challenge01_Tests.cs to verify your changes work, run 'dotnet test' and it should indicate "All 1 test is passing"
* The live coding mode should show no errors 

### Resources
* Look for hidden clue(s) in source files that can help finishing the task sooner!

### What did we learn?
* Developer have challenging tasks : Example -- finding out which extensions are needed
* Unless there is a documentation and or guidance (like this scenario sections), it will be trial-and-error
* No guidance also results in lost time, productivity and delays the joy of coding
