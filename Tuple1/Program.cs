namespace Tuple1
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyTuple = Tuple.Create<int, string>(1, "Son");
            var MyTuple1 = new Tuple<int, int, string>(5, 6,"Quynh");
            bool SoSanh = MyTuple.Equals(MyTuple1);
            if (SoSanh == true)
            {
                Console.WriteLine("Giong nhau");
            }
            else
            {
                Console.WriteLine("Khong giong nhau");
            }
            Console.WriteLine(MyTuple1.ToString()+".... "+MyTuple.ToString());
            var now = GetCurrentDayMorthYear();  
            Console.WriteLine(now.ToString());
            
        }
        static Tuple<int, int, int> GetCurrentDayMorthYear()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
    }
}