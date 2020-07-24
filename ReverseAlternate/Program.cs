using System;

namespace ReverseAlternate
{
    class Program
    {
        static int numberInput;
        static void Main(string[] args)
        {
            Console.WriteLine("Input String\n");
            string stringInput = Console.ReadLine();

            Console.WriteLine("\nEnter input number \n");
            numberInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nReverse : {0}", AlternateReverse(stringInput));
            Console.ReadKey();
        }



        static string AlternateReverse(string stringInput)
        {
            int startIndex = 0;
            while((startIndex+numberInput) <= stringInput.Length)
            {
                stringInput = Reverse(stringInput, startIndex);
                startIndex += 2 * numberInput;
            }
            return stringInput;
        }

        static string Reverse(string stringInput, int startIndex)   
        {
            char[] stringArray = stringInput.ToCharArray();

            int endIndex = startIndex + numberInput - 1;

            for(int i = 0;i<numberInput;i++)
            {
                stringArray[startIndex] = stringInput[endIndex];
                startIndex++;
                endIndex--;
            }
            
            return new string(stringArray);
        }


    }

}
