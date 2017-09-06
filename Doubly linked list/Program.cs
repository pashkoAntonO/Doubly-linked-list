using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(5);
            list.AddLast(15);
            list.AddLast(30);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(17);
            list.AddFirst(2);

            Console.WriteLine(list.Remove(15));

            Console.WriteLine("Count - {0}", list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
