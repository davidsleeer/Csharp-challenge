using System;
using System.Collections.Generic;

namespace ConsoleApp12ch
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int i = 1;
            int j = 1;
            int count = 1;
            int pc;
            int times = 0;
            //List<int> store = new List<int>(20);
            string res = "y";
            while (res == "y" || res == "Y")
            {

            
            Console.WriteLine("Hello Welcome to Dice Game!");
            Console.WriteLine("How many times do you want to throw? input a number if you want, a n if you not setting a number");

            string temp = Console.ReadLine();
            if (temp != "n" & temp != "N")
            {
                times = int.Parse(temp);
                List<int> store = new List<int>(times);
                pc = rand.Next(1, 7);
                store.Add(pc);
                Console.WriteLine($"This round result is {pc}, continue?");
                string temp2 = Console.ReadLine();


                while ((temp2 == "y" || temp2 == "Y") & j < times)
                {
                    int pc2 = rand.Next(1, 7);
                    j++;
                    store.Add(pc2);
                    Console.WriteLine($"This round result is {pc2}, continue?");

                    temp2 = Console.ReadLine();
                    count = j;

                }
                int sum = 0;
                decimal ave = 0;
                foreach (var item in store)
                {

                    sum += item;
                    ave = Math.Round((decimal)sum / count, 4);

                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine($"The total is {sum}");
                Console.WriteLine($"The average is {ave}");
                Console.WriteLine("Do you want to continue? y if you want");
                res = Console.ReadLine();


            }
            else
            {
                List<int> store2 = new List<int>(i);
                int pc3 = rand.Next(1, 7);
                i++;
                store2.Add(pc3);
                Console.WriteLine($"This round result is {pc3}, continue?");
                string temp3 = Console.ReadLine();
                while (temp3 == "y" || temp3 == "Y")
                {
                    int pc4 = rand.Next(1, 7);
                    i++;

                    store2.Add(pc4);
                    Console.WriteLine($"this round result is {pc4}, continue?");

                    temp3 = Console.ReadLine();
                }



                int sum2 = 0;
                decimal ave2 = 0;
                foreach (var item in store2)
                {

                    sum2 += item;
                    ave2 = Math.Round((decimal)sum2 / (i - 1), 4);

                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine($"The total is {sum2}");
                Console.WriteLine($"The average is {ave2}");
                Console.WriteLine("Do you want to continue? y if you want");
                res = Console.ReadLine();


            }
        }
        }
    }
}
