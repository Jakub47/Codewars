using CollectionLib;
using MathLib;
using StringLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegexLib;

namespace CodewarsConsole
{
    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }

    class Program
    {
        /// <summary>
        /// Main Entry point
        /// </summary>
        /// <param name="args">argumnents</param>
        static void Main(string[] args)
        {
            ////StringLen pM = new StringLen();
            ////Console.WriteLine(pM.Likes(new string[] { "Peter" }));
            //string kk = M(new Node(1,null));
            //Console.WriteLine(kk);

            StringReplace pM = new StringReplace();
            Console.WriteLine(pM.ToCamelCase(""));
            Console.ReadKey();
        }

        static string M(Node list)
        {
            if (list == null) return "null";
            StringBuilder sB = new StringBuilder();
            sB.Append(list.Data + " -> ");

            Node m = list.Next;
            while(m != null)
            {
                sB.Append(m.Data + " -> ");
                m = m.Next;
            }

            return sB.Append("null").ToString();
        }
    }
}
