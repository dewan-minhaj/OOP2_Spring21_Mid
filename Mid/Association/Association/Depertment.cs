using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Depertment
    {
        private string name;
        private string Name
        {
            set { name = value; }
            get { return name; }
        }
        private String id;
        private string ID
        {
            set { id = value; }
            get { return id; }
        }
        public Depertment() { }
        public Depertment (string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void show()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
        }

    }
        
}
