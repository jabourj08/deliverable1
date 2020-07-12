using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            int groupSize;

            string result;
            string destination = "";
            string travelSuggestion = "";


            //start loop for continuance
            string cont = "y";
            do
            {

                //check for correct response for vacationType and assign value
                int i = 1;
                do
                {
                    Console.WriteLine("What kind of trip would you like to go on? musical, tropical, or adventurous?: ");
                    vacationType = Console.ReadLine();
                    Console.WriteLine();

                    if (vacationType == "musical")
                    {
                        destination = "New Orleans";
                        i = 2;
                    }
                    else if (vacationType == "tropical")
                    {
                        destination = "A Beach Vacation in Mexico";
                        i = 2;
                    }
                    else if (vacationType == "adventurous")
                    {
                        destination = "Whitewater Rafting the Grand Canyon";
                        i = 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you did not enter a proper response. Please enter one of the 3 options with correct spelling");
                    }
                }
                while (i == 1);


                //check for correct response for groupSize and assign value
                do
                {
                    Console.WriteLine("How many people do you plan to have in your group?: ");
                    groupSize = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (groupSize >= 1 && groupSize <= 2)
                    {
                        travelSuggestion = "First Class flight";
                        i = 3;
                    }
                    else if (groupSize >= 3 && groupSize <= 5)
                    {
                        travelSuggestion = "Helicopter";
                        i = 3;
                    }
                    else if (groupSize >= 6)
                    {
                        travelSuggestion = "Charter Flight";
                        i = 3;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you did not enter a proper response. Please enter a number greater than 0");
                    }
                }
                while (i == 2);



                result = ("Since you have a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelSuggestion + " to " + destination);

                Console.WriteLine("Thank you for your responses...");
                Console.WriteLine();
                Console.WriteLine(result);
                Console.WriteLine();

                Console.WriteLine("Would you like to continue? enter y for yes or n for no: ");
                cont = Console.ReadLine();
                Console.WriteLine();
            }
            while (cont != "n");

            
        }
    }
}
