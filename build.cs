#:sdk Microsoft.NET.Sdk.Web
#:package Humanizer@3.0.1

using Humanizer;
var since = TimeSpan.FromMinutes(5);

Console.WriteLine($"It was {since.Humanize()} ago.");
