// See https://aka.ms/new-console-template for more information



// Factoru method + singleton = 2i1 

using Lab1DesignPattern;






//Singleton checker
TravelCenterFactory s1 = TravelCenterFactory.GetInstance();
TravelCenterFactory s2 = TravelCenterFactory.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}