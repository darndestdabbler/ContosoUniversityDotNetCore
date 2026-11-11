# Solution plan

## The repository as found

ContosoUniversityDotNetCore is ASP.NET Core MVC on `netcoreapp2.0`, two
SDK-style projects in ContosoUniversity.sln at the root: ContosoUniversity,
organised as feature folders under Features\ (each with its controller,
its MediatR handlers and its views, found by the existing feature view
location and reached by the default route), and
ContosoUniversity.IntegrationTests, xunit 2.3.1 tests mirroring those
folders, which run against the LocalDB database `ContosoUniversity-Test`
that the repository's RoundhousE scripts (`tools\rh.exe` in Build.ps1)
deploy. `dabbler.yaml` declares one `dotnet` suite, `dotnet test`, with
named tests selected by `--filter`. All of this is kept: the target stays
`netcoreapp2.0`, and no package or project format changes. The tests run
on a 2.x runtime; `netcoreapp2.0` rolls forward to the 2.2 installed here.

## Change 1: an online calculator page

**What changes.** A new folder Features\Calculator in ContosoUniversity:
`Calculator.cs` (a static class adding and subtracting two decimals),
`CalculatorController.cs` with a GET `Index` showing the form and a POST
`Index` showing the sum and the difference, and `Index.cshtml`. The layout's
navigation gains a Calculator link. SDK-style projects include new files
by glob, so no project file changes. The test project gains
Features\Calculator\CalculatorTests.cs, xunit facts for add and subtract.

**How it is shown to work.** `dotnet build` of the solution, and
`CalculatorTests` passing under `dotnet test`.

## Change 2: documentation comments

**What changes.** XML documentation comments on `Calculator`, its methods,
`CalculatorController` and both `Index` actions, and a Razor comment at the
top of `Index.cshtml`. No code, markup or project file changes.

**How it is shown to work.** The same build and `dotnet test`, and a diff
that contains only comment lines.

## Out of scope

Retargeting off `netcoreapp2.0`; any package or project format change; a
release.
