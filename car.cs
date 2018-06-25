using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price ;
  private int _miles;
  private string _color;

  public Car(string makeModel, int price, int miles, string color = "Blue")
  {
    _makeModel = makeModel;
    _price = price;
    _miles = miles;
    _color = color;
  }

  public void SetModel(string makeModel)
  {
    _makeModel = makeModel;
  }

  public string GetModel()
  {
    return _makeModel;
  }

  public void SetPrice(int price)
  {
    _price = price;
  }

  public string GetPrice()
  {
    return _price;
  }

  public void SetMiles(int miles)
  {
    _miles = miles;
  }

  public string GetMiles()
  {
    return _miles;
  }

  public void SetColor(string color)
  {
    _color = color;
  }

  public string GetColor()
  {
    return _color;
  }

  public void CarInfo()
  {
    Console.WriteLine("Model: "+_makeModel);
    Console.WriteLine("Price: "+_price.ToString());
    Console.WriteLine("Miles: "+_miles.ToString());
    Console.WriteLine("Color: "+_color);
  }
}

  public class Program
  {
    public static void Main()
    {
    Car porsche = new Car("2014 Porsche 911",114991,7864);
    Car ford = new Car("2011 Ford F450",55995,14241,"Black");
    Car lexus = new Car("2013 Lexus RX 350",44700,20000,"Red");
    Car mercedes = new Car("Mercedes Benz CLS550",39900,37979,"Green");

    List<Car> AllCars = new List<Car>() { porsche, ford, lexus, mercedes };
    List<Car> Cars = new List<Car>();

    Console.WriteLine("Enter Maximum Price:");
    int maxPrice = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Maximum Mileage:");
    int maxMileage = int.Parse(Console.ReadLine());

    if()



    foreach(Car automobile in Cars)
    {
      automobile.CarInfo();
    }


    }
  }
