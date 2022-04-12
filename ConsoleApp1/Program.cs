using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("personun name daxil edin");
            p1.Name=Console.ReadLine();
            Console.WriteLine("personun surname daxil edin");
            p1.Surname = Console.ReadLine();
            int age1;
            do
            {
                Console.WriteLine("personun age daxil edin :");
                age1=Convert.ToInt32(Console.ReadLine());
            } while (age1 <= 0);
            int Experience;
            do
            {
                Console.WriteLine("teacherin Experience daxil edin :");
                Experience=Convert.ToInt32(Console.ReadLine()); 
            }while (Experience < 0|| Experience>= 80);
            Group group=new Group();
            group.AddStudent("azad");
            group.AddStudent("kenan");
            group.AddStudent("hesen");
            group.AddStudent("kamran");
            foreach (var item in group.students)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        } 

    }
}
