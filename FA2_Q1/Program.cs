using System;
using System.Linq;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        //initialize cities array
        string[] cities = { "Butterworth", "Mthatha", "Jagersfontein", "Kroonstad", "Boksburg", "Soweto", "Empangeni", "Polokwane", "Secunda", "Kuruman" };
        int num = 1;

        //Welcome user on startup
        Console.WriteLine("Welcome User\n");

        //Display all cities from array
        foreach (var city in cities) 
        {
            Console.WriteLine($"{num}. {city}");
            num++;
        }

        //Prompt user to enter first string char of city
        Console.WriteLine("\nEnter the first letter of the city's name: ");
        char firstChar = char.Parse( Console.ReadLine() );
        char firstCharUpper = char.ToUpper(firstChar);

        //Prompt user to enter last string char of city
        Console.WriteLine("Enter the last letter of the city's name: ");
        char secondChar = char.Parse(Console.ReadLine());
        char secondCharLower = char.ToLower(secondChar);

        //Find cities that starts and ends with given chars
        var filteredCities = cities.Where(city => city.StartsWith(firstCharUpper) && city.EndsWith(secondCharLower));

        foreach (var city in filteredCities) 
        {
            //Output String that starts and ends with given chars
            Console.WriteLine("\n" + city + " meets the criteria.");
        }
        
    }
}