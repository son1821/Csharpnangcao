using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Son", "Quynh");
            ht.Add("Bao", "Chau");
            //Hashtable ht2 = new Hashtable(ht);
            //foreach(DictionaryEntry hash in ht){
            //     Console.WriteLine(hash.Key+"\t"+hash.Value);
            //}
            //Console.WriteLine(ht["Bao"]);
            //Console.WriteLine("ht[\"Ao\"] = " + ht["Ao"]);
            //if (ht["Ao"]==null)
            //{
            //    Console.WriteLine("Key null");

            //}
            Console.WriteLine("Danh sach phan tu truoc khi them");
            Console.WriteLine("Count = "+ht.Count);
            foreach (DictionaryEntry ht1 in ht)
            {
                Console.WriteLine(ht1.Key +"\t"+ht1.Value);
            }
            Console.WriteLine("Danh sach phan tu sau khi them");
            ht["The"] = "Thu";
            Console.WriteLine("Count = " + ht.Count);
            foreach (DictionaryEntry ht2 in ht) {
            Console.WriteLine(ht2.Key +"\t"+ht2.Value);
            }
            Console.Read();
        }
    }
}