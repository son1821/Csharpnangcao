using System.Text;

namespace List1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            //truy xuất phần tử
            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }
            //Xuất số lượng phần tử
            Console.WriteLine("\nSố lượng phần tử là: "+numbers.Count);
            Console.WriteLine();
            //truy xuất phần tử index
            int number2 = numbers[2];
            Console.WriteLine("Phần tử số 2 là:  "+number2);
            Console.WriteLine();
            //kiểm tra phần tử có tồn tại hay không
            bool numberBool = numbers.Contains(5);
            if(!numberBool)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Tìm thấy");
            }
            Console.WriteLine();
            //Xoá phần tử
            numbers.Remove(4);
            Console.Write("Danh sách phần tử sau khi xoá: ");
            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            //Xoá tất cả phần tử
            numbers.Clear();
            Console.WriteLine("\nSố phần tử sau khi xoá là: "+numbers.Count);
            Console.Read();
        }
      
    }
}
