using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_A_level
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string line = Console.ReadLine();
            //Console.WriteLine($"My name is {line}."); //$-конкатинация

            //bool boolValue = true;
            //string str = "Hello";
            //int num = 100;
            //double doub = 2.3;
            //Console.WriteLine(boolValue +"\n" + str + "\n" + num + "\n" + doub + "\n");
            Console.WriteLine("***********FIZZBUZZ***********");

            int number = Convert.ToInt16(Console.ReadLine());
 
            for (int i = 0; i <= number; i++)
            {
                bool fizzbuzz = i % 15 == 0;
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
               

                if ( fizzbuzz)
                {
                    Console.WriteLine(i + " - FizzBuzz");
                }
                else if ( fizz  )
                    Console.WriteLine(i + " - Fizz");
                else if ( buzz)
                {
                    Console.WriteLine(i + " - Buzz");
                    
                }
                else
                    Console.WriteLine(i);

            }

            Console.WriteLine("\n");
            Console.WriteLine("*****Домашнее задание из телеграмма*****");
            for (int j=0;j<50;j++)
            {
                if(j%2==0)
                    Console.WriteLine($"{j}^2 =  {Math.Pow(j, 2)}");
                else
                    Console.WriteLine($"{j}^3 = { Math.Pow(j, 3)}");

            }

            Console.WriteLine("\n");
            Console.WriteLine("***********Домашнее задание из презентации***********");
            double run = 10;
            double plus;
            double sum = 10;
            int day=1;

            Console.WriteLine($"Day{day} - Run: {run} km. Total distance: {sum}");

            while (sum < 100) 
            {
                day++;
                if (day % 2 != 0)
                {
                    plus = (run / 100) * 10;
                    run += plus;
                    sum += run;
                
                Console.WriteLine($"Day{day} - Run: {run} km. Total distance: {sum}");
                }
                else
                Console.WriteLine($"Day{day} - rest. Total distance: {sum}");


            }
            Console.WriteLine("\n");
            Console.WriteLine($"Total distance: {sum} in day {day}");
            
        }
    }
}
