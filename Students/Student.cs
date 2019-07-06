namespace Students
{
    class Student
    {
        public string Name { get; set; }
        public double GradesAverage { get; set; }

        public Student(string name, double gradesAverage)
        {
            this.Name = name;
            this.GradesAverage = gradesAverage;

            StudentManager.Students.Add(this);
        }
    }
}
