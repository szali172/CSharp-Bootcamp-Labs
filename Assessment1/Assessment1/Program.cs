using System.Linq.Expressions;

static bool IsPassing(double grade)
{
    return grade > 65;
}


static double AverageGrades(double grade1, double grade2, double grade3)
{
    return (grade1 + grade2 + grade3) / 3;
}

static string OddOrEvenAndPassing(double grade)
{
    int gradeAsInt = (int)grade;
    switch(IsPassing(grade))
    {
        case true:
            switch(gradeAsInt % 2)
            {
                case 0:
                    return "passing and even";
                default:
                    return "passing and odd";
            }

        default:
            switch(gradeAsInt % 2)
            {
                case 0:
                    return "failing and even";
                default:
                    return "failing and odd";
            }
    }
}


/*
Console.WriteLine(IsPassing(75));
Console.WriteLine(IsPassing(65));

Console.WriteLine(AverageGrades(71.0, 75.0, 65.0));

Console.WriteLine(OddOrEvenAndPassing(65));
Console.WriteLine(OddOrEvenAndPassing(75));
Console.WriteLine(OddOrEvenAndPassing(64));
Console.WriteLine(OddOrEvenAndPassing(74));
*/