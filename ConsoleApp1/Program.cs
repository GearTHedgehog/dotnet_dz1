using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            Console.WriteLine("initial list:");
            list.Add(3); list.Add(1); list.Add(2);
            list.Add(4); list.Add(6); list.Add(11);
            list.Add(9); list.Add(12); list.Add(10);
            list.Add(5); list.Add(7); list.Add(2);
            list.Print();
            Console.WriteLine("adding to beginning:");
            list.AddBegin(0);
            list.InsertionSort();
            list.Print();
            list.Add(3); list.Add(1); list.Add(2);
            list.Add(4); list.Add(6); list.Add(11);
            list.Add(9); list.Add(12); list.Add(10);
            list.Add(5); list.Add(7); list.Add(2);
            list.InsertionSort();
            list.Print();
            /* BinaryTree tree = new BinaryTree();
             tree.Add(19); tree.Add(21); tree.Add(18); tree.Add(178);
             tree.Print();
             Console.WriteLine();
             TreeNode node = tree.Search(18);
             node.Print();
             Console.WriteLine();
             tree.Delete(20);
             tree.Print();*/
            /* CustomList list = new CustomList();
             Console.WriteLine("initial list:");
             list.Add(1); list.Add(2); list.Add(3);
             list.Print();
             Console.WriteLine("adding to beginning:");
             list.AddBegin(0);
             list.Print();
             Console.WriteLine("reversing list:");
             list.Reverse();
             list.Print();
             Console.WriteLine("deleting:");
             list.Delete(228);
             list.Print();
             Console.WriteLine();
             list.Delete(228);
             list.Print();
             Console.WriteLine();
             list.Delete(228);
             list.Print();
             Console.WriteLine();
             list.Delete(4);
             list.Print();*/

        }
    }
}