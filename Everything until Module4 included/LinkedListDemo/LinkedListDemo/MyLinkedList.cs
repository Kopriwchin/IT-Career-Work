using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class MyLinkedList<T>
    {
        public class Node<T>
        {
            private T value;
            private Node<T> next;
            public Node(T value, Node<T> prevNode)
            {
                this.value = value;
                prevNode.next = this;
            }
            public Node(T value)
            {
                this.value = value;
                next = null;
            }
            public T Value { get => value; set => this.value = value; }
            public Node<T> Next { get => next; set => next = value; }
        }

        private Node<T> head;
        private Node<T> tail;
        private int count;

        public MyLinkedList(){}

        public void Add(T value)
        {
            Node<T> newNode;
            if (head == null)
            {
                newNode = new Node<T>(value);
                this.head = newNode;
                this.tail = newNode;
            }
            else 
            {
                newNode = new Node<T>(value, tail);
                tail = newNode;
            }
            count++;
        }

        public bool Contains(T value)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return true;
        }
    }
}
