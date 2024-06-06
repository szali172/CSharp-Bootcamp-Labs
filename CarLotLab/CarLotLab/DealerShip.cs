
namespace CarLotLab;

public class DealerShip
{
    public List<Car> Cars {  get; }

    public DealerShip(List<Car> cars)
    {
        Cars = cars;
    }

    public void ListCars()
    {
        Console.WriteLine("Available Cars:");
        Console.WriteLine("===============");
        for (int i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"{i + 1}.\t{Cars[i].ToString()}");
        }
        Console.WriteLine("===============");
    }

    public void Remove(int index)
    {
        Cars.RemoveAt(index);
    }
}
