int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };


//Find the Minimum value 
Console.WriteLine($"Minimum: {nums.Min()}");

//Find the Maximum value
Console.WriteLine($"Maximum: {nums.Max()}");

//Find the Maximum value less than 10000
Console.WriteLine($"Maximum less than 10000: {nums.Where(x => x < 10_000).Max()}");

//Find all the values between 10 and 100
Console.WriteLine($"All values between 10 and 100: \n{string.Join(Environment.NewLine, nums.Where(x => x > 10 && x < 100))}");

//Find all the Values between 100000 and 999999 inclusive 
Console.WriteLine($"All values between 100000 and 999999 inclusive: \n{string.Join(Environment.NewLine, nums.Where(x => x >= 100_000 && x <= 999_999))}");

//Count all the even numbers 
Console.WriteLine($"All even numbers: \n{string.Join(Environment.NewLine, nums.Where(x => x % 2 == 0).ToList())}");
