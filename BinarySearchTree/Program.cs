using BinarySearchTree;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("                              WELCOME TO BINARY SEARCH TREE PROGRAM                              ");
        BST<int> bst = new BST<int>(56);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(22);
        bst.Insert(46);
        bst.Insert(60);
        bst.Insert(95);
        bst.Insert(11);
        bst.Insert(69);
        bst.Insert(3);
        bst.Insert(16);
        bst.Insert(63);
        bst.Insert(87);
        bst.Insert(10);
        bst.Insert(28);
        bst.Insert(94);
        bst.Insert(74);
        bst.Display();
        bool result = bst.IfExists(94, bst);
        Console.WriteLine(result);
    }
}