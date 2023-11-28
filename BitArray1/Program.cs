using System.Collections;

namespace BitArray1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //BitArray bitArray = new BitArray(10);// Mỗi phần tử có giá trị mặc định là 0(False)
            //BitArray bitArray1 = new BitArray(10,true);//Mỗi phần tử có giá trị mặc định là 1(True)
            //bool[] arrayBool = new bool[4] {true,false,true,false};
            //BitArray bitArray2 = new BitArray(arrayBool);// Khởi tạo từ mảng bool có sẵn
            //byte[] arrayByte = new byte[4] { 1, 2, 3, 4 };
            //BitArray bitArray3 = new BitArray(arrayByte);//Khởi tạo từ mảng byte có sẵn
            //Console.WriteLine("So bit của BitArray là:  " + bitArray3.Length);
            //int[] ints = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //BitArray arrayInt = new BitArray(ints);
            //Console.WriteLine("So bit cua BitArray la: "+arrayInt.Length);
            bool[] MyBool = new bool[5] { true, false, false, true, true };
            BitArray MyBA1 = new BitArray(MyBool);
            bool[] MyBool1 = new bool[5] { false, true, true, true, false };
            BitArray MyBA2 = new BitArray(MyBool1);
            BitArray MyBA3 = new BitArray(MyBA1);
            MyBA3.And(MyBA2);
            Console.Write("Ket qua cua phep tinh AND: ");
            for (int i = 0; i < MyBA3.Length; i++)
            {
                Console.Write(MyBA3[i]);
            }
            BitArray MyBA4 = new BitArray(MyBA1);
            MyBA4.Or(MyBA2);
            Console.Write("\nKet qua cua phep tinh OR: ");
            for (int i = 0; i < MyBA4.Length; i++)
            {
                Console.Write(MyBA3[i]);
            }
            BitArray MyBA5 = new BitArray(MyBA1);
            MyBA5.Not();
            Console.Write("\nKet qua cua phep tinh NOT: ");
            for (int i = 0; i < MyBA5.Length; i++)
            {
                Console.Write(MyBA5[i]);
            }
            BitArray MyBA6 = new BitArray(MyBA1);
            MyBA3.Xor(MyBA2);
            Console.Write("\nKet qua cua phep tinh XOR: ");
            for (int i = 0; i < MyBA6.Length; i++)
            {
                Console.Write(MyBA6[i]);
            }
        }
    }
}