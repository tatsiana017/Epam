using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string name;
        public string university;
        public string facultet;
        public int groupnum;
        public int noteM;
        public int noteI;
        public int srbal;
        public Student(string n, string u, string f, int gn, int nM, int nI, int sr)
        {
            name = n;
            university = u;
            facultet = f;
            groupnum = gn;
            noteM = nM;
            noteI = nI;
            srbal = sr;
        }
        public void Info()
        {
            Console.WriteLine("{0}, {1} group, {2} average csore ", name, groupnum, srbal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string u, f, nm; int g, m, inf, sr;
            Console.WriteLine("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] st = new Student[n];
            for (int i=0; i<n; i++)
            {
                
                Console.WriteLine("Enter fio: ");
                nm = Console.ReadLine();
                Console.WriteLine("Enter university: ");
                u = Console.ReadLine();
                Console.WriteLine("Enter faculty: ");
                f = Console.ReadLine();
                Console.WriteLine("Enter number of group: ");
                g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the mathematics score: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the physics score: ");
                inf = Convert.ToInt32(Console.ReadLine());
                sr = (m + inf) / 2;
            }
            Console.WriteLine("Enter group:");
            int x = Convert.ToInt32(Console.ReadLine());

            
            
        }
    }
    
    
}
    