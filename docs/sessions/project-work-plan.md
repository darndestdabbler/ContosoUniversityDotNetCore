# Project work plan — sessions

**Written by `dabbler` as a fold of `activity-log.json`.**
Hand edits are overwritten by the next append. The record is the log;
this page is one view of it.

---

## Sessions

The numbered sessions are declared from `session-plan.md`; each one's task is what its own plan step declared.

| # | Session | Releasable | Declared |
| ---: | --- | --- | --- |
| 1 | Author or import the change plan | no | 2026-11-10 |
| 2 | Break the change plan into numbered sessions | no | 2026-11-10 |
| 3 | The calculator page | no | 2026-11-10 |
| 4 | Documentation comments on the calculator | no | 2026-11-10 |

### Session 1 — Author or import the change plan

**Releasable: no.**

Session 1 writes docs/planning/solution-plan.md from docs/planning/brief.md and nothing else: one paragraph on the repository as found -- ASP.NET Core MVC on netcoreapp2.0, two SDK-style projects in ContosoUniversity.sln at the root, feature folders under ContosoUniversity\Features each with its controller and views, the navigation in Features\Shared\_Layout.cshtml, xunit 2.3.1 integration tests in ContosoUniversity.IntegrationTests run by the dotnet suite dabbler.yaml declares against the LocalDB test database the repository's RoundhousE scripts deploy -- and one section per change: the calculator page (Calculator, CalculatorController and Index.cshtml in Features\Calculator, a navigation link, and CalculatorTests in the test project) and the documentation comments on what it added, with nothing else changed.

### Session 2 — Break the change plan into numbered sessions

**Releasable: no.**

Session 2 appends two numbered sessions to docs/sessions/session-plan.md from docs/planning/solution-plan.md and writes nothing else: Session 3, the calculator page -- Calculator, CalculatorController and Index.cshtml in Features\Calculator, a navigation link, and CalculatorTests in the test project, run by dotnet test -- and Session 4, XML documentation comments on what session 3 added and a Razor comment atop its view, with no code, markup or project file changed. No release session is planned, because the brief names none.

### Session 3 — The calculator page

**Releasable: no.**

Session 3 adds an online calculator page to ContosoUniversityDotNetCore inside its existing shape, on netcoreapp2.0: ContosoUniversity/Features/Calculator/Calculator.cs (a static Calculator with Add and Subtract over decimals), ContosoUniversity/Features/Calculator/CalculatorController.cs (GET Index shows the form, POST Index shows the sum and difference) and ContosoUniversity/Features/Calculator/Index.cshtml, whose form opts out of the layout's global AJAX submit with the repository's own no-ajax class, a Calculator link in ContosoUniversity/Features/Shared/_Layout.cshtml, and ContosoUniversity.IntegrationTests/Features/Calculator/CalculatorTests.cs with one xunit fact each for Add and Subtract. The SDK-style projects take the new files by glob, so no project file changes. Each step is shown by dotnet build, the last by dotnet test of CalculatorTests.

### Session 4 — Documentation comments on the calculator

**Releasable: no.**

Session 4 adds documentation comments to what session 3 added and changes nothing else: XML documentation comments on Calculator, Add and Subtract in ContosoUniversity/Features/Calculator/Calculator.cs and on CalculatorController and both Index actions in ContosoUniversity/Features/Calculator/CalculatorController.cs, and a Razor comment at the top of ContosoUniversity/Features/Calculator/Index.cshtml. Each step is shown by dotnet build and by a check that the diff of its files against HEAD only adds comment lines.
