using System;
using System.Globalization;

try
{
    // Get the current culture and region
    var culture = CultureInfo.CurrentCulture;
    var region = RegionInfo.CurrentRegion;

    // Current local date/time
    var now = DateTime.Now;

    // Format components (localized)
    string regionName = region.DisplayName ?? region.EnglishName ?? region.Name;
    string year = now.Year.ToString(culture);
    string monthName = now.ToString("MMMM", culture);   // full month name
    string weekdayName = now.ToString("dddd", culture); // full weekday name
    string timeOfDay = now.ToString("HH:mm:ss", culture); // 24-hour time with seconds

    Console.WriteLine($"Region: {regionName}");
    Console.WriteLine($"Year: {year}");
    Console.WriteLine($"Month: {monthName}");
    Console.WriteLine($"Weekday: {weekdayName}");
    Console.WriteLine($"Time: {timeOfDay}");
}
catch (Exception ex)
{
    // Fail gracefully by writing the error to console
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
