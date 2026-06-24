using System;
using System.Globalization;

try
{
    var now = DateTime.Now;

    // Safely get culture info
    string cultureName;
    string cultureEnglishName;
    try
    {
        var culture = CultureInfo.CurrentCulture;
        cultureName = culture?.Name ?? "(unknown)";
        cultureEnglishName = culture?.EnglishName ?? "(unknown)";
    }
    catch (Exception)
    {
        cultureName = "(unknown)";
        cultureEnglishName = "(unknown)";
    }

    // Safely get region info (RegionInfo.CurrentRegion can throw in some environments)
    string regionDisplay;
    string regionName;
    try
    {
        var region = RegionInfo.CurrentRegion;
        regionDisplay = region?.DisplayName ?? "Unknown region";
        regionName = region?.Name ?? "??";
    }
    catch (Exception)
    {
        regionDisplay = "Unknown region";
        regionName = "??";
    }

    Console.WriteLine("Application started - current region and date/time:");
    Console.WriteLine();

    Console.WriteLine($"Region: {regionDisplay} ({regionName})");
    Console.WriteLine($"Culture: {cultureName} - {cultureEnglishName}");
    Console.WriteLine();

    Console.WriteLine($"Year: {now:yyyy}");
    Console.WriteLine($"Month: {now:MMMM} ({now:MM})");
    Console.WriteLine($"Weekday: {now:dddd}");
    Console.WriteLine($"Time of day: {now:HH:mm:ss}");
    Console.WriteLine();

    // Keep console open only for interactive user sessions
    if (Environment.UserInteractive)
    {
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    return 0;
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Unexpected error: {ex.Message}");
    return 1;
}
