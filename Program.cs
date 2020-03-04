using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {

            Estimate estName = new Estimate();
            Console.WriteLine("Hi! Thanks for considering us to be your dog's caretaker!");
            Console.WriteLine("Please set a name for this estimate!");
            estName.estName = Console.ReadLine();
            Console.WriteLine("What is your name?");
            estName.name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your dog's name?");
            estName.dogName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How much does he weigh?(In Pounds, numbers only, no decimals.)");
            estName.dogWeight = Convert.ToInt16(choiceSelect("a"));
            Console.WriteLine();
            Console.WriteLine("How many days will he be staying? It cost $75.00 a night.");
            estName.days = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("We have addon services if you're interested.");
            Console.WriteLine("If you'd like no addon services, please enter N");
            Console.WriteLine("If you'd like bathing and grooming at $169.00 per day, please enter in A.");
            Console.WriteLine("If you'd like only bathing at $112.00 per day, please enter C");
            estName.addon = choiceSelect("b");
            Console.WriteLine();
            Console.WriteLine("Here's the final bill!");
            if (estName.addon == "N")
            {
                estName.total = ((estName.days) * 75.00);
            }
            else if (estName.addon == "A")
            {
                estName.total = ((estName.days) * 75.00) + (estName.days * 169.00);
            }
            else if (estName.addon == "C")
            {
                estName.total = ((estName.days) * 75.00) + (estName.days * 112.00);
            }
            Console.WriteLine(estName.ToString());
            Console.WriteLine();
            Console.WriteLine("End of Program.");
        }
        public static string choiceSelect(string progChoice)
        {
            string choice = Console.ReadLine();
            string addonS = "";
            
            if(progChoice == "a")
            {
                int num;
                bool check = int.TryParse(choice, out num);
                if(check == true)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please put in numbers!");
                    return choiceSelect("a");
                }
            }
            else if (progChoice == "b")
            {
                if (choice == "N" || choice == "n")
                {
                    addonS = "N";
                    return addonS;
                }
                else if (choice == "A" || choice == "a")
                {
                    addonS = "A";
                    return addonS;
                }
                else if (choice == "C" || choice == "c")
                {
                    addonS = "C";
                    return addonS;
                }
                else
                {
                    Console.WriteLine("Invalid character, please select one of the above!");
                    return choiceSelect("b");
                }
            }
            return null;
        }

    }
    class Estimate
    {
        public string estName { get; set; }
        public string name { get; set; }
        public string dogName { get; set; }
        public int dogWeight { get; set; }
        public int days { get; set; }
        public string addon { get; set; }
        public double total { get; set; }

        public override String ToString()
        {
            return String.Format("Name: {0}\nDog's Name: {1}\nDog's Weight: {2}\nDays to Stay: {3}\nAddon Package(N: $0, A: $169, C: $112): {4}\nYour total price for this estimate is: ${5}", name, dogName, dogWeight, days, addon, total);
        }
    }
}
