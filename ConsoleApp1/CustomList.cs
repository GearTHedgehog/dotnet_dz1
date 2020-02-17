using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ListNode<T> where T:IComparable
    {
        public readonly T Contents;
        public ListNode<T> Next;

        public ListNode(T contents)
        {
            this.Contents = contents;
            Next = null;
        }
    }

    class CustomList<T> where T:IComparable
    {
        private ListNode<T> _head;

        public CustomList()
        {
            _head = null;
        }

        public void AddBegin(T wta)
        {
            ListNode<T> nta = new ListNode<T>(wta);
            nta.Next = _head;
            _head = nta;
        }
        public void Add(T wta)
        {
            ListNode<T> nta = new ListNode<T>(wta);
            if (_head == null)
            {
                _head = nta;
            }
            else
            {
                ListNode<T> cur = _head;
                while (cur.Next != null) cur = cur.Next;
                cur.Next = nta;
            }
        }

        public void Delete(int position)
        {
            if (_head == null)
            {
                Console.WriteLine("nothing to delete");
                return;
            }
            ListNode<T> temp = _head;
            ListNode<T> before = null; 
            for (int i = 0; i <= position - 1 && temp.Next != null; i++)
            {
                before = temp;
                temp = temp.Next;
            }

            if (before == null)
            {
                temp = _head;
                _head = _head.Next;
                temp.Next = null;
            }
            else
            {
                temp = temp.Next;
                before.Next = temp;
            }
        }

        public void Reverse()
        {
            ListNode<T> temp = _head;
            for (int i = 0; temp.Next != null; i++)
            {
                this.AddBegin(temp.Next.Contents);
                this.Delete(i + 2);
            }
        }

        private ListNode<T> FetchFirst()
        {
            return _head;
        }
        public void Print()
        {
            if (_head == null) Console.WriteLine("list empty");
            ListNode<T> cur = _head;
            while (cur != null)
            {
                Console.Write(cur.Contents + " ");
                cur = cur.Next;
            }
            Console.WriteLine();
        }

        public void InsertionSort()
        {
            if (_head == null || _head.Next == null) return;
            CustomList<T> unsortedList = new CustomList<T>();
            ListNode<T> temp = _head;
            while (temp != null)
            {
                ListNode<T> current = temp;
                temp = temp.Next;
                if(unsortedList.FetchFirst() == null || current.Contents.CompareTo(unsortedList.FetchFirst().Contents) < 0) { unsortedList.AddBegin(current.Contents); Delete(0);}
                else
                {
                    ListNode<T> throughSorted = unsortedList.FetchFirst();
                    while (throughSorted != null)
                    {
                        if (throughSorted.Next == null || current.Contents.CompareTo(throughSorted.Next.Contents) < 0)
                        {
                            current.Next = throughSorted.Next;
                            throughSorted.Next = current;
                            break;
                        }
                        throughSorted = throughSorted.Next;
                    }
                }
            }
            _head = unsortedList.FetchFirst();
            /*temp = _head;
            while(temp != null)
            {
                temp = temp.Next;
                Delete(0);
            }
            unsortedList.Print();
            Print();
            temp = unsortedList.FetchFirst();
            while (temp != null)
            {
                Add(temp.Contents);
                temp = temp.Next;
                unsortedList.Delete(0);
            }
            unsortedList.Print();
            Print();*/
        }
    }
}
