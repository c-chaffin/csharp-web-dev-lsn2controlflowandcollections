using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID Number: ");
                    input = Console.ReadLine();
                    int newIdNumber = int.Parse(input);
                    students.Add(newIdNumber, newStudent);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + " (" + student.Key + ")");
            }
        }
    }
}
