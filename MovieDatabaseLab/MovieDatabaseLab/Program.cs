using Moviedatabase;


List<Movie> movies = new List<Movie>()
{
    new Movie("The Godfather", "drama"),
    new Movie("The Shining", "horror"),
    new Movie("Toy Story", "animated"),
    new Movie("Inception", "scifi"),
    new Movie("Forrest Gump", "drama"),
    new Movie("Hereditary", "horror"),
    new Movie("Finding Nemo", "animated"),
    new Movie("Fight Club", "drama"),
    new Movie("The Matrix", "scifi"),
    new Movie("Interstellar", "scifi"),
};

/* Category can be "animated", "horror", "scifi", "drama" or "all" */
static string DisplayMovies(List<Movie> movies, string category="all")
{
    List<Movie> filteredList;

    if (category == "all")
    {
        filteredList = movies;
    }
    else
    {
        filteredList = movies.Where(x => x.category == category).ToList();
    }

    string output = "No.\tName\t\tCategory";
    output += "\n-------------------------------------------------\n\n";
    for (int i = 0; i < filteredList.Count; i++)
    {
        output += $"{i + 1}.\t{filteredList[i].title}\t{filteredList[i].category}\n";
    }

    return output;
}


Console.WriteLine("Welcome to the Movie List Application!");


while(true) {
    Console.WriteLine("Please enter a category to view the list of available movies");
    Console.WriteLine("You can select from \"animated\", \"horror\", \"scifi\", \"drama\", or \"all\" to list every movie");
    string input = Console.ReadLine();
    try
    {
        switch(input)
        {
            case "animated":
                Console.WriteLine(DisplayMovies(movies, "animated"));
                break;
            case "horror":
                Console.WriteLine(DisplayMovies(movies, "horror"));
                break;
            case "scifi":
                Console.WriteLine(DisplayMovies(movies, "scifi"));
                break;
            case "drama":
                Console.WriteLine(DisplayMovies(movies, "drama"));
                break;
            case "all":
                Console.WriteLine(DisplayMovies(movies, "all"));
                break;
            default:
                Console.WriteLine("Please enter a valid category...");
                break;
        } 
    } catch
    {
        Console.WriteLine("The value you have entered is invalid. Try again...");
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    string yOrN = Console.ReadLine();
    try
    {
        if (yOrN =="y")
        {
            continue;
        }
        else if (yOrN == "n") {
            break;
        }
        else
        {
            throw new Exception("Whatta jackass");
        }
    } catch
    {
        Console.WriteLine("The value you have provided is invalid. The program is exiting...");
        break;
    }
}
