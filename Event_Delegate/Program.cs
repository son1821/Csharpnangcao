namespace Event_Delegate
{
    delegate void UpdateNameHandler(string name);
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Son";
            Console.WriteLine("Ten tu class Program: "+hs.Name);
            hs.Name = "Quynh";
            Console.WriteLine("Ten tu class Program: " + hs.Name);
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Ten moi: "+name);
        }
    }
    class HocSinh
    {
        public event UpdateNameHandler NameChanged;
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                NameChanged(Name);
            }
        }
        
    }
}
