using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsTestProject.Code
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public void DisplayNodeData() =>
            Console.WriteLine(Data);

    }
}
