using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] FavNumbers = { 32, 13, 26, 54, 37 };

            //FavNumbers[2] = 345;

            //Console.WriteLine(FavNumbers[2]);

            //Console.ReadLine();


            //int[] favNum = { 324, 545, 667, 554 };

            //Console.WriteLine(favNum[1]);

            //Console.ReadLine();

            //int[] favNumbs = { 22, 17, 33, 21, 109 };

            //Console.WriteLine(favNumbs[0]);

            //Console.ReadLine();


            //int[] DisneyVacayDays = { 17, 11, 13, 12, 8 };

            //Console.WriteLine(DisneyVacayDays[1]);

            //Console.ReadLine();

            //int[] FiveCounts = { 22, 21, 12, 11, 43 };

            //FiveCounts[2] = 765;

            //Console.WriteLine ( FiveCounts[1] );

            //Console.ReadLine();


            //int[] RiskyNumbers = { 321, 12, 7, 8, 90 };

            //RiskyNumbers[4] = 324;

            //Console.WriteLine(RiskyNumbers[4]);

            //Console.ReadLine();

            //int[] InvestmentPro = { 324, 22, 17, 89, 76 };

            //Console.WriteLine( InvestmentPro[2]);

            //Console.ReadLine();

            //int[] JacksonPro = { 21, 22, 13, 23 };
            //Console.WriteLine(JacksonPro[3]);

            //JacksonPro[3] = 221;

            //Console.ReadLine();

            //string[] names = new string[7];
            //names[0] = "ralph";

            //string[] cars = { "BMW", "Tesla", "Honda" };

            //cars[0] = "Stang";
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}
            //Console.ReadLine();


            var candyBag = new string[] { "Snickers", "Kitkat", "Twix" };

            foreach (var item in candyBag)
            {
                Console.WriteLine(item);
            }
             
            
        }
    }
}
