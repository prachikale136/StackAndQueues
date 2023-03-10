using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuesProblems
{
    internal class QueueLinkedList
    {
        public Node Head;
        public void Enqueue(int Data)
        {
            Node node = new Node(Data);
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp= Head;
                while (temp.Next != null) 
                {
                    temp = temp.Next;
                }   
                temp.Next = node;
                node.Next = Head;
            }
            Console.WriteLine("{0} inserted into queue", node.Data);
        }

        public void Display()
        {
            Node temp = this.Head;
            if(temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }
    }
}
