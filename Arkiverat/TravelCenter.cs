// using System;
// using System.Collections.Generic;

// // Subject (Observable) interface
// public interface ISubject
// {
//     void RegisterObserver(IObserver observer);
//     void RemoveObserver(IObserver observer);
//     void NotifyObservers();
// }

// // Concrete subject (Concrete Observable)
// public class TravelCenter : ISubject
// {
//     private List<IObserver> observers = new List<IObserver>();
//     private float temperature;

//     public float Temperature
//     {
//         get { return temperature; }
//         set
//         {
//             temperature = value;
//             NotifyObservers();
//         }
//     }

//     public void RegisterObserver(IObserver observer)
//     {
//         observers.Add(observer);
//     }

//     public void RemoveObserver(IObserver observer)
//     {
//         observers.Remove(observer);
//     }

//     public void NotifyObservers()
//     {
//         foreach (var observer in observers)
//         {
//             observer.Update(temperature);
//         }
//     }
// }

// // Observer interface
// public interface IObserver
// {
//     void Update(float temperature);
// }

// // Concrete observer
// public class TemperatureDisplay : IObserver
// {
//     public void Update(float temperature)
//     {
//         Console.WriteLine("Temperature Display: " + temperature + "°C");
//     }
// }

// public class PhoneApp : IObserver
// {
//     public void Update(float temperature)
//     {
//         Console.WriteLine("Phone App: Temperature changed to " + temperature + "°C");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         TravelCenter travelCenter = new();
        
//         TemperatureDisplay display = new TemperatureDisplay();
//         PhoneApp app = new PhoneApp();

//         travelCenter.RegisterObserver(display);
//         travelCenter.RegisterObserver(app);

//         // Simulate temperature changes
//         travelCenter.Temperature = 25.5f;
//         travelCenter.Temperature = 30.0f;

//         travelCenter.RemoveObserver(app);

//         travelCenter.Temperature = 28.5f;
//     }
// }
