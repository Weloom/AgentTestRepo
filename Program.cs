using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var culture = CultureInfo.CurrentCulture;
        RegionInfo region = null;

        // Try to get the current region; fall back to creating one from the culture name if needed.
        try
        {
            region = RegionInfo.CurrentRegion;
        }
        catch (Exception)
        {
            // Attempt fallback only when culture has a non-empty name
            if (!string.IsNullOrEmpty(culture?.Name))
            {
                try
                {
                    region = new RegionInfo(culture.Name);
                }
                catch (Exception)
                {
                    // Could not determine region; leave as null and handle below
                    region = null;
                }
            }
        }

        var now = DateTime.Now;

        var regionDisplay = region != null ? $"{region.DisplayName} ({region.Name})" : "Unknown region";

        Console.WriteLine($"Region: {regionDisplay}");
        Console.WriteLine($"Year: {now.Year}");
        Console.WriteLine($"Month: {culture.DateTimeFormat.GetMonthName(now.Month)} ({now.Month})");
        Console.WriteLine($"Weekday: {culture.DateTimeFormat.GetDayName(now.DayOfWeek)}");
        Console.WriteLine($"Time of day: {now:HH:mm:ss}");
    }
}
