using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsTestProject.Code
{
    internal class LeetCodeExperimentation
    {
        int n = 10;
        void DivisorGame(int n)
        {
            int i = 0;
            for (i = 0; i < n - 1; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(n - 1);
                Console.WriteLine("--------------\n");
            }
            Console.WriteLine(!(i % 2 == 0));


            int m = n;
            for (i = 0; i < m; i++)
            {
                m = m - 1;
                Console.WriteLine(i);
                Console.WriteLine(m);
                Console.WriteLine("--------------\n");
            }
            Console.WriteLine(i % 2 == 0);
        }

        void IsListCycled()
        {
            Node head = new Node();
            Node nodeA = new Node();
            Node nodeB = new Node();
            Node nodeC = new Node();
            Node nodeD = new Node();

            head.Data = 0;
            head.Next = nodeA;

            nodeA.Data = 1;
            nodeA.Next = nodeB;

            nodeB.Data = 2;
            nodeB.Next = nodeC;

            nodeC.Data = 3;
            nodeC.Next = nodeA;

            bool HasCycle(Node head)
            {
                if (head != null && head.Next != null)
                {
                    List<Node> cont = new List<Node>();
                    Node a = head;
                    while (true)
                    {
                        cont.Add(a);
                        a = a.Next;
                        if (a == null) break;
                        if (cont.Contains(a)) return true;
                    }
                }
                bool outPut = false;
                return outPut;
            }

            Console.WriteLine(HasCycle(head));
        }
    }
}
