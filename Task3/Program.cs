using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Task3
{ 

 public class Program

{


    
  
    
    


    static void Main(string[] args)
    {

       


        string[] subjects = { "Math", "Science", "English" };
        string studentName = "Sue";
       



        //TODO: 6, instantiate student and add to people collection

        string faculty = "Computer Science";
        string teacherName = "Tim";



        var people = new List<Person>();
        Student myName = new Student(studentName, subjects);
        Student mySubjects = new Student(studentName, subjects);
        Teacher myName1 = new Teacher(teacherName, faculty);
        Teacher myFaculty = new Teacher(teacherName, faculty);
       


        //TODO: 7, instantiate teacher and add to people collection
        
        foreach (var i in people)
            {

                Console.WriteLine(i);
            }
        


        myName.name = studentName;
        mySubjects._subjects = subjects;
        myName1.name = teacherName;
        myFaculty._faculty = faculty;
            



            myName.PrintDetails();
            myName1.PrintDetails();











        }

    }


}
