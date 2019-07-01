using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    static class StudentManager
    {
        public static List<Student> Students = new List<Student>();
        //public static List<Student> StudentsWithMaxGradesAverage = new List<Student>();

        private static double GetMaxGradesAverage()
        {
            double maxGrade = 0;

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].GradesAverage >= maxGrade)
                {
                    maxGrade = Students[i].GradesAverage;
                }
            }

            return maxGrade;
        }

        public static void GetStudentsWithMaxGradesAverage()
        {
            Console.WriteLine("List of students with the max grade:");
            foreach (Student student in Students)
            {
                if (student.GradesAverage == GetMaxGradesAverage())
                {
                    Console.WriteLine($"Student {student.Name} has the max grade of {student.GradesAverage}.");
                }
            }
        }
    }
}
