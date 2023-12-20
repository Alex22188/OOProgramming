using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;


namespace Task5
{
    class Program
    {





        static void Main(string[] args)
        {

            int[] Numbers = { 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, };






            for (int i = 0; i < Numbers.Length; i++)
            {





                if (Numbers[i] % 3 == 0 && Numbers[i] % 5 == 0)

                {


                    Console.WriteLine($"{Numbers[i]}" + "[3 & 5]");

                }
                else if (Numbers[i] % 3 == 0)
                {

                    Console.WriteLine($"{Numbers[i]}" + "[3]");
                }
                else if (Numbers[i] % 5 == 0)
                {
                    Console.WriteLine(Numbers[i] + "[5]");

                }
                else
                {
                    Console.WriteLine(Numbers[i]);


                }

            }
        }
    }
}


        
    

