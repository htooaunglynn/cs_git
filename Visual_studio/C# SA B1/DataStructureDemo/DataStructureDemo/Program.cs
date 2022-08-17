using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myData = new ArrayList();
            myData.Add("Su Su");
            myData.Add("Mg Mg");
            myData.Add("Bla Bla");
            myData.Add("Aye Aye");
            myData.Sort();
            myData.Remove(0);
            
            //myData.Add(20);
            // myData.Add(true);
            //syntax of foreach loop
            //foreach(itemType variableName in collectionName)
            foreach (string m in myData)
            {
                Console.WriteLine(m);
            }

            ArrayList number=new ArrayList();
            number.Add(20);
            number.Add(-40);
            number.Add(10);
            number.Add(90);
            number.Add(292);
            number.Sort();
            foreach (int e in number)
            {
                Console.WriteLine(e);
            }

            ArrayList allOfData=new ArrayList();
            allOfData.Add("Yangon");
            allOfData.Add(true);
            allOfData.Add(200);
            allOfData.Add(DateTime.Now);
            foreach (var t in allOfData)
            {
                Console.WriteLine(t);
            }

            IList<int> exam=new List<int>();    
            exam.Add(20);
            exam.Add(90);
            exam.Add(10);
            foreach (var item in exam)
            {
                Console.WriteLine(item);
            }

            List<string> vs=new List<string>();
            vs.Add("la la");
            vs.Add("su su");
           foreach (var i in vs)
            {
                Console.WriteLine(i);
            }

           Stack fbSearch=new Stack();
           fbSearch.Push("New Year Saler in Yangon.");
           fbSearch.Push("New Year Saler in Mandalay.");
           fbSearch.Push("What is happing in US.");

            
            try
            {
                while(fbSearch.Count>0)
                {
                    Console.WriteLine(fbSearch.Peek());
                    fbSearch.Pop();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            Stack stack=new Stack();
            stack.Push("Hello");
            stack.Push("world");
            stack.Push("!");

            Console.WriteLine("stack");
            Console.WriteLine("\tCount: {0}",stack.Count);
            Console.Write("\tValues : ");
            PrintValues(stack);

            Queue ticketQueue = new Queue();
            ticketQueue.Enqueue("First class ticket value 200");
            ticketQueue.Enqueue("Second class ticket value 200");
            ticketQueue.Enqueue("Thisth class ticket value 200");
            ticketQueue.Enqueue("Fourth class ticket value 200");
            ticketQueue.Enqueue("Fiveth class ticket value 200");

            while (ticketQueue.Count>0)
            {
                Console.WriteLine(ticketQueue.Peek());
                ticketQueue.Dequeue();
            }


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (var item in myCollection)
                Console.Write("  {0}",item);

            Console.WriteLine();
        }
    }
}
