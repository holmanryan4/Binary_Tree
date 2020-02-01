using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree : Node
    {



        //Member Variables (HAS A)
        public Node root;
        public Node current;


        //Constructor


        //Member Methods (CAN DO)
        public void Search()
        {
           
        }
        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.data = value;
                Console.WriteLine("The tree root is "+ root);
            }

            if (value >= root.data)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = new Node();
                    Console.WriteLine("New leftchild is " + root.LeftChild);
                }
            }
            else
            {
                if (value < root.data)
                {
                    if (root.RightChild == null)
                    {
                        root.RightChild = new Node();
                        Console.WriteLine("New rightchild is " + root.RightChild);

                    }
                }
            }
            
            if (current.data > value)
            {
              current = current.RightChild;
                Console.WriteLine("New rightchild is " + root.RightChild);
            }
            else if(current.data <= value)
            {
                current = current.LeftChild;
                Console.WriteLine("New leftchild is " + root.LeftChild);

            }
            return null;
        }
        
    }
}
