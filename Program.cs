namespace cSharp_binaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = null;

            root = Insert(root, 7);
            root = Insert(root, 5);
            root = Insert(root, 3);
            root = Insert(root, 10);
            root = Insert(root, 9);
            root = Insert(root, 20);
            root = Insert(root, 2);
            root = Insert(root, 4);

            Console.WriteLine("In Order");
            InOrder(root);
            Console.WriteLine();
            Console.WriteLine("Pre Order is");
            PreOrder(root);
            Console.WriteLine();
            Console.WriteLine("Post Order is");
            PostOrder(root);
        }
        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (data < root.Data)
            {
                root.Left = Insert(root.Left, data);
            }
            else
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }
        static void InOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
        
        static void PreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write( root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        static void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}
