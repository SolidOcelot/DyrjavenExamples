using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Ivan Petrov", 5);
            Student st2 = new Student("Alexander Ivanov", 4.5);
            Student st3 = new Student("Dimityr Petrov", 5.5);
            Student st4 = new Student("Yoana Simeonova", 5.5);

            StudentManager.GetStudentsWithMaxGradesAverage();
        }
    }
}
