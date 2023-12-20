using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Xml.Linq;

namespace Task3
{

    public class Student : Person
    {



       


        public string name { get => _name; set => _name = value; }
        public string[] _subjects;
       


        public Student(string name, string[] subjects) : base(name)
        {
            _name = name;
            _subjects = subjects;
            


        }


        
        
        
        public override void PrintDetails()
        {
            Console.WriteLine($"Hi my name is {_name} and I am studying {_subjects[0]}, {_subjects[1]}, {_subjects[2]}");
        }

    }
}
