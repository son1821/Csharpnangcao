using System.Collections;
using System.Collections.Generic;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stack stack1 = new Stack(10);
            Stack stack2 = new Stack(stack1);
            stack.Push("Son");
            stack.Push("Quynh");
            stack.Push("Chau");
            Console.WriteLine("Name: "+stack.Peek());
            Console.Write("So phan tu hien co: " + stack.Count);
            Console.WriteLine();
            int Lenght = stack.Count;
            for(int i = 0; i < Lenght; i++)
            {
                Console.Write(" "+stack.Pop());
            }
            Console.WriteLine("\nSo phan tu hien co: " + stack.Count);
            Console.Read();

        }
    }
}
