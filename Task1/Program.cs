using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           

 
   


            double num1 = 0;
            double num2 = 0;
            double Result = 0;




            Console.WriteLine("Please enter a number:");
            num1 = Convert.ToDouble(Console.ReadLine());


            

            Console.WriteLine("Please enter another number:");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please pick an option: [Subtract -, Plus +, Mulitply *, or Division /]");



            switch (Console.ReadLine())
            {



                case "-":
                    Result = num1 - num2;
                    Console.WriteLine($"{num1} Minus {num2} equals " + Result);
                    break;
                case "+":
                    Result = num1 + num2;
                    Console.WriteLine($"{num1} Plus {num2} equals " + Result);
                    break;
                case "*":
                    Result = num1 * num2;
                    Console.WriteLine($"{num1} times {num2} equals " + Result);

                    break;
                case "/":
                    Result = num1 / num2;
                    Console.WriteLine($"{num1} divided {num2} equals " + Result);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
            Console.ReadKey();

        }
    }

}
    

