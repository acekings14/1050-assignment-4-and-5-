using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Time;

            const double priceofChildMatine = 3.99;
            const double priceofAdultMatine = 5.99;
            const double priceofSeniorMatine = 4.50;

            const double priceofChildEvening = 6.99;
            const double priceofAdultEvening = 10.99;
            const double priceofSeniorEvening = 8.50;

            double totalSeniorCost = 0;
            double totalChildCost = 0;
            double totalAdultCost = 0;

        
            double  colectiveTicketCost; 
            int quantityofChild = 0;
            int quantityofadult = 0;
            int quantityofSenior = 0;



            int NumberOfCandy = 0;
            int NumberOfHotdog = 0;
            int NumberOfLargesoda = 0;
            int NumberOfSmallSoda = 0;
            int NumberOfPopcorn = 0;
            int TotalNumOfPeople = 0;

            System.Console.WriteLine("Matine or evening?");
            Time = System.Console.ReadLine();
            if (Time.ToLower().StartsWith("m"))
            {
                const double ChildMatine = 3.99;
                const double AdultMatine = 5.99;
                const double SeniorMatine = 4.50;
            }
            System.Console.WriteLine("Number of Seniors");
            quantityofSenior = int.Parse(System.Console.ReadLine());
            totalSeniorCost = quantityofSenior * priceofSeniorEvening; 
            if (Time.ToLower().StartsWith("m"))
            {
                totalSeniorCost = quantityofSenior * priceofSeniorMatine;

            }


                System.Console.WriteLine("Number of Adults");
            quantityofadult = int.Parse(System.Console.ReadLine());
            totalAdultCost = quantityofadult * priceofSeniorMatine;
            if (Time.ToLower().StartsWith("m"))
            {
                totalAdultCost = quantityofadult * priceofAdultMatine;

            }


            System.Console.WriteLine("Number of Children");
            quantityofChild = int.Parse(System.Console.ReadLine());
            totalChildCost = quantityofChild * priceofChildMatine;
            if (Time.ToLower().StartsWith("m"))
            {
                totalChildCost = quantityofChild * priceofChildMatine;

            }


            double candies = 3.50;
            double largeSoda = 5.99;
            double hotDog = 3.99;
            double popcorn = 4.50;
            double smallSoda = 3.50;


            double totalCandyCost = 0;
            double totalHotDogCost = 0;
            double totalSmallSodasCost = 0;
            double totalPopcornCost = 0;
            double totalLargeSodasCost = 0;
            double totalRefreshmentCost = 0;
            double totalRefreshmentCostDiscount = 0;

            System.Console.WriteLine("Number of Candies");
            NumberOfCandy = int.Parse(System.Console.ReadLine());
            totalCandyCost = NumberOfCandy * candies;
           

                    System.Console.WriteLine("Number of Hot Dog");
            NumberOfHotdog = int.Parse(System.Console.ReadLine());
            totalHotDogCost = NumberOfHotdog * hotDog;
            

            System.Console.WriteLine("Number of Small Sodas");
            NumberOfSmallSoda = int.Parse(System.Console.ReadLine());
            totalSmallSodasCost = NumberOfSmallSoda * smallSoda;


            System.Console.WriteLine("Number of large Sodas");
            NumberOfLargesoda = int.Parse(System.Console.ReadLine());
            totalLargeSodasCost = NumberOfLargesoda * largeSoda;


            System.Console.WriteLine("Number of popcorn");
            NumberOfPopcorn = int.Parse(System.Console.ReadLine());
            totalPopcornCost = NumberOfPopcorn * popcorn;


            TotalNumOfPeople = quantityofadult + quantityofChild + quantityofSenior;
            colectiveTicketCost = totalAdultCost + totalSeniorCost + totalChildCost;

            System.Console.WriteLine("TotalNumOfPeople ticket Cost");
            System.Console.WriteLine( colectiveTicketCost);
            int discount = 2; 
            if (NumberOfPopcorn>1 && NumberOfLargesoda>1) 
            {
                totalRefreshmentCostDiscount = totalRefreshmentCost - discount; 
            }

            if (TotalNumOfPeople>=3)
            {
                System.Console.WriteLine("You have a free bag of popcorn!");
            }

            if (NumberOfCandy>3)
            {
                System.Console.WriteLine("free candy!");
            }
        }

    }
}
