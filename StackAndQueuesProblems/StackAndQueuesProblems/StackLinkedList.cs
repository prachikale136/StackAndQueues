using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuesProblems
{
    internal class StackLinkedList
    {
        public Node Top;
        public void Push(int data)
        {
            Node node = new Node( data);
            if(this.Top == null) 
            {
                node.Next = null;
            }
            else 
            {
                node.Next = this.Top;
                this.Top = node;
            }
            Console.WriteLine("{0} pushes to stack", data );
        }

        public void Display()
        {
            Node temp = this.Top;
            while(temp != null ) 
            {
                
                temp = temp.Next;
                Console.WriteLine(temp.Data + " ");
            }
        }
    }
}
