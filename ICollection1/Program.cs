using System.Collections;

namespace ICollection1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public class MyArrayList : ICollection
        {
            object[] listObject;
            public int Count { get; set; }

            private int Capacity =100;
            public MyArrayList()
            {
                Count = -1;
                listObject = new object[Capacity];
            }
            public MyArrayList(int Count)
            {
                this.Count = Count;
                listObject = new Object[Count];
            }
            public MyArrayList(Array array)
            {
                array.CopyTo(listObject, 0);
                Count = array.Length;  
            }

            public void CopyTo(Array array, int index)
            {
                listObject.CopyTo(array, index);
            }
            public bool IsSynchronized
            {
                get { throw new NotImplementedException(); }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException(); }
            }
            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        
    }
}