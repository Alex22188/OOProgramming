using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Person 
    {




        protected string _name { get; set; }

       
            
            
            
        public Person(string name) 
        {
            _name = name;

        }












        public abstract void PrintDetails();

    }

}
    
   

