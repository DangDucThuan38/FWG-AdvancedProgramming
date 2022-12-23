using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStartgery
{
    public class Class
    {
        private List<Student> students;
        private ISortable sorter;

        public Class(ISortable sorter)
        {
            students = new List<Student>();
            this.sorter = sorter;
        }

        public void ChangSorter(ISortable sorter)
        {
            this.sorter = sorter;
        }
        public void Show()
        {
            sorter.Sort(students);
            foreach (Student s in students)
            {
                Console.WriteLine(s);

            }

        }
        public void AddStudent(Student s)
        {
            students.Add(s);

        }
    }
}