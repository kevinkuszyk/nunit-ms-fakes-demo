# nunit-ms-fakes-demo

Demo project showing how MS Fakes throws when used with NUnit.  This is the repro solution for [nunit/nunit#632](https://github.com/nunit/nunit/issues/632).

When the test is run, the following output is produced:

```
NUnit Console Runner 3.4.1
Copyright (C) 2016 Charlie Poole

Runtime Environment
   OS Version: Microsoft Windows NT 10.0.10240.0
  CLR Version: 4.0.30319.42000

Test Files
    src\TestProject\bin\Debug\TestProject.dll


Errors and Failures

1) Error : TestProject.TestClass.Test
Microsoft.QualityTools.Testing.Fakes.UnitTestIsolation.UnitTestIsolationException : Failed to resolve profiler path from COR_PROFILER_PATH and COR_PROFILER environment variables.
   at Microsoft.QualityTools.Testing.Fakes.UnitTestIsolation.IntelliTraceInstrumentationProvider.ResolveProfilerPath()
   at Microsoft.QualityTools.Testing.Fakes.UnitTestIsolation.IntelliTraceInstrumentationProvider.Initialize()
   at Microsoft.QualityTools.Testing.Fakes.UnitTestIsolation.UnitTestIsolationRuntime.InitializeUnitTestIsolationInstrumentationProvider()
   at Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.CreateContext()
   at TestProject.TestClass.Test() in c:\projects\github\NUnit MS Fakes Demo\src\TestProject\TestClass.cs:line 13

Run Settings
    WorkDirectory: c:\projects\github\NUnit MS Fakes Demo
    ImageRuntimeVersion: 4.0.30319
    ImageTargetFrameworkName: .NETFramework,Version=v4.5.2
    ImageRequiresX86: False
    ImageRequiresDefaultAppDomainAssemblyResolver: False
    NumberOfTestWorkers: 2

Test Run Summary
  Overall result: Failed
  Test Count: 1, Passed: 0, Failed: 1, Inconclusive: 0, Skipped: 0
    Failed Tests - Failures: 0, Errors: 1, Invalid: 0
  Start time: 2016-07-01 11:38:20Z
    End time: 2016-07-01 11:38:21Z
    Duration: 0.323 seconds

Results (nunit3) saved as TestResult.xml
```
