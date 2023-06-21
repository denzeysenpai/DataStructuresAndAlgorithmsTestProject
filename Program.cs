namespace DataStructuresAndAlgorithmsTestProject
{
    internal class Program
    {
        static void Main(string[] args) // MAIN 
        {
            void AnimateTextDisplay(string txt)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    Console.Write(txt[i]);
                    Thread.Sleep(40);
                }
                Console.WriteLine();
            }
            Program Test = new Program();

            Console.ForegroundColor = ConsoleColor.Green;
            AnimateTextDisplay("DATA STRUCTURES AND ALGORITHMS TESTING GROUND");
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t");
            AnimateTextDisplay("PLEASE SELECT A CONCEPT TO TEST");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tArrays \t[0]\n\t\tLists \t[1]\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Choice: ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                switch (choice)
                {
                    case 0: Test.Arrays(); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("THAT IS NOT IN THE CHOICES OR HAS NOT BEEN IMPLEMENTED YET"); break;
                }
            }
            catch (Exception) {/**/}
            Console.ReadKey();
        }

        void Arrays()
        {
            void DisplayArray(Array arr)
            {
                foreach (var item in arr)
                {
                    Console.Write(item.ToString() + ", ");
                }
            }


            //basic
            string[] arrayOfNames = new string[] { "Lorem", "Ipsum" };


            //other
            int[] arrayOfAges = new int[2]; // string[n] where n reserves a memory of that type
            arrayOfAges[0] = 19;
            arrayOfAges[1] = 20;

            void TryException() =>
                arrayOfAges[2] = 30; // this line causes an error because it exceeds the given n
            // and causes a System.IndexOutOfRangeException

            //initialization during declaration
            int[] arrayOfNumbers = new int[8];
            arrayOfNumbers[0] = 1;
            arrayOfNumbers[1] = 2;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 4;
            arrayOfNumbers[4] = 5;
            arrayOfNumbers[5] = 6;


            void TestCopyTo()
            {
                arrayOfAges.CopyTo(arrayOfNumbers, 6);
                DisplayArray(arrayOfNumbers);
            }

            void TestAppend()
            {
                arrayOfNames = arrayOfNames.Append("Cass").ToArray();
                DisplayArray(arrayOfNames);
            }

            void TestResize()
            {
                // arr has a default size of 2
                string[] arr = new string[] { "Ell", "Cass" };

                // resize to add more
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = "Bast";
                DisplayArray(arr);
            }

            TestResize();
        }
    }
}