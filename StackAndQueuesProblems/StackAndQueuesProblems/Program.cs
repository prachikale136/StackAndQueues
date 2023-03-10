namespace StackAndQueuesProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
            StackLinkedList stackLinkedList= new StackLinkedList();
            stackLinkedList.Push(70);
            stackLinkedList.Push(30);
            stackLinkedList.Push(56);
            stackLinkedList.Peek();
            stackLinkedList.Pop();
            stackLinkedList.Display();
          */
            QueueLinkedList queueLinkedList= new QueueLinkedList();
            queueLinkedList.Enqueue(56);
            queueLinkedList.Enqueue(30);
            queueLinkedList.Enqueue(70);
            queueLinkedList.Display();
            Console.ReadKey();
            
        }
    }
}