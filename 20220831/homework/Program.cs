using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "almalarda";

            var result = word.GetValueIndexes('a');

            int num = 45;
            char letter = 'a';
            string name = "fdf";


            Console.ReadLine();

            Human human = new Human();
            human.Fullname = "fdf";

            Console.WriteLine(human.Fullname);

            Student student;
            student.Name = "hikmet";

            Console.WriteLine(student.Name);
        }
    }
}
