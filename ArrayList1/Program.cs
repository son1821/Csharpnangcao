using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPersons = new ArrayList();
            arrPersons.Add(new Person("Son", 18));
            arrPersons.Add(new Person("Quang", 25));
            arrPersons.Add(new Person("Hai", 15));
            Console.WriteLine("Danh sach ban dau");
            foreach (Person person in arrPersons)
            {
                person.ToString();
            }
            arrPersons.Sort(new SortPersons());
            Console.WriteLine();
            Console.WriteLine("Danh sach sau khi sap xep tuoi tang dan");
            foreach (Person person in arrPersons)
            {
                person.ToString();
            }
        }
    }
    public class SortPersons : IComparer
    {
     public int Compare(object x, object y)
        {
            Person person1 = x as Person;
            Person person2 = y as Person;
            if(person1 == null && person2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(person1.Age < person2.Age)
                {
                    return -1;
                }else if(person1.Age == person2.Age)
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