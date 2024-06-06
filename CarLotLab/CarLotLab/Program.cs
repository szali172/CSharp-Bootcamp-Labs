using CarLotLab;

// Create a dealership class to store all the cars
DealerShip dealer = new DealerShip(
    new List<Car>()
    {
        new Car("Toyota", "Camry", 2024, 30_000),
        new Car("Honda", "Accord", 2024, 29_300),
        new Car("Ford", "Mustang", 2024, 35_610),
        new UsedCar("Subaru", "Outback", 2021, 25_750, 32_000),
        new UsedCar("BMW", "3 Series", 2017, 30_105, 40_000),
        new UsedCar("Audi", "Q5", 2022, 44_100, 32_000)
    }
);




while (dealer.Cars.Count != 0)
{
    // print out the list (by calling the ListCar method).
    dealer.ListCars();

    // Then ask the user which car they would like to buy, by number (the index of the car)
    Console.Write("Which car would you like to buy? Please enter the number: ");
    try
    {
        int input = int.Parse(Console.ReadLine());
        int index = input - 1;  // Since the ListCars offsets the number by 1
        Console.WriteLine("You have bought: " + dealer.Cars[index].ToString());
        Console.WriteLine("Congratulations!\n\n");
        dealer.Remove(index);
    }
    catch
    {
        Console.WriteLine("Please enter a valid number\n\n");
    }
}

Console.WriteLine("There are no more cars left");
