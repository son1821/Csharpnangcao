using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    class Class1<T>
    {
        public T Value { get; set; }
        
        public Class1(T value)
        {
            Value = value;
        }
        public void ToString()
        {
            Console.WriteLine("Value = "+Value);
        }
       
    }
}
