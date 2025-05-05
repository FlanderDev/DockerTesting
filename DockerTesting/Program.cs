using System.Globalization;

Console.WriteLine($"IT'S {DateTime.Now:HH:mm:ss} MOTHERFUCKER!");

var culture = CultureInfo.CurrentCulture;
var uiCulture = CultureInfo.CurrentUICulture;
var timeZone = TimeZoneInfo.Local;

Console.WriteLine("=== Locale and Language Information ===");
Console.WriteLine($"Culture Name: {culture.Name} ({culture.EnglishName})");
Console.WriteLine($"UI Culture Name: {uiCulture.Name} ({uiCulture.EnglishName})");
Console.WriteLine($"Date Format: {culture.DateTimeFormat.ShortDatePattern}");
Console.WriteLine($"Time Format: {culture.DateTimeFormat.ShortTimePattern}");
Console.WriteLine($"Currency Symbol: {culture.NumberFormat.CurrencySymbol}");
Console.WriteLine($"Number Decimal Separator: {culture.NumberFormat.NumberDecimalSeparator}");
Console.WriteLine($"List Separator: {culture.TextInfo.ListSeparator}");
Console.WriteLine($"Measurement System: {(culture.IsNeutralCulture ? "Unknown" : (culture.Name.StartsWith("en-US") ? "Imperial" : "Metric"))}");

Console.WriteLine();
Console.WriteLine("=== Time Zone Information ===");
Console.WriteLine($"Time Zone: {timeZone.DisplayName}");
Console.WriteLine($"Time Zone ID: {timeZone.Id}");
Console.WriteLine($"UTC Offset: {timeZone.BaseUtcOffset}");
Console.WriteLine($"Is Daylight Saving Time: {timeZone.IsDaylightSavingTime(DateTime.Now)}");

Console.WriteLine();
Console.WriteLine("=== Region Information ===");
var region = new RegionInfo(culture.Name);
Console.WriteLine($"Region Name: {region.DisplayName}");
Console.WriteLine($"Region Code: {region.TwoLetterISORegionName}");
Console.WriteLine($"Currency: {region.CurrencySymbol} ({region.ISOCurrencySymbol})");
Console.WriteLine($"Is Metric: {region.IsMetric}");
Console.WriteLine("--- DONE ---");