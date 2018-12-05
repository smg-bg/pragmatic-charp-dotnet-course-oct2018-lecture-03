using System;
using System.Globalization;
using System.Text;

namespace StringCreation
{
    class Program
    {
        public enum Gender
        {
            Male, 
            Female, 
            Alien, 
            Unknown
        }

        static void Main(string[] args) {

            // change encoding 
            Console.OutputEncoding = Encoding.Unicode;

            //// =
            //string name = "Georgi";

            //Console.WriteLine(name);
            
            //// +=
            //name += " Panayotov";

            //Console.WriteLine(name);

            //// String.Concat(...)
            //name = string.Concat("Georgi", " ", "Panayotov");
            //Console.WriteLine(name);

            //// String.Format(...)

            //Console.WriteLine(string.Format(
            //    @"My \name is {0} and I'm born in {1}. Hello {0}!", "Georgi", "Varna"));

            //decimal salary = 7777.77M;

            //Console.WriteLine(string.Format(CultureInfo.GetCultureInfo("en-GB"),
            //    "My salary is {0:C}.", salary));

            //double x = 7.777777;

            //string res = x.ToString("C");

            //// String Interpolation
            //int missedCalls = 7;
            //string msg = $"You have { missedCalls * 10 / 21 } missed calls";


            //// String Searching
            //bool check = msg.Contains("missed");
            //Console.WriteLine(msg.IndexOf("have"));
            //Console.WriteLine(msg.IndexOf('a'));
            //Console.WriteLine(msg.LastIndexOf('a'));
            //Console.WriteLine(msg.IndexOf("giraffe"));

            //// String Changing
            //var output = "It's fun to program";
            //output = output.Insert(5, "so much ");

            //Console.WriteLine(output);

            //const byte firstColumnPadding = 30;
            //const byte secondColumnPadding = 15;
            
            //Console.Write("Name".PadRight(firstColumnPadding));
            //Console.WriteLine("Score".PadLeft(secondColumnPadding));
            //Console.WriteLine(new string('-', 73));
            //Console.Write("Georgi".PadRight(firstColumnPadding));
            //Console.WriteLine("7".PadLeft(secondColumnPadding));

            //Console.Write("Enter your name:");
            //string userName = Console.ReadLine().Trim();

            //if (string.IsNullOrWhiteSpace(userName))
            //{
            //    Console.WriteLine("Sorry, you need enter you name!!!");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello, {userName}!");
            //}

            double totalPrice = 0;
            double price = 200;

            //if (price >= 0)
            //{
            //    totalPrice += price;
            //}
            //else
            //{
            //    totalPrice = double.NaN;
            //}

            //totalPrice = price >= 0 ? totalPrice + price : double.NaN;


            if (price > 100)
            {
                totalPrice += Math.Pow(price, 2);
            }
            else if (price > 50)
            {
                totalPrice += price;
            }
            else
            {
                totalPrice = double.NaN;
            }

            Gender gender = Gender.Female;

            switch (gender)
            {
                case Gender.Male:
                case Gender.Female:
                    Console.Write("You are fine");
                    break;
                case Gender.Alien:
                    Console.Write("dadsa");
                    break;
                default:
                    Console.WriteLine("You must be kidding me :)");
                    break;
            }



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
