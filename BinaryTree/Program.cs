using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(200);
            binaryTree.Add(180);
            binaryTree.Add(220);
            binaryTree.Add(230);
            binaryTree.Add(202);
            binaryTree.Add(170);
            binaryTree.Add(160);
            binaryTree.Search(160);
        }
    }
}
