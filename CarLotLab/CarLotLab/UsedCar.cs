
namespace CarLotLab;

public class UsedCar : Car
{
    private double Mileage { get; set; }

    public UsedCar(
        string Make,
        string Model,
        int Year,
        decimal Price,
        double Mileage) : base(Make, Model, Year, Price)
    {
        this.Mileage = Mileage;
    }

    public override string ToString()
    {
        return base.ToString() + $"\tMileage: {Mileage} miles";
    }
}
