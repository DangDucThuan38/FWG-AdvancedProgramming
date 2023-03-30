using System;

namespace OPPInheritance // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student();
            s.ShowInfor();
            Student s2= new Student("Mike Mida",20);
            s2.ShowInfor();
        }
    }
}
