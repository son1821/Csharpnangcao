using System.Collections;

namespace SortedList1
{
    class Program
    {
        static void Main(string[] args)
        {
          SortedList MySL = new SortedList();
          SortedList MySL2 = new SortedList(10);
        SortedList MySL3 = new SortedList(MySL2);
            SortedList MySL4 = new SortedList(new SortPersons());
          SortedList MySL5 = new SortedList(MySL3, new SortPersons());
            MySL5.Add(new Person("Son", 10), 50);
            MySL5.Add(new Person("Quynh", 20), 20);
            MySL5.Add(new Person("Quang", 30), 600);
            Console.WriteLine("So phan tu truoc la:"+MySL5.Count);
            foreach (DictionaryEntry person in MySL5)
            {
                Console.WriteLine("Key: "+person.Key+"\tValue: "+person.Value);
            }
            Console.WriteLine();
            MySL5.RemoveAt(1);
            Console.WriteLine("So phan tu sau xoa:"+MySL5.Count);
            foreach(DictionaryEntry person in MySL5)
            {
                Console.WriteLine("Key: " + person.Key + "\tValue: " + person.Value);
            }
            
        }
        public class SortPersons : IComparer
        {
            public int Compare(object x, object y)
            {
                Person person1 = x as Person;
                Person person2 = y as Person;
                if (person1 == null && person2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (person1.Age < person2.Age)
                    {
                        return -1;
                    }
                    else if (person1.Age == person2.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}