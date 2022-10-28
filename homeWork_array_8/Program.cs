using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 10;
            int[] numbers = new int[arraySize];
            int lowerLimitRandom = 0;
            int upperLimitRandom = 10;
            int userInput;

            int firstElemetArray;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(lowerLimitRandom, upperLimitRandom + 1);
            }

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"{numbers[i]}  ");
            } 

            Console.WriteLine("\nУкажите на сколько позиций нужно сдвинуть массив в лево? ");
            userInput = Convert.ToInt32(Console.ReadLine());
            
            if (userInput > arraySize) 
            {
                userInput = arraySize % userInput;
            }

            for (int i = 0; i < userInput; i++)
            {
                firstElemetArray = numbers[0];

                for (int j = 0; j < numbers.Length - 1 ; j++) 
                {
                    numbers[j] = numbers[j+1];
                }

                numbers[numbers.Length - 1] = firstElemetArray;
            }

            Console.WriteLine($"Массив сдвинутый в лево {userInput} раз");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}  ");
            }

            Console.ReadKey();
        }
    }
}
