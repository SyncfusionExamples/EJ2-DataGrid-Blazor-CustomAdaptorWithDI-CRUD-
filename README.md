# Blazor DataGrid - CustomAdaptor with Dependency Injection CRUD Operations

## Overview

This sample demonstrates how to bind a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) using a custom adaptor registered through Dependency Injection (DI). The implementation supports Create, Read, Update, and Delete (CRUD) operations while processing grid requests through custom server-side logic instead of relying on built-in data adaptors. The sample also demonstrates integrating sorting and filtering operations into the custom adaptor workflow, providing full control over how grid data is queried, transformed, and persisted. This approach is useful when an application requires custom business logic, database access patterns, or service-based data processing that extends beyond the capabilities of the built-in adaptors.

## Key Features

- Uses a custom Syncfusion DataGrid adaptor implementation for data binding.
- Registers data services through Dependency Injection and consumes them from the custom adaptor.
- Supports Create, Read, Update, and Delete (CRUD) operations.
- Processes DataGrid requests through custom server-side logic.
- Demonstrates custom handling for sorting operations.
- Demonstrates custom handling for filtering operations.
- Integrates database-backed data access using the Northwind sample database.
- Shows how grid actions can be routed through a centralized data service layer.
- Demonstrates extending Syncfusion DataGrid data processing with application-specific logic.
- Uses a Blazor application architecture with service-based data access patterns.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- Microsoft SQL Server LocalDB or a compatible SQL Server installation hosting the Northwind database
- Update the `NORTHWIND.MDF` database path in `OrderContext.cs` before running the application

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file: `CustomAdaptorSample.sln`
3. Restore all NuGet packages.
4. Update the `NORTHWIND.MDF` database path in `OrderContext.cs`.
5. Set the startup project to:   `CustomAdaptorSample`
6. Build the solution.
7. Run the application using `Ctrl+F5`.
8. Open the local URL displayed by the application after startup.
9. Perform add, edit, delete, sorting, and filtering operations to verify the custom adaptor workflow.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
cd CustomAdaptorSample
dotnet restore
dotnet run
```

4. Ensure the `NORTHWIND.MDF` path is configured correctly in `OrderContext.cs`.
5. Open the local URL displayed in the terminal after the application starts.
6. Test CRUD, sorting, and filtering operations through the DataGrid interface.

## Project Structure

`CustomAdaptorSample/Pages/` — contains the DataGrid page that uses the custom adaptor and renders CRUD, sorting, and filtering functionality.

`CustomAdaptorSample/Data/` — contains the business models, custom adaptor implementation, database context, and supporting service logic used by the DataGrid.

`CustomAdaptorSample/Data/OrderContext.cs` — configures database access and contains the Northwind database connection configuration required by the sample.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to custom adaptor data binding, visit https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/custom-adaptor

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
