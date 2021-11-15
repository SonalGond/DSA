using System;

namespace Tree
{
    class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                }
                else
                {
                    if (root.Data > value)
                    {
                        root.Left = Insert(root.Left, value);
                    }
                    else if (root.Data < value)
                    {
                        root.Right = Insert(root.Right, value);
                    }
                }
                return root;
            }

           public static Boolean Contains(Node root, int value)
            {
                if (root == null)
                {
                    return false;
                }
                else if (value < root.Data)
                {
                    return Contains(root.Left, value);
                }
                else if (value > root.Data)
                {
                    return Contains(root.Right, value);
                }

                return true;
            }
        }

        static void PreorderTraversal(Node root)
        {
            if(root == null)
            {
                return;
            }
            Console.WriteLine(root.Data + "");
            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);
        }

        static void InorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            InorderTraversal(root.Left);
            Console.WriteLine(root.Data + "");
            InorderTraversal(root.Right);
        }

        static void PostorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostorderTraversal(root.Left);           
            PostorderTraversal(root.Right);
            Console.WriteLine(root.Data + "");
        }

        

        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 1);
            BinarySearchTree.Insert(rootNode, 8);
            BinarySearchTree.Insert(rootNode, 9);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 6);

            //Pre-order
            Console.WriteLine("Pre-order");
            PreorderTraversal(rootNode);


            //In-order
            Console.WriteLine("In-order");
            InorderTraversal(rootNode);

            //Post-Order
            Console.WriteLine("Post-order");
            PostorderTraversal(rootNode);

            //Binary search algo to searcg a node in Binary search tree
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 6));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 2));

            Console.WriteLine(BinarySearchTree.Contains(rootNode, 0));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -4));
            Console.WriteLine(BinarySearchTree.Contains(null, 4));

            Console.ReadKey();
        }
    }
}
