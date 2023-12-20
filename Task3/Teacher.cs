using System;
using System.Collections.Generic;




namespace Task3
{





    public class Teacher : Person
    {



        


        public string name { get => _name; set => _name = value; }
        public string _faculty;


        
       

        public Teacher(string name, string faculty) : base(name)
        {

            _name = name;
            _faculty = faculty;


             }

       

    public override void PrintDetails()
        {
            Console.WriteLine($"Hi my name is {_name} and I teach in the {_faculty} faculty");



        }
    }
}