using System;
using System.Net.Sockets;

namespace LinkedList
{
    public class SingleLinkedList
    {
        private Node head;
        private int nodeCount = 0;
        public int Length
        {
            get
            {
                return nodeCount;
            }
        }
        public void InsertFront(string data)
        {
            Node new_node = new Node(data);
            new_node.next = this.head;
            this.head = new_node;
            nodeCount++;
        }

        public void InsertLast(string new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
                nodeCount++;
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.next = new_node;
            nodeCount++;
        }

        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

        public void InsertAfter(Node prev_node, string new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }

            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
            nodeCount++;
        }

        public Node ContainsString(string key)
        {
            Node tmp = head;
            Node prev = null;
            if (tmp != null && tmp.data == key)
            {
                return tmp;
            }

            while (tmp != null)
            {
                if (tmp.data == key) return tmp;
                prev = tmp;
                tmp = tmp.next;
            }

            return null;
        }

        public string[] GetArrayValueStrings()
        {
            Node tmp = head;
            string[] strings = new string[nodeCount];
            if (tmp == null) return null;
            int count = 0;
            while (tmp != null)
            {
                strings[count] = tmp.data;
                tmp = tmp.next;
                count++;
            }

            return strings;
        }

        public void DeleteNodebyKey(string key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                this.head = temp.next;
                return;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;
            nodeCount--;
        }
    }
}