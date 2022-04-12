using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher:Person
    {
        private int _experience;
        private int _id;    
        public int  Id { get; }
        public Teacher()
        {
            _id++;
            Id = _id;
        }
        public int Experience
        {
            get => _experience;
            set
            {
                if(value > 0 && value < 80)
                {
                    _experience = value;
                }
            }
        }
    }
}
