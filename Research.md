#Research

Consider making calculator app.


```csharp
using System;

// Factory Method
public abstract class Sensor
{
    public abstract void Measure();
}

public class TemperatureSensor : Sensor
{
    public override void Measure()
    {
        Console.WriteLine("Measuring temperature...");
    }
}

public class HumiditySensor : Sensor
{
    public override void Measure()
    {
        Console.WriteLine("Measuring humidity...");
    }
}

// Singleton
public sealed class WeatherStation
{
    private static WeatherStation instance;
    private WeatherStation() { }

    public static WeatherStation Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new WeatherStation();
            }
            return instance;
        }
    }

    public void UpdateWeather(string weatherInfo)
    {
        Console.WriteLine($"Weather station updated: {weatherInfo}");
    }
}

// Strategy
public interface WeatherDisplayStrategy
{
    void Display(string weatherInfo);
}

public class ConsoleDisplayStrategy : WeatherDisplayStrategy
{
    public void Display(string weatherInfo)
    {
        Console.WriteLine($"Console Display: {weatherInfo}");
    }
}

public class FileDisplayStrategy : WeatherDisplayStrategy
{
    public void Display(string weatherInfo)
    {
        // Simulate writing to a file
        Console.WriteLine($"File Display: Writing to file: {weatherInfo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Factory Method: Create sensors
        Sensor temperatureSensor = new TemperatureSensor();
        Sensor humiditySensor = new HumiditySensor();

        // Singleton: Get the WeatherStation instance
        WeatherStation station = WeatherStation.Instance;

        // Strategy: Create display strategies
        WeatherDisplayStrategy consoleDisplay = new ConsoleDisplayStrategy();
        WeatherDisplayStrategy fileDisplay = new FileDisplayStrategy();

        // Set the display strategy (you can switch between console and file display)
        WeatherDisplayStrategy currentDisplay = consoleDisplay;

        // Simulate measuring and updating weather
        temperatureSensor.Measure();
        station.UpdateWeather("Sunny");

        // Use the selected display strategy to show weather information
        currentDisplay.Display("Sunny");

        // Switch to a different display strategy (e.g., file display)
        currentDisplay = fileDisplay;
        station.UpdateWeather("Rainy");

        // Use the new display strategy
        currentDisplay.Display("Rainy");

        Console.ReadLine();
    }
}
```

In this single application:

1. Factory Method is used to create different types of sensors (TemperatureSensor and HumiditySensor).
2. Singleton ensures a single instance of the WeatherStation.
3. Strategy allows you to choose between different display strategies (ConsoleDisplayStrategy and FileDisplayStrategy) for showing weather information.


Certainly, here are some free online resources where you can learn about design patterns:

1. **Design Patterns in C# - Sourcemaking**:
   - Website: [Sourcemaking Design Patterns](https://sourcemaking.com/design_patterns)
   - Sourcemaking offers a comprehensive guide to design patterns with examples in various programming languages, including C#. It's a great resource for understanding and implementing design patterns.

2. **Refactoring.Guru - Design Patterns**:
   - Website: [Refactoring.Guru Design Patterns](https://refactoring.guru/design-patterns)
   - Refactoring.Guru provides detailed explanations and code examples for design patterns. It covers a wide range of design patterns and is a valuable resource for learning.

3. **Dofactory Design Patterns**:
   - Website: [Dofactory Design Patterns](https://www.dofactory.com/net/design-patterns)
   - Dofactory offers explanations, UML diagrams, and C# code examples for various design patterns. While it has a premium section, there is also a free section with plenty of information.

4. **TutorialsPoint - C# Design Patterns**:
   - Website: [TutorialsPoint C# Design Patterns](https://www.tutorialspoint.com/design_pattern/design_pattern_overview.htm)
   - TutorialsPoint provides tutorials on various design patterns with C# examples. It's a beginner-friendly resource.

5. **YouTube Video Tutorials**:
   - Search for YouTube channels that specialize in programming tutorials. Channels like "The Net Ninja" and "Derek Banas" often have free videos explaining design patterns.

6. **GitHub Repositories**:
   - Many GitHub repositories provide examples of design patterns in C#. You can search GitHub for repositories with C# design pattern implementations and study the code.

7. **Coursera - "Design Patterns" by University of Alberta**:
   - Course: [Design Patterns on Coursera](https://www.coursera.org/learn/design-patterns)
   - Coursera offers a free course on design patterns by the University of Alberta. While you can audit the course for free, you can also access the course materials.

8. **edX - "Software Construction: Object-Oriented Design" by ETH Zurich**:
   - Course: [edX Software Construction Course](https://www.edx.org/professional-certificate/ethx-software-construction-object-oriented-design)
   - This course on edX covers object-oriented design principles, including design patterns, and offers a free audit option.

These online resources provide free content for learning design patterns in C# and other programming languages. You can explore them at your own pace and practice by implementing the patterns in your own projects.
