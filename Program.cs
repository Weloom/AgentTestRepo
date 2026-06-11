using System;
using System.Globalization;

// Get current culture and region
var culture = CultureInfo.CurrentCulture;
var region = RegionInfo.CurrentRegion;

var now = DateTime.Now;

Console.WriteLine("Application started - current region and date/time:");
Console.WriteLine();
// Region: DisplayName and two-letter code
Console.WriteLine($"Region: {region.DisplayName} ({region.Name})");
Console.WriteLine($"Culture: {culture.Name} - {culture.EnglishName}");
Console.WriteLine();
// Date/time pieces
Console.WriteLine($"Year: {now:yyyy}");
Console.WriteLine($"Month: {now:MMMM} ({now:MM})");
Console.WriteLine($"Weekday: {now:dddd}");
Console.WriteLine($"Time of day: {now:HH:mm:ss}");
Console.WriteLine();

// Keep console open when run by double-click (optional)
// Remove or comment out the following line in CI scenarios
// Console.WriteLine("Press Enter to exit...");
// Console.ReadLine();
