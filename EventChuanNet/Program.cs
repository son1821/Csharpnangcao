namespace EventChuanNet
{
    delegate void UpdateNameHandler(string name);
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Son";
            hs.Name = "Quynh";
        }

        private static void Hs_NameChanged(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("Da dươc thay doi: "+e.Name);
        }
    }
    class HocSinh
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { name = value;
              OnNameChanged(value);
            }
        }
        private event EventHandler<NameChangedEventArgs> nameChanged;
        public event EventHandler<NameChangedEventArgs> NameChanged
        {
            add
            {
              nameChanged += value;
            }
            remove
            {
                nameChanged -= value;
            }
        }
        public void OnNameChanged(string name)
        {
            nameChanged(this, new NameChangedEventArgs(name));
        }
        
    }
    public class NameChangedEventArgs: EventArgs
    {
        public string Name { get; set; }
        public NameChangedEventArgs(string name)
        {
            Name = name;
        }   
    }
}


