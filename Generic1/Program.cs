namespace Generic1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Sum<int>(ref a,ref b);
            string c = "Son";
            string d = "Quynh";
            Sum<string>(ref c,ref d);
            Class1<int> class1 = new Class1<int>(5);
            class1.ToString();

        }
        public static void Sum<T>(ref T a, ref T b)
        {
            Console.WriteLine(a); Console.WriteLine(b);
        }
    }
}
