using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Author Farah Farouk
/// </summary>
/// 

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>();

            bool addMore = true;
            while (addMore)
            {
                var student = new Student();

                Console.WriteLine("Name of the student: ");
                student.Name = Console.ReadLine();

                Console.WriteLine("Midterm grade: ");
                student.Midtermgrade = double.Parse(Console.ReadLine());

                Console.WriteLine("Final grade: ");
                student.Finalgrade = double.Parse(Console.ReadLine());

                StudentList.Add(student);

                Console.WriteLine("Would you like to add another student?");
                addMore = bool.Parse(Console.ReadLine());


                using (StreamWriter writer = File.AppendText(@"C:\Temp\Grades.txt"))

                {
                    writer.WriteLine("******The student grade report******");

                     foreach (var item in StudentList)

                     writer.Write("The student's name is {0} , the midterm grade is {1} points, and the final grade is {2} points", item.Name, item.Midtermgrade, item.Finalgrade+".");
                }


                {
                    Console.WriteLine("The student grade report has been created. Please check the file path.");
                }

                Console.ReadLine();

            }
        }
    }
}
