using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        private int _id;    
        public int Id { get; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public string[] Lessons=new string[0];
    }
}
