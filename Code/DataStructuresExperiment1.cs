using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsTestProject.Code
{
    internal class DataStructuresExperiment1
    {
        void Arrays()
        {
            void print(object s) =>
                Console.WriteLine(s.ToString());

            void DisplayArray(Array arr)
            {
                foreach (var item in arr)
                {
                    Console.Write(item.ToString() + ", ");
                }
            }

            // Declaration
            string[] arrayOfSomething;
            // then initialization
            arrayOfSomething = new string[1];

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

            void TestMin()
            {
                string[] arr = new string[2] { "4", "2" };
                string? min = arr.Min();

                print(min);
            }

            void TestOrder()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                numbers = numbers.Order().ToArray();

                string[] letters = new string[4] { "abc", "ghi", "dfe", "kjo" };
                letters = letters.Order().ToArray();

                DisplayArray(numbers);
                DisplayArray(letters);
            }

            void TestAll()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                string True = "Array elements is greater than or equal to one";
                string False = "Array elements is less than one";
                print(numbers.All(x => x >= 1) ? True : False);
            }

            void TestGetLength()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                print(numbers.GetLength(0).ToString());
            }

            void TestAverage()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                print(numbers.Average().ToString());
            }

            void TestRank()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                print(numbers.Rank.ToString());
            }

            void TestCount()
            {
                int[] numbers = new int[3] { 1, 3, 2 };
                print(numbers.Count().ToString());
            }

            // Set and Get Value Methods
            int[] ids = new int[] { 12, 13, 14 };

            void TestSetValue() =>
                ids.SetValue(2, 15);
            // sets a new value on 3rd index (2)

            string TestGetValue()
            {
                string id = ids.GetValue(2).ToString();
                return id;
            }


            TestSetValue();
            Console.WriteLine(TestGetValue());
            Console.WriteLine("Test case 2");
        }
    }
}
