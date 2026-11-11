# Brief

Two changes to ContosoUniversityDotNetCore, each its own session, inside
the repository's existing shape: ASP.NET Core MVC on `netcoreapp2.0`, kept
as it is; SDK-style projects in ContosoUniversity.sln at the root; feature
folders under ContosoUniversity\Features, each holding its controller and
views; the navigation in Features\Shared\_Layout.cshtml; and xunit tests in
ContosoUniversity.IntegrationTests mirroring those folders, run with
`dotnet test` against the LocalDB test database the repository's
RoundhousE scripts deploy.

1. **An online calculator page.** A page that takes two numbers and shows
   their sum and their difference (add and subtract): a Features\Calculator
   folder with the arithmetic in its own class, a `CalculatorController`
   and its `Index` view, reached by the existing default route, and a
   navigation link. Its tests are `CalculatorTests` in the test project's
   Features\Calculator folder, plain xunit facts of the arithmetic, run by
   `dotnet test`.
2. **Documentation comments.** XML documentation comments on the types and
   public members the calculator change added, and a Razor comment at the
   top of its view. Nothing else changes: no code, no markup, no project
   file.

Out of scope: retargeting off `netcoreapp2.0`, or any package or project
format change; a release. The tests run on a 2.x runtime (2.2 here, which
`netcoreapp2.0` rolls forward to).
