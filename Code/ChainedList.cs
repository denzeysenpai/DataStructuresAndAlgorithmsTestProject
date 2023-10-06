using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsTestProject.Code
{
    public class ChainedList
    {
        public Node Head { get; set; }

        public void CreateNewHead(int data)
        {
            // create the new node
            Node newHead = new Node();
            // put data in the node
            newHead.Data = data;
            // put the old head node as the reference for new head
            newHead.Next = Head;

            // reassign new head
            Head = newHead;
        }

        public Node DeleteCurrentHead()
        {
            // temporary variable
            Node newHead = Head;
            // change reference
            Head = Head.Next;
            // return old head
            return newHead;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating... ");
            Node currentNode = Head;
            while (currentNode != null)
            {
                // display
                currentNode.DisplayNodeData();
                // iterate
                currentNode = currentNode.Next;
            }
        }

        public void ReverseList()
        {
            Node previous = Head;
            Node currentNode = Head.Next;
            Node nextNode = currentNode.Next;

            previous.Next = null;
            while (true)
            {
                currentNode.Next = previous;
                previous = currentNode;
                currentNode = nextNode;
                if (currentNode.Next != null) nextNode = currentNode.Next;
                else
                {
                    // assign new head
                    Head = currentNode;
                    Head.Next = previous;
                    break;
                }
            }
        }

        public void InsertNodeAtLast(int data)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                // iterate
                currentNode = currentNode.Next;
            }

            // create new node
            Node newNode = new Node();

            // assign new node data
            newNode.Data = data;

            // set previous last tail reference for new
            // tail node or last node
            currentNode.Next = newNode;
        }

        public void DeleteLastNode()
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode = null;
        }
    }
}
