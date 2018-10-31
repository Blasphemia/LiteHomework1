using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class HatejinoMagaz
    {
        static void Main(string[] args)
        {

            string WarmСlothing = "pants, boots, hat and jacket";
            string SummerСlothes = "shorts, tank top, sneakers";

            string Food = "bread, vodka, cheese, rum, gin and bream";

            string answer;
            Console.WriteLine("It is warm or cold? Press 'W' if it is warm, and 'C' if it is cold");
            answer = Console.ReadLine();


            Weather(answer, WarmСlothing, SummerСlothes);
            GoShopping(Food);



            Console.ReadLine();
        }












        static void Weather(string answer, string WarmСlothing, string SummerСlothes)
        {


            while ((answer != "w") && (answer != "W") && (answer != "c") && (answer != "C"))
            {
                Console.WriteLine("Answer is incorrect, try again");
                answer = Console.ReadLine();
            }

            switch (answer)
            {
                case "W":
                    Console.WriteLine("You are dressed in " + SummerСlothes);
                    break;
                case "w":
                    Console.WriteLine("You are dressed in " + SummerСlothes);
                    break;
                case "C":
                    Console.WriteLine("You are dressed in " + WarmСlothing);

                    break;
                case "c":
                    Console.WriteLine("You are dressed in " + WarmСlothing);

                    break;
            }

        }

        static void GoShopping(string shoppingList)
        {



            Console.WriteLine("You bought products for a good time: " + shoppingList);
        }












    }
}
