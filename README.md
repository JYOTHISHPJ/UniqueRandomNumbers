# Random Number Generator

This C# program generates a list of 10,000 unique random numbers between 1 and 10,000 (inclusive) each time it is executed. It implements the Fisher-Yates shuffle algorithm to ensure randomness and uniqueness of the generated numbers.

# usage

This C# program can be executed manually by following these steps:

1. Clone or download the repository to your local machine.
2. Open the solution in your preferred C# IDE (e.g. VS Code).
3. Run the program.
4. The program will output the list of generated random numbers, along with their indices.

Alternatively, the program's functionality can also be accessed through the CI/CD pipeline. The pipeline is configured to trigger on every push to the `main` branch. It builds and runs the .NET project, displaying the output in the pipeline logs.

### Rerun

If you need to view the output again, you can do so by following these steps:

1. Navigate to the "Actions" tab of your repository.
2. Click on the three-dot menu (...) next to the workflow run.
3. Select "Re-run jobs" from the dropdown menu.
4. Confirm the rerun action.

The pipeline will then start running again, and you can observe the output of the generated random numbers directly from the pipeline execution logs.

Please note that output may be truncated in pipeline logs due to length limitations.

## Implementation

The program consists of a single C# file, `Program.cs`, containing the main entry point and the logic for generating random numbers. 

The `GenerateUniqueRandomNumbers` method populates a list with numbers from 1 to 10,000 and then shuffles them using the Fisher-Yates algorithm, ensuring that each number is unique and in random order.

## Dependencies

This program does not have any external dependencies. It uses only standard libraries provided by the .NET framework.

