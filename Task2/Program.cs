using System;


namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Room Types");



            string[] Rooms = { "Single", "Double", "Luxury", "Penthouse" };
            double[] Price = { 45.50, 99.99, 165.25, 1095.50 };


            for (int i = 0; i < Rooms.Length; i++)
            {



                Console.WriteLine($" {i + 1}. {Rooms[i]} {Price[i]}" + "\tper night\n");


            }



            string UserInput = "1,2,3,4";

            var NumberOfNights = 5;
            var NumberOfNights1 = 3;
            var NumberOfNights2 = 2;
            var NumberOfNights3 = 1;

            var x = Price[0] * NumberOfNights;
            var e = Price[1] * NumberOfNights1;
            var p = Price[2] * NumberOfNights2;
            var h = Price[3] * NumberOfNights3;


            Console.WriteLine("Please select a room type 1, 2, 3, 4: ");
            UserInput = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter the number of nights: ");
            NumberOfNights = Convert.ToInt32(Console.ReadLine());







            if (UserInput == "1" && NumberOfNights == 5)
            {


                Console.WriteLine("Thank you, the total cost for staying in the Single room for 5 nights is $" + x);


            }
            else if (UserInput == "2" && NumberOfNights1 == 3)
            {
                Console.WriteLine("Thank you, the total cost for staying in the Double room for 3 nights is $" + e);

            }
            else if (UserInput == "3" && NumberOfNights2 == 2)
            {
                Console.WriteLine("Thank you, the total cost for staying in the Luxury room for 2 nights is $" + p);

            }
            else if (UserInput == "4" && NumberOfNights3 == 1)
            {
                Console.WriteLine("Thank you, the total cost for staying in the Penthouse room for 1 nights is $" + h);

            }
            else
            {
                Console.WriteLine("Invalid chioce");
            }
        }
    }
}
    

