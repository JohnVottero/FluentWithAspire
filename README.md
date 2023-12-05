# .NET Aspire with FluentUI Blazor app

This reproduces an issue runnng a FluentUI-Blazor app with Aspire.

When you start debugging of the FluentWithAspire.AppHost project it fails with:

```
System.AggregateException
  HResult=0x80131500
  Message=One or more errors occurred. (Method not found: 'Void Microsoft.FluentUI.AspNetCore.Components.LibraryConfiguration.set_HostingModel(Microsoft.FluentUI.AspNetCore.Components.BlazorHostingModel)'.)
  Source=System.Private.CoreLib
  StackTrace:
   at System.Threading.Tasks.Task.ThrowIfExceptional(Boolean includeTaskCanceledExceptions)
   at System.Threading.Tasks.Task.Wait(Int32 millisecondsTimeout, CancellationToken cancellationToken)
   at System.Threading.Tasks.Task.Wait()
   at Aspire.Hosting.DistributedApplication.Run()
   at Program.<Main>$(String[] args) in E:\VSTest\FluentWithAspire\FluentWithAspire.AppHost\Program.cs:line 5

  This exception was originally thrown at this call stack:
    [External Code]

Inner Exception 1:
MissingMethodException: Method not found: 'Void Microsoft.FluentUI.AspNetCore.Components.LibraryConfiguration.set_HostingModel(Microsoft.FluentUI.AspNetCore.Components.BlazorHostingModel)'.
```

This project was created using the "Fluent Blazor Web App" template. Then a right-click on the project and select "Add->.NET Aspire Orchestrator Support...".

