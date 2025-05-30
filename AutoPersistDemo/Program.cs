using AutoPersistDemo;

Console.WriteLine("Hello, World!");

var settings = new UserSettings();

Console.WriteLine("Settings saved to UserSettings.json.");
Console.WriteLine($"Name: {settings.Name}, Age: {settings.Age}");
