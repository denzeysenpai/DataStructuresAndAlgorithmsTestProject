using System.Security.Cryptography;

namespace DataStructuresAndAlgorithmsTestProject
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public void DisplayNodeData() =>
            Console.WriteLine(Data);

    }
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
            while(currentNode != null)
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
                if(currentNode.Next != null) nextNode = currentNode.Next;
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
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode = null;
        }
    }
    internal class Program
    {
        static void Main(string[] args) // MAIN 
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
                Console.WriteLine((i % 2 == 0));
            }
            DivisorGame(n);


            //Node head = new Node();
            //Node nodeA = new Node();
            //Node nodeB = new Node();
            //Node nodeC = new Node();
            //Node nodeD = new Node();

            //head.Data = 0;
            //head.Next = nodeA;

            //nodeA.Data = 1;
            //nodeA.Next = nodeB;

            //nodeB.Data = 2;
            //nodeB.Next = nodeC;

            //nodeC.Data = 3;
            //nodeC.Next = nodeA;

            //bool HasCycle(Node head)
            //{
            //    if (head != null && head.Next != null)
            //    {
            //        List<Node> cont = new List<Node>();
            //        Node a = head;
            //        while (true)
            //        {
            //            cont.Add(a);
            //            a = a.Next;
            //            if (a == null) break;
            //            if (cont.Contains(a)) return true;
            //        }
            //    }
            //    bool outPut = false;
            //    return outPut;
            //}

            //Console.WriteLine(HasCycle(head));
            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddLast(1);
            //numbers.AddLast(2);
            //numbers.AddLast(3);
            //numbers.AddLast(4);
            //numbers.AddLast(5);


            //Func<int, bool> func = new Func<int, bool>((x) => x <= 3);


            //// shorter but takes more memory
            //foreach (int x in numbers.Where((x) => x <= 3)) Console.WriteLine(x);

            //// takes less memory
            //foreach(int num in numbers)
            //{
            //    if (num <= 3) Console.WriteLine(num);
            //}

            //ChainedList chain = new ChainedList();
            //chain.CreateNewHead(10);
            //chain.CreateNewHead(11);
            //chain.CreateNewHead(12);

            //chain.DisplayList();

            //chain.ReverseList();

            //chain.DisplayList();

            //int left = 0;
            //int right = 10;
            //int res = -1;

            //Console.WriteLine((5 + 1) + (10 - (5 + 1)) / 2);



            //int[,,] something = new int[2, 2, 2]
            //{
            //    // [0,n,n] aka notebook 0
            //    {
            //    // [n,n,0] [n,n,1]
            //        { 0   ,   1 }, //[n,0,n]
            //        { 2   ,   3 }  //[n,1,n]
            //    },
            //    // [1,n,n] aka notebook 1
            //    {
            //    // [n,n,0] [n,n,1]
            //        { 4   ,   5 }, //[n,0,n]
            //        { 6   ,   7 }  //[n,1,n]
            //    }
            //};


            //void print(string s) => Console.WriteLine(s);

            //void AnimateTextDisplay(string txt)
            //{
            //    for (int i = 0; i < txt.Length; i++)
            //    {
            //        Console.Write(txt[i]);
            //        Thread.Sleep(40);
            //    }
            //    print("");
            //}
            //Program Test = new();

            //Console.ForegroundColor = ConsoleColor.Green;
            //AnimateTextDisplay("DATA STRUCTURES AND ALGORITHMS TESTING GROUND");
            //print("\n\n");

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("\t");
            //AnimateTextDisplay("PLEASE SELECT A CONCEPT TO TEST");

            //print("\n\n");
            //print("\t\tArrays \t[0]\n\t\tLists \t[1]\n");

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("Choice: ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //int choice = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.White;
            //    switch (choice)
            //    {
            //        case 0: Test.Arrays(); Console.WriteLine("Test case 1"); break;
            //        default:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            print("THAT IS NOT IN THE CHOICES OR HAS NOT BEEN IMPLEMENTED YET"); break;
            //    }
            //}
            //catch (Exception) {/**/}
            //Console.ReadKey();
        }

        //void Arrays()
        //{
        //    void print(object s) =>
        //        Console.WriteLine(s.ToString());

        //    void DisplayArray(Array arr)
        //    {
        //        foreach (var item in arr)
        //        {
        //            Console.Write(item.ToString() + ", ");
        //        }
        //    }

        //    // Declaration
        //    string[] arrayOfSomething;
        //    // then initialization
        //    arrayOfSomething = new string[1];

        //    //basic
        //    string[] arrayOfNames = new string[] { "Lorem", "Ipsum" };

        //    //other
        //    int[] arrayOfAges = new int[2]; // string[n] where n reserves a memory of that type
        //    arrayOfAges[0] = 19;
        //    arrayOfAges[1] = 20;

        //    void TryException() =>
        //        arrayOfAges[2] = 30; // this line causes an error because it exceeds the given n
        //    // and causes a System.IndexOutOfRangeException

        //    //initialization during declaration
        //    int[] arrayOfNumbers = new int[8];
        //    arrayOfNumbers[0] = 1;
        //    arrayOfNumbers[1] = 2;
        //    arrayOfNumbers[2] = 3;
        //    arrayOfNumbers[3] = 4;
        //    arrayOfNumbers[4] = 5;
        //    arrayOfNumbers[5] = 6;


        //    void TestCopyTo()
        //    {
        //        arrayOfAges.CopyTo(arrayOfNumbers, 6);
        //        DisplayArray(arrayOfNumbers);
        //    }

        //    void TestAppend()
        //    {
        //        arrayOfNames = arrayOfNames.Append("Cass").ToArray();
        //        DisplayArray(arrayOfNames);
        //    }

        //    void TestResize()
        //    {
        //        // arr has a default size of 2
        //        string[] arr = new string[] { "Ell", "Cass" };

        //        // resize to add more
        //        Array.Resize(ref arr, arr.Length + 1);
        //        arr[arr.Length - 1] = "Bast";

        //        DisplayArray(arr);
        //    }

        //    void TestMin()
        //    {
        //        string[] arr = new string[2] { "4", "2" };
        //        string? min = arr.Min();

        //        print(min);
        //    }

        //    void TestOrder()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        numbers = numbers.Order().ToArray();

        //        string[] letters = new string[4] { "abc", "ghi", "dfe", "kjo" };
        //        letters = letters.Order().ToArray();

        //        DisplayArray(numbers);
        //        DisplayArray(letters);
        //    }

        //    void TestAll()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        string True = "Array elements is greater than or equal to one";
        //        string False = "Array elements is less than one";
        //        print(numbers.All(x => x >= 1) ? True : False);
        //    }

        //    void TestGetLength()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        print(numbers.GetLength(0).ToString());
        //    }

        //    void TestAverage()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        print(numbers.Average().ToString());
        //    }

        //    void TestRank()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        print(numbers.Rank.ToString());
        //    }

        //    void TestCount()
        //    {
        //        int[] numbers = new int[3] { 1, 3, 2 };
        //        print(numbers.Count().ToString());
        //    }

        //    // Set and Get Value Methods
        //    int[] ids = new int[] { 12, 13, 14 };

        //    void TestSetValue() =>
        //        ids.SetValue(2, 15);
        //    // sets a new value on 3rd index (2)

        //    string TestGetValue()
        //    {
        //        string id = ids.GetValue(2).ToString();
        //        return id;
        //    }


        //    TestSetValue();
        //    Console.WriteLine(TestGetValue());
        //    Console.WriteLine("Test case 2");
        //}
    }
}