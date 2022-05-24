using System;

class MainClass
{
    public static void Main(String[] args)
{   
        //define loop variable
        string restart;

        //init do loop
        do
        {
            //ask user how many people we are making sandwiches for
            Console.WriteLine("How many people are we making PB&J sandwiches for?");

            //wait for user input
            int people = int.Parse(Console.ReadLine());

            //add line to match formatting of example
            Console.WriteLine("\n");

            //add statement of need
            Console.WriteLine("You need:");

            //add line to match formatting of example
            Console.WriteLine("\n");

            //define variable for slices needed
            double slices = 2 * (people);

            //print slices needed
            Console.WriteLine($"    {slices} slices of bread");

            //define variable for pb needed
            double pb = 2 * (people);

            //print pb needed
            Console.WriteLine($"    {pb} tablespoons of peanut butter");

            //define variable for jelly needed
            double jelly = 4 * (people);

            //print jelly needed
            Console.WriteLine($"    {jelly} teaspoons of jelly");

            //add line to match formatting of example
            Console.WriteLine("\n");

            //add statement
            Console.WriteLine("    which is...");

            //add line to match formatting of example
            Console.WriteLine("\n");

            //define variable for loaves needed
            double loaves = (slices) / 28;
            Console.WriteLine($"    {Math.Ceiling(loaves)} loaves of bread");

            //define variable for pbJars needed
            double pbJar = (pb) / 32;
            Console.WriteLine($"    {Math.Ceiling(pbJar)} jars of peanut butter");

            //define variable for jellyJars needed
            double jellyJar = (jelly) / 48;
            Console.WriteLine($"    {Math.Ceiling(jellyJar)} jars of jelly");

            //add line to match formatting of example
            Console.WriteLine("\n");

            //ask user to restart or exit
            Console.WriteLine("Would you like to restart? Enter Yes or y to continue, or enter any other key to exit.");

            //wait for user input
            restart = Console.ReadLine().ToLower();
        }
        //define loop conditions
        while (restart == "yes" || restart == "y");

        //print Goodbye
        Console.WriteLine("GoodBye!");

    }
}