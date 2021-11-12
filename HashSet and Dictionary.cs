using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        class Employee
        {
            public string name { get; set; }
            public int id { get; set; }
            public string department { get; set; }

            public Employee(string name, int id, string department)
            {
                this.name = name;
                this.id = id;
                this.department = department;
            }
        }

        public class CustomLinkedList
        {
            public Node head;
            public class Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }

            public Boolean HasCycle()
            {
                HashSet<Node> nodes = new HashSet<Node>();
                Node current = head;
                while (current != null)
                {
                    if (nodes.Contains(current))
                    {
                        return true;
                    }
                    else
                    {
                        nodes.Add(current);
                    }

                    current = current.next;
                }

                return false;
            }
        }

        static List<int> FindMissingElement(int[] first, int[] second)
        {
            List<int> missingElement = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach (int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                    missingElement.Add(item);
            }

            return missingElement;
        }

        static void DisplayFrequencyOfEachElement(int[] array)
        {
            Dictionary<int, int> freqDict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (freqDict.ContainsKey(array[i]))
                {
                    freqDict[array[i]]++;
                }
                else
                {
                    freqDict[array[i]] = 1;
                }
            }

            foreach (KeyValuePair<int, int> x in freqDict)
            {
                Console.WriteLine(x.Key + "->" + x.Value);
            }
        }

        static void Main(string[] args)
        {
            //Dictionary
            Employee emp = new Employee("Bobby", 9415, "Technology");
            Employee emp2 = new Employee("Robby", 3827, "Marketing");
            Employee emp3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> empById = new Dictionary<int, Employee>();
            empById.Add(emp.id, emp);
            empById.Add(emp2.id, emp2);
            empById.Add(emp3.id, emp3);

            Employee e;
            if (empById.TryGetValue(9415, out e))
            {
                Console.WriteLine(e.name + ":" + e.department);
            }

            //HashSet
            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("8F26B");
            productCodes.Add("OA43P");
            productCodes.Add("J2H762");

            Console.WriteLine($"Product Code 48DB9 exist - {productCodes.Contains("48DB9")}");
            Console.WriteLine($"Product Code J2H762 exist - {productCodes.Contains("J2H762")}");

            //Find item present in first array but not in second array - membership
            FindMissingElement(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 }).ForEach(Console.WriteLine);

            //Display the count of each element in an unsorted array
            DisplayFrequencyOfEachElement(new int[] { 3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 });

            //Detect a cyclic linked list
            CustomLinkedList nocycleLinkedList = new CustomLinkedList();
            CustomLinkedList.Node firstNode = new CustomLinkedList.Node(3);
            CustomLinkedList.Node secondNode = new CustomLinkedList.Node(4);
            CustomLinkedList.Node thirdNode = new CustomLinkedList.Node(5);
            CustomLinkedList.Node fourthNode = new CustomLinkedList.Node(6);

            nocycleLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine($"Has Cycle - {nocycleLinkedList.HasCycle()}");

            CustomLinkedList cycleLinkedList = new CustomLinkedList();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine($"Has Cycle - {cycleLinkedList.HasCycle()}");

            Console.ReadKey();
        }
    }
}
