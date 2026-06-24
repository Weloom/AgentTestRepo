using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var culture = CultureInfo.CurrentCulture;
        RegionInfo region;

        // Try to get the current region; fall back to creating one from the culture name if needed.
        try
        {
            region = RegionInfo.CurrentRegion;
        }
        catch
        {
            region = new RegionInfo(culture.Name);
        }

        var now = DateTime.Now;

        Console.WriteLine($"Region: {region.DisplayName} ({region.Name})");
        Console.WriteLine($"Year: {now.Year}");
        Console.WriteLine($"Month: {culture.DateTimeFormat.GetMonthName(now.Month)} ({now.Month})");
        Console.WriteLine($"Weekday: {culture.DateTimeFormat.GetDayName(now.DayOfWeek)}");
        Console.WriteLine($"Time of day: {now:HH:mm:ss}");
    }
}
