using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(45);
            arrayList.Add("salam");
            arrayList.Add(true);

            Console.WriteLine(arrayList[0]);
            arrayList.RemoveAt(1);


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();

            sortedList.Add("12", "Hikmet");
            sortedList.Add("84", "Abbas");
            sortedList.Add("55", "Nermin");
            //sortedList.Add('4', 'a');
            //sortedList.Add(556, 546);


            foreach (var item in sortedList.GetValueList())
            {
                Console.WriteLine(item);
            }


            Stack stack = new Stack();


            stack.Push("salam");
            stack.Push(45);
            stack.Push(true);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Queue queue = new Queue();

            queue.Enqueue(55);
            queue.Enqueue("Hikmet");
            queue.Enqueue(false);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            Hashtable hashtable = new Hashtable();



            Queue<int> genQueue = new Queue<int>();
            genQueue.Enqueue(5);

            Stack<int> genStack = new Stack<int>();
            genStack.Push(45);


            Dictionary<string, int> groupLimits = new Dictionary<string, int>();
            groupLimits.Add("P123", 18);
            groupLimits.Add("P220", 15);
            groupLimits.Add("P132", 18);

            foreach (var item in groupLimits)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }
            Console.WriteLine(groupLimits["P132"]);

            groupLimits.Remove("P132");

            Console.WriteLine(groupLimits.ContainsKey("P124"));


            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(1);
            numbers.Add(10);




            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            List<int> numbersList = new List<int>();

            numbersList.Add(1);
            numbersList.Add(10);
            numbersList.Add(10);
            numbersList.Add(11);
            numbersList.Add(-40);


            Console.WriteLine("List:");
            foreach (var item in numbersList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count1");
            Console.WriteLine(numbersList.Count);
            Console.WriteLine(numbersList.Capacity);



            numbersList.RemoveAt(1);

            numbersList.Remove(10);

            Console.WriteLine("count2");
            Console.WriteLine(numbersList.Count);
            Console.WriteLine(numbersList.Capacity);
        }
    }
}
