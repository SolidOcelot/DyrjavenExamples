using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student st1 = new Student("Ivan Petrov", 5);
            //Student st2 = new Student("Alexander Ivanov", 4.5);
            //Student st3 = new Student("Dimityr Petrov", 5.5);
            //Student st4 = new Student("Yoana Simeonova", 5.5);

            try
            {
                Console.WriteLine("Enter number of students: ");
                int numberOfStudents = Int32.Parse(Console.ReadLine());

                string studentName;
                double studentGrade;

                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.Write("Enter Name: ");
                    studentName = Console.ReadLine();

                    Console.Write("Enter Average Grade: ");
                    studentGrade = double.Parse(Console.ReadLine());

                    Student student = new Student(studentName, studentGrade);
                    Console.WriteLine("Student added.");
                }

                StudentManager.GetStudentsWithMaxGradesAverage();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Try again.");
                Main(args);
            }
        }
    }
}
