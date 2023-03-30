
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        // attribute: List<Student> students
        public string Name { get;set;}
       private List<Student> students;

        // default constructor
        public School(string name)
        {
            Name =name;
            students= new List<Student>();
        }
    
        // Enroll(): enroll student
       public void Enroll()
       {
        System.Console.Write("Enter name student: ");
        string name= Console.ReadLine();
        System.Console.Write("Enter Age: ");
        int age=int.Parse(Console.ReadLine());
        System.Console.Write("Enter Grade: ");
        double grade = double.Parse(Console.ReadLine());
        Student s= new Student(name,age,grade);
        students.Add(s);
       }

        // DropOupt(): drop out student
        public void DropOupt()
        {
            System.Console.Write("Enter ID Studnet: ");
            int ID= int.Parse(Console.ReadLine());

            Student s=FindByID(ID);
            if(s==null)
            {
                System.Console.WriteLine("Student not Found");
            }else
            {
                students.Remove(s);
                System.Console.WriteLine("Student Removed");
            }
        }

        public Student FindByID(int ID)
        {
            foreach (Student s in students)
            {
                if(s.ID==ID)
                return s;

                
            }
            return null;

        }

        public void ShowStudents()
        {
            System.Console.WriteLine("List of students");
            ShowInfor();
            
        }
        public void ShowInfor()
        {
            foreach (Student s in students)
            {
                 System.Console.WriteLine("ID: "+s.ID+"|Name: " + s.Name+"|Age: " + s.Age+"|Grade: " +s.Grade +" |School: " + Name);
            }

        }





        // ShowStudents(): show all students   


    }
}