using System;
using System.Collections.Generic;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, byte> groups = new Dictionary<string, byte>();

            groups.Add("P123", 84);
            groups.Add("P124", 94);
            groups.Add("P125", 54);
            groups.Add("P126", 14);

            foreach (KeyValuePair<string,byte> item in groups)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("Group secin:");
            string groupNo = Console.ReadLine();

            if(groups.ContainsKey(groupNo))
             Console.WriteLine(groups[groupNo]);
            else Console.WriteLine("Qrup nomresi yanlisdir");



            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                Name = "Hikmet",
                GroupNo = "P123",
                Point = 66
            });
            students.Add(new Student
            {
                Name = "Abbas",
                GroupNo = "P124",
                Point = 86

            });
            students.Add(new Student
            {
                Name = "Nermin",
                GroupNo = "P123",
                Point = 90
            });
            students.Add(new Student
            {
                Name = "Tofiq",
                GroupNo = "P220",
                Point = 63
            });


            foreach (Student std in students)
            {
                Console.WriteLine($"{std.Name} - {std.Point}");
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Point < 65)
                {
                    students.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("===================");

            foreach (Student std in students)
            {
                Console.WriteLine($"{std.Name} - {std.Point}");
            }


        }
    }
}
