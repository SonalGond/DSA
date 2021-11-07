using System;
using System.Collections.Generic;

namespace LinkedList
{
    class CustomLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }


        public void DeleteBackHalf()
        {
            if (head == null || head.next == null)
            {
                head = null;
            }

            Node prev = null;
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                fast = fast.next.next;
                slow = slow.next;
            }

            prev.next = null;
        }

        public void DisplayContents()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }

            Console.WriteLine();
        }

        public void DeleteKthNodeFromEnd(int k)
        {
            if (head == null || head.next == null)
            {
                return;
            }

            Node first = head;
            Node second = head;

            for (int i = 0; i < k; i++)
            {
                second = second.next;

                if (second.next == null)
                {
                    if (i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }

            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
        }

        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            //AddLast
            //AddFirst
            linkedList.AddLast("Movies");
            linkedList.AddLast("Series");
            linkedList.AddFirst("Genre");
            linkedList.AddFirst("Live Shows");

            //Contains-to check if ceratin piece of data is in the list
            Console.WriteLine($"Linked List - {linkedList.Contains("Netflix")} ");
            Console.WriteLine($"Linked List - {linkedList.Contains("Series")} ");

            //Count no of items
            Console.WriteLine($"Linked List - {linkedList.Count} ");

            //Remove first item from the list
            linkedList.RemoveFirst();

            foreach (string item in linkedList)
            {
                Console.Write(item + "->");
            }

            Console.WriteLine();

            //Custom Linked List
            CustomLinkedList customLinkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);
            Node fifthNode = new Node(7);
            Node sixthNode = new Node(8);
            Node seventhNode = new Node(9);
            Node eighthNode = new Node(10);
            Node ninthNode = new Node(11);
            Node tenthNode = new Node(12);

            customLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
            fourthNode.next = fifthNode;
            fifthNode.next = sixthNode;
            sixthNode.next = seventhNode;
            seventhNode.next = eighthNode;
            eighthNode.next = ninthNode;
            ninthNode.next = tenthNode;

            customLinkedList.DisplayContents();
            customLinkedList.DeleteBackHalf();
            customLinkedList.DisplayContents();


            //Delete Kth Node from end of the list.
            customLinkedList.DisplayContents();
            customLinkedList.DeleteKthNodeFromEnd(2);
            customLinkedList.DisplayContents();


            Console.ReadKey();
        }
    }
}
