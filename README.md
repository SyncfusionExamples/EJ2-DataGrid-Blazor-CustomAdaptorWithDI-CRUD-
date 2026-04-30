# Blazor DataGrid - CustomAdaptorWithDI with CRUD

This sample explains about how to bind Blazor DataGrid data using CustomAdaptor Dependency Injection with CRUD operations, sorting and filtering.

## Features

* Fast rendering with virtualization and row/column virtualization
* Sorting, filtering, grouping, and searching capabilities
* Inline, batch, and dialog editing modes
* Template columns, column resizing, reordering, and freezing
* Excel and PDF export (requires additional Syncfusion export packages)

## Prerequisites

* Visual Studio 2022 or later
* Visual Studio Code

## How to run the project

1. Clone or download this repository to a location in your system.
2. Open the solution file using the Visual Studio or Visual Studio code.
3. Restore the NuGet packages by rebuilding the solution or run `dotnet restore`.
4. Build the project to ensure there are no compilation errors.
5. Run the project.

Optional CLI Commands:

```powershell
dotnet restore
dotnet build
```

## References

**Documentation**: https://blazor.syncfusion.com/documentation/datagrid/connecting-to-adaptors/custom-adaptor

**NOTE**: Ensure to modify the path of NORTHWIND.MDF in OrderContext.cs based on your local path, before running the sample.