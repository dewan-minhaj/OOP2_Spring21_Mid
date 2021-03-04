using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string name;
        private string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
            

        }
        private string id;
        private string ID
        {
            set { id = value; }
            get { return id; }
        }
        private float cgpa;
        private float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public Student() { }
        public Student(string name,string id,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        Depertment depertment;
        public Depertment Depertment
        {
            set { depertment = value; }
            get { return depertment; }
        }
        public void show()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Cgpa :" + cgpa);

        }

    }
}
