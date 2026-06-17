# EJ2 DataGrid Blazor — Custom Adaptor (DI) with CRUD

A compact sample showing how to wire [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) to a custom data adaptor
registered via dependency injection, with full CRUD, sorting and filtering support.

## Overview

This sample demonstrates integrating a DataGrid with a custom, server-style adaptor
implemented as a dependency-injected service. It shows how to translate UI
operations (paging, sorting, filtering, CRUD) into data-layer requests while
keeping the Blazor UI simple and testable. Useful for developers building
custom data backends or replacing the default grid adaptor.

## Key Features

- Custom data adaptor registered through DI
- Create / Read / Update / Delete (CRUD) operations
- Server-like sorting and filtering handled via the adaptor
- Minimal Blazor app that demonstrates the adaptor pattern with DataGrid

## Prerequisites

* [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/EJ2-DataGrid-Blazor-CustomAdaptorWithDI-CRUD-.git
cd EJ2-DataGrid-Blazor-CustomAdaptorWithDI-CRUD-
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

**Documentation**: https://blazor.syncfusion.com/documentation/datagrid/connecting-to-adaptors/custom-adaptor

**Online Examples**: https://blazor.syncfusion.com/demos/datagrid/overview?theme=fluent2