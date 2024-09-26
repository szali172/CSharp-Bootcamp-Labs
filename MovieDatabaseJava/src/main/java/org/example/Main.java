package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Movie> movies = List.of(
                new Movie("The Godfather", "Crime Drama"),
                new Movie("Inception", "Sci-Fi Thriller"),
                new Movie("The Shining", "Horror"),
                new Movie("Titanic", "Romance/Disaster"),
                new Movie("The Dark Knight", "Superhero/Action"),
                new Movie("Forrest Gump", "Drama"),
                new Movie("Jurassic Park", "Adventure/Sci-Fi"),
                new Movie("Pulp Fiction", "Crime/Comedy"),
                new Movie("The Lord of the Rings", "Fantasy"),
                new Movie("La La Land", "Musical/Drama")
        );

        System.out.println("Welcome to the movies lab!");

        // Continuous loop
        while (true) {

            // Ask user to enter category
            System.out.println("Please enter a category of movies " +
                               "(enter 'All' to see all available movies)");
            String category = scanner.nextLine();

            // Filter the movies by category
            List<Movie> filtered = filterMovies(movies, category);
            if (filtered.isEmpty()) {
                System.out.println("The category entered was not valid or does not exist. Please try again.");
            } else {
                System.out.printf("\t\t%-25s\t%-10s\n", "Title", "Category");
                System.out.println("\t\t---------------------------------------------");
                for (int i = 0; i < filtered.size(); i++) {
                    System.out.printf("%d.\t\t|%-25s\tCategory: %-10s\n", i + 1, filtered.get(i).getTitle(), filtered.get(i).getCategory());
                }
            }

            // Ask to repeat or break
            System.out.print("Would you like to continue? (y/n) ");
            String yOrN = scanner.nextLine();
            if (yOrN.equalsIgnoreCase("n")) {
                break;
            }

        }
        System.out.println("Goodbye");
    }

    private static List<Movie> filterMovies(List<Movie> movies, String category){
        if (category.equalsIgnoreCase("All")) {
            return movies;
        } else {
            return movies.stream().filter(x -> x.getCategory().equalsIgnoreCase(category) || x.getCategory().toLowerCase().contains(category.toLowerCase())).toList();
        }
    }

}
