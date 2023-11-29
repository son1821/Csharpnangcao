using System.Collections.Generic;
using System.Text;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, int> number1 = new Dictionary<int, int>();
            Dictionary<int, int> number2 = new Dictionary<int, int>(6);
            Dictionary<int, int> number3 = new Dictionary<int, int>(number2);
            number1.Add(1, 2);
            number1.Add(3, 4);
            number1.Add(5, 6);
            number1.Add(7, 8);
            Console.WriteLine("So phan tu cua Dictionary la: "+number1.Count);
            Console.WriteLine("Danh sach key trong Dictionary: ");
            ICollection <int> keys = number1.Keys;  
            foreach (int key in keys)
            {
                Console.WriteLine(key);
            }
            int value1 = number1[3];
            Console.WriteLine("Value: {0}",value1);
            bool kiemTra1 = number1.ContainsKey(5);
            if(! kiemTra1)
            {
                 Console.WriteLine("Không tồn tại");

            }
            else
            {
                Console.WriteLine("Tồn tại");
            }
            bool kiemTra2 = number1.ContainsValue(9);
            if (!kiemTra2)
            {
                Console.WriteLine("Không tồn tại");

            }
            else
            {
                Console.WriteLine("Tồn tại");
            }
            number1.Remove(3);
            Console.WriteLine("Danh sách phần tử sau khi xoá là : " );
            foreach (KeyValuePair<int,int> key in number1) {
                Console.WriteLine(key);
            }
            number1.Clear();
            Console.WriteLine("So phan tu cua Dictionary la: " + number1.Count);
            Console.ReadLine();
        }
    }
}