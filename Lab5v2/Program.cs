using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of array input you want(1-hand; 2-random)");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("What type(enter or spaces)");
                        string ch = Console.ReadLine();
                        if (ch == "enter")
                        {
                            HandmadeEnter();
                        }
                        else if (ch == "spaces")
                            HandmadeSpaces();
                        else
                            Console.WriteLine("Error");
                        break;
                    }
                case 2:
                    {
                        Randomfill();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Bruh, I say, 1 or 2. I lazzy programer so I don't want give you a chance to repeat, hehe ^_^");
                        break;
                    }
            }
            Console.ReadKey();
        }
        static void Randomfill()
        {
            Console.WriteLine("Please, enter the amount of the array numbers:\t");
            int amountOfArrayNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value of the array:\t");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value of the array:\t");
            int maxValue = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int[] myArray = new int[amountOfArrayNumbers];
            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = ran.Next(minValue, maxValue);
                Console.Write(myArray[i] + " ");
            }
            Console.Write("\nSum of positiv numbers after last negative:\t");
            SumOfArrayNumbers(myArray);
            Console.ReadLine();
        }
        static void HandmadeEnter()
        {
            Console.WriteLine("Please, enter the amount of the array numbers:\t");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the number on {i} index:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum of positiv numbers after last negative:\t");
            SumOfArrayNumbers(myArray);
            Console.ReadLine();
        }
        static void HandmadeSpaces()
        {
            Console.WriteLine("Write your array:");
            string[] data = Console.ReadLine().Trim().Split();
            int[] myArray = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                myArray[i] = int.Parse(data[i]);
            }
            Console.Write("Sum of positiv numbers after last negative:\t");
            SumOfArrayNumbers(myArray);
            Console.ReadLine();
        }
        static void SumOfArrayNumbers(int[] myArray)
        {
            int sum = 0;
            bool negRes = false;
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                if (myArray[i] < 0)
                {
                    negRes = true;
                    break;
                }
                else
                    sum += myArray[i];
            }
            if (negRes)
                Console.WriteLine(sum);
            else
                Console.WriteLine("There no negative numbers");
        }
    }
}
