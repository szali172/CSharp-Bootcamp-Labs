
namespace CarLotLab;

public class Car : Object
{
    private string Make {  get; set; }
    private string Model { get; set; }
    private int Year { get; set; }
    private decimal Price { get; set; }


    public Car()
    {
        Make = "";
        Model = "";
        Year = 2024;
        Price = 0.0M;
    }

    public Car(string make, string model, int year, decimal price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }


    public override string ToString()
    {
        return $"Make: {Make}\tModel: {Model}\tYear: {Year}\tPrice: ${Price}";
    }
}

