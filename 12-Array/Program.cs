using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git");
            //Fråga användaren hur många tal som ska finnas i arrayen.
            Console.WriteLine("Hur många heltal vill du lagra i arrayen? ");

            // Spara värdet från användaren.
            string arraySize = (Console.ReadLine());
            int parseString = int.Parse(arraySize);
            Console.WriteLine($"Storleken på listan: {arraySize}");
            Console.Write("Skriv in det högsta talet som du vill lagra: ");
            int maxNum = int.Parse(Console.ReadLine());
            Console.Write("Skriv in det lägsta talet som du vill lagra: ");
            int minNum = int.Parse(Console.ReadLine());
            int leftoverNums = parseString - 2;
            Console.WriteLine($"Vilka övriga {leftoverNums} tal vill du lagra?");
            string inBetween = Console.ReadLine();
            int betweenNums = 0;
            int[] arrayList = new int[parseString];
            for (int k = 0; k < parseString; k++)
            {
                while (!int.TryParse(inBetween, out betweenNums) || betweenNums > maxNum || betweenNums < minNum)
                {
                    Console.WriteLine($"Försök igen. Siffran måste vara mellan {minNum} och {maxNum}");
                    inBetween = Console.ReadLine();
                }
                arrayList[k] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Efter while-loopen");

            
            
            Array.Reverse(arrayList);
            Console.WriteLine();
            for (int l = 0; l < parseString; l++)
            {
                Console.WriteLine($"{arrayList[l]}");
            }
            
            // Skapa en array för det valde värdet.
            int arrayInput = Convert.ToInt32(arraySize);
            int[] arrayInputs = new int[arrayInput];
            


            //for (int i = 0; i < arrayInput; i++)
            //{

            //    Console.WriteLine("Hej");
            //    //arrayInputs[i] = Console.ReadLine();
            //}
            //for (int j = 0; j < arraySize.Length; j++)
            //{
            //    Console.WriteLine($"\n{arrayInputs}");
            //}
            
            //int[] array = new int[userInput];


        }
    }
}
