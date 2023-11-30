using System.Threading;
namespace Multi_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
             Thread t2 = new Thread(() => 
            {
                Demo("New Thread: ");
            });
            t2.IsBackground = true;
            t2.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread: "+ i);
                Thread.Sleep(1000);
            }

        }
       
        public static void Demo(string a) { 
        for (int i = 0; i < 10; i++) {
                Console.WriteLine(a+" "+i);
                Thread.Sleep(TimeSpan.FromSeconds(1));

            }
        }
    }
}
