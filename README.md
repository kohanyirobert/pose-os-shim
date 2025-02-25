# Pose OS Shim

This project demonstrates an error encountered when using the Pose library to shim the `OperatingSystem.IsWindows()` method.

## Project Structure

- `pose-os-shim.csproj`: The project file containing dependencies and build configurations.
- `UnitTest1.cs`: Contains a unit test that isolates the `OperatingSystem.IsWindows()` method using Pose.

## Dependencies

- .NET 8.0
- Pose 2.1.0
- xUnit 3.0.2
- Microsoft.NET.Test.Sdk 17.12.0

## Running the Tests

To run the tests, use the following command:

```sh
dotnet test
```

## Purpose

The purpose of this project is to show the maintainer of the Pose library an error that occurs when attempting to shim the `OperatingSystem.IsWindows()` method.
