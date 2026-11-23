# HelloWorld – Azure DevOps CI/CD Project

## Overview

This project shows the implementation of an automated CI/CD pipeline for a .NET application.

The source code is hosted on GitHub, while Azure DevOps is used to automate the build, testing, code analysis, and package publishing processes.

The pipeline is triggered automatically when changes are pushed to the `main` or `develop` branches.

## Pipeline Workflow

### Main Branch – Application Publishing

When code is pushed to `main`, the pipeline:

- Restores dependencies and builds the application.
- Publishes the application in Release configuration.
- Generates an automatic version based on the Azure DevOps Build ID.
- Publishes the application as a Universal Package to Azure Artifacts.

### Develop Branch – Testing and Code Quality

When code is pushed to `develop`, the pipeline:

- Builds the application.
- Performs static code analysis using SonarCloud.
- Executes unit tests using xUnit.
- Generates code coverage reports using Coverlet.
- Imports coverage results into SonarCloud.
- Publishes the SonarCloud Quality Gate result.
- Generates and publishes a NuGet package to Azure Artifacts.

## Testing and Code Quality

The project includes a separate xUnit test project to verify application functionality.

Coverlet collects code coverage data during test execution, and SonarCloud uses the generated OpenCover report to display coverage metrics and analyze code quality.

## Technologies Used

- **.NET 10 / C#** – Application development.
- **GitHub** – Source code management.
- **Azure DevOps** – CI/CD pipeline automation.
- **Azure Artifacts** – Application and NuGet package storage.
- **SonarCloud** – Static code analysis and quality gates.
- **xUnit** – Automated unit testing.
- **Coverlet** – Code coverage collection.
- **Ubuntu** – Pipeline build agent.

## Running Locally

Build the application:

```bash
dotnet build HelloWorld/HelloWorld.csproj
```

Run the application:

```bash
dotnet run --project HelloWorld/HelloWorld.csproj
```

Run unit tests:

```bash
dotnet test HelloWorld.Tests/HelloWorld.Tests.csproj
```