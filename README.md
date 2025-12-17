# 37062

Reproduction for updating nuget packages in .NET 10 single file projects.

## Current behavior

Renovate does not recognize `#:package Some.Package@1.0.0` or `#:sdk Some.Sdk@1.0.0` directives used to include nuget packages in single file C# projects.
https://devblogs.microsoft.com/dotnet/announcing-dotnet-run-app/

## Expected behavior
Given a code file is included in the `managerFilePatterns` of the nuget manager manually, it will update the versions of the packages.

```csharp
#:sdk Microsoft.NET.Sdk.Web
#:package Humanizer@2.13.14

using Humanizer;
var since = TimeSpan.FromMinutes(5);

Console.WriteLine($"It was {since.Humanize()} ago.");
```

The result would look like:
```csharp
#:sdk Microsoft.NET.Sdk.Web
#:package Humanizer@2.14.1

using Humanizer;
var since = TimeSpan.FromMinutes(5);

Console.WriteLine($"It was {since.Humanize()} ago.");
```

## Link to the Renovate issue or Discussion

[#37062](https://github.com/renovatebot/renovate/discussions/37062)
