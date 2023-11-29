namespace Delegate1
{
    class Program
    {
        delegate int MyDelegate(string x);
        public static void Main(string[] args)
        {
            MyDelegate showString = new MyDelegate(ShowString);
            NhapTen(showString);
            //MyDelegate myDelegate1 = new MyDelegate(ShowString);
            //MyDelegate muticast = myDelegate + myDelegate1;
            //string number = "15";
            //myDelegate(number);
            //myDelegate1(number);
            //Console.WriteLine("Hien thi sau khi dung muticast: ");
            //muticast(number);
           
        }
        static void NhapTen(MyDelegate myDelegate)
        {

            Console.WriteLine("Moi nhap ten");
            string ten = Console.ReadLine();
            myDelegate(ten);

        }
        //public static int ConvertToInt(string x)
        //{
        //    int value = Convert.ToInt32(x);
        //    Console.WriteLine("Da ep kieu thanh cong ");
            
        //    return value ;
        //}
        public static int ShowString(string stringValue) 
        {
             Console.WriteLine(stringValue);
            return 0 ;
        }
       
        }
    }

