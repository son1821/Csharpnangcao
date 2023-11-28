using System.Collections;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Son");
            queue.Enqueue("Quynh");
            queue.Enqueue("Chau");
            Console.WriteLine("Name: "+queue.Peek());
            Console.WriteLine("So phan tu hien co la: " + queue.Count);
            Console.WriteLine();
            Console.WriteLine("Phan tu dau tien la: " + queue.Dequeue());
            Console.WriteLine("So phan tu hien co la: " + queue.Count);
            Console.ReadLine();
        }
    }
}
