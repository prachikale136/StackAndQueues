using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuesProblems
{
    internal class StackLinkedList
    {

        private Node Top;
        
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.Top == null)
                node.Next = null;
            else
                node.Next = this.Top;
            this.Top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.Top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }

        internal void Peek()
        {
            if (this.Top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.Top.Data);
        }

        internal void Pop()
        {
            if (this.Top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.Top.Next);
            this.Top = this.Top.Next;
        }

        internal void IsEmpty()
        {
            while (this.Top != null)
            {
                Peek();
                Pop();
            }
        }

    }
}
