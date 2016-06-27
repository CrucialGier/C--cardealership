using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _message;

public void SetMakeModel(string newMakeModel)
{
_makeModel = newMakeModel;
}
public string GetMakeModel()
{
  return _makeModel;
}

public void SetPrice(int newPrice)
{
  _price = newPrice;
}
public int GetPrice()
{
  return _price;
}

public void SetMiles(int newMiles)
{
  _miles = newMiles;
}
public int GetMiles()
{
  return _miles;
}
public void SetMessage(string newMessage)
{
  _message = newMessage;
}
public string GetMessage()
{
  return _message;
}
  public Car(string carMakeModel, int carPrice, int carMiles, string carMessage="ride a bike")
  {
    _makeModel = carMakeModel;
    _price = carPrice;
    _miles = carMiles;
    _message = carMessage;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864, "this is outrageous");
    Car ford = new Car("2011 Ford F450", 55995, 14241,"i don't want this truck");
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000,"oh ok");
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);


    // Car porsche = new Car();
    // porsche.MakeModel = "20014 Porsche 911";
    // porsche.Price = 114991;
    // porsche.Miles = 7864;
    //
    // Car ford = new Car();
    // ford.MakeModel = "2011 Ford F450";
    // ford.Price = 55995;
    // ford.Miles = 14241;
    //
    // Car lexus = new Car();
    // lexus.MakeModel = "2013 Lexus RX 350";
    // lexus.Price = 44700;
    // lexus.Miles = 20000;
    //
    // Car mercedes = new Car();
    // mercedes.MakeModel = "Mercedes Benz CLS550";
    // mercedes.Price = 39900;
    // mercedes.Miles = 37979;

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("Search doesn't match any cars in stock.");
    }
    else
    {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.GetMakeModel()+" "+automobile.GetMessage());
      }
    }
  }
}
