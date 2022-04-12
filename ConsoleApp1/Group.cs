using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        public string GroupNo;
        public string[] students=new string[0];  
        public void AddStudent(string student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length-1]=student;
        }
    }
}
