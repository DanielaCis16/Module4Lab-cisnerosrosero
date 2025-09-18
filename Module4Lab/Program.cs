using System;

namespace Module4Lab
{
    class Program
    {
        //Main method - entry point to your app
        static void Main(string[] args)
        {
            //Output greeting
            Console.WriteLine("🦁 Welcome to Como Park Zoo! 🐘");
            Console.WriteLine("================================"); //make output look nice

            //First, let's see a simple array example
            Console.WriteLine("Here are some animals we already have:");
            string[] sampleAnimals = { "Sea Lion", "Giraffe", "Lemur", "Polar Bear" };

            //Use a for loop to iterate (walk through) the elements of the array
            for (int i = 0; i < sampleAnimals.Length; i++)//++ operator that increments variable value by one
            {
                //Print the name of the current animal in the array
                Console.WriteLine($"- {sampleAnimals[i]}");
            }//end of for loop

            Console.WriteLine("\nNow let's add your animals to the Como Zoo!\n");

            //Use a while loop to get valid input
            Console.Write("How many animals do you want to add? ");

            int numberOfAnimals; //Holds the number of animals

            //Use a while loop when you aren't sure how many times the loop needs to run
            while (!int.TryParse(Console.ReadLine(), out numberOfAnimals) || numberOfAnimals <= 0)
            {
                Console.Write("Please enter a number greater than 0: ");
            }//end while loop

            //Create array to store the animals and make its size equal to
            //the number of animals the user wants to add to the zoo
            string[] animals = new string[numberOfAnimals];

            //Use a for loop to collect the animal names
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.Write($"Enter animal #{i + 1}: ");
                animals[i] = Console.ReadLine();
            }//end for loop

            //Display the animal using another for loop
            Console.WriteLine("\nYour new Como Zoo animals: ");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }//end for loop

            //Output a closing message
            Console.WriteLine($"\nYou added {animals.Length} animals in to Como Zoo!");
        }//end main method
    }//end of class
}//end of namespace