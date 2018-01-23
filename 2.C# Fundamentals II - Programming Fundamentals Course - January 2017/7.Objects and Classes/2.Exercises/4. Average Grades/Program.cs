namespace _4.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var Students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                var currentInput = Console.ReadLine().Split().ToList();
                var currentStudent_Grades = new List<double>();
                for (int j = 1; j < currentInput.Count; j++)
                {
                    currentStudent_Grades.Add(double.Parse(currentInput[j]));
                }
                Students[i] = new Student()
                {
                    Name = currentInput[0],
                    Grades = currentStudent_Grades
                };
            }

            var bestStudents = Students
                .Where(x => x.Average >= 5.0)
                .Select(x => x.Name).Distinct()
                .OrderBy(x => x)
                .ToArray();
            foreach (var student in bestStudents)
            {
                var averageGrades = Students
                    .Where(x => x.Name == student && x.Average >= 5.0)
                    .Select(x => x.Average)
                    .OrderByDescending(x => x)
                    .ToArray();
                foreach (var averageGrade in averageGrades)
                {
                    Console.WriteLine($"{student} -> {averageGrade:F2}");
                }
            }
        }
    }
}
