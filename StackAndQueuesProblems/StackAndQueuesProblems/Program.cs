namespace StackAndQueuesProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            StackLinkedList stackLinkedList= new StackLinkedList();
            stackLinkedList.Push(56);
            stackLinkedList.Push(30);
            stackLinkedList.Push(70);
            stackLinkedList.Display();
            stackLinkedList.Peek();
            stackLinkedList.Pop();
        }
    }
}