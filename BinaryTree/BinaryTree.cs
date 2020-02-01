using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree 
    {

        //Member Variables (HAS A)
        public Node root;

        //Constructor


        //Member Methods (CAN DO)
        public bool Search(int value)
        {
            if (root == null)
            {
                return false;
                
               
            }
            Node current = root;
            while (true)
            {
                if (value == current.value)
                {
                    return true;
                }
                else if (value >= current.value)
                {
                    if(current.RightChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current.RightChild = current;

                    }
                }
                else
                {
                    if (current.LeftChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current.LeftChild = current;

                    }
                    
                }
            }
            

        }
        public void Add(int value)
        {
            Node current;
            if (root == null)
            {
                root = new Node(value);
                //root.data = value;
                Console.WriteLine("The tree root is "+ value);
                Console.ReadLine();
            }
            
            else
            {
                current = root;

                while (true)
                {
                    if (value >= current.value)
                    {
                        if (current.RightChild == null)
                        {
                            current.RightChild = new Node(value);
                            Console.WriteLine("New rightchild is " + current.RightChild.value);
                            break;
                        }
                        else
                        {
                            current = current.RightChild;
                        }
                    }
                    else
                    {
                        if (value <= current.value)
                        {
                            if (current.LeftChild == null)
                            {
                                current.LeftChild = new Node(value);
                                Console.WriteLine("New leftchild is " + current.LeftChild.value);
                                break;
                            }
                            else
                            {
                                current = current.LeftChild;
                            }
                        }

                    }
                }
               
            }
           
            Console.ReadLine();

        }
       
    }
}
