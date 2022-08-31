using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];

            MyStringList myStringList = new MyStringList();

            myStringList.Add("salam1");
            myStringList.Add("salam2");
            myStringList.Add("salam3");
            myStringList.Add("salam4");


            foreach (var item in myStringList.Array)
            {
                Console.WriteLine(item);
            }

            MyIntList intMyList = new MyIntList();
            intMyList.Add(1);
            intMyList.Add(10);
            intMyList.Add(3);
            intMyList.Add(14);
            intMyList.Add(17);

            MyHumanList myHumanList = new MyHumanList();

            MyList<string> stringList = new MyList<string>();
            stringList.Add("Hikmet");
            stringList.Add("Abbas");
            stringList.Add("Nermin");
            stringList.Add("Tofiq");

            stringList[0] = "Abdulla";
            Console.WriteLine(stringList[0]);



            //MyList<int> intList = new MyList<int>();
            MyList<Human> humanList = new MyList<Human>();





        }
    }
}
