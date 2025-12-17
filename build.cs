#:sdk Microsoft.NET.Sdk.Web
#:package Humanizer@2.14.1

using Humanizer;
var since = TimeSpan.FromMinutes(5);

Console.WriteLine($"It was {since.Humanize()} ago.");
