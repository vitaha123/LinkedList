using System;

namespace LinkedList
{
    public class DoubleLinkedList
    {
        DNode head;
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
            DNode newNode = new DNode(data);
            newNode.next = this.head;
            newNode.prev = null;
            
            if (this.head != null)
            {
                this.head.prev = newNode;
                nodeCount++;
            }
            
            this.head = newNode;
            
        }
        
        public void InsertLast(string data)
        {
            DNode newNode = new DNode(data);
            if (this.head == null)
            {
                newNode.prev = null;
                this.head = newNode;
                nodeCount++;
                return;
            }

            DNode lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
            nodeCount++;
        }

        public DNode GetLastNode()
        {
            DNode temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
        
        public void InsertAfter(DNode prev_node, string data)  
        {  
            if (prev_node == null) {  
                Console.WriteLine("The given prevoius node cannot be null");  
                return;  
            }  
            DNode newNode = new DNode(data);  
            newNode.next = prev_node.next;  
            prev_node.next = newNode;  
            newNode.prev = prev_node;  
            if (newNode.next != null) {  
                newNode.next.prev = newNode;
                nodeCount++;
            }
            
        }
         
        public DNode ContainsString(string key)
        {
            DNode tmp = head;
            DNode prev = null; 
            if (tmp != null && tmp.data == key)
            {
                return tmp;
            }

            while (tmp != null )
            {
                if (tmp.data == key) return tmp;
                prev = tmp;  
                tmp = tmp.next;
            }
            return null;
        }
         
        public string[] GetArrayValueStrings()
        {
            DNode tmp = head;
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
        
        public void DeleteNodebyKey( string key)  
        {  
            DNode temp = this.head;  
            if (temp != null && temp.data == key) {  
                this.head = temp.next;  
                this.head.prev = null;  
                return;  
            }  
            while (temp != null && temp.data != key) {  
                temp = temp.next;  
            }  
            if (temp == null) {  
                return;  
            }  
            if (temp.next != null) {  
                temp.next.prev = temp.prev;  
            }  
            if (temp.prev != null) {  
                temp.prev.next = temp.next;  
            }
            nodeCount--;
        }  
    }
}