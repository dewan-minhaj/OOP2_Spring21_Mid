using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment den1 = new Depertment("Computer science", "CS");
            Depertment den2 = new Depertment("Electrical Engineering", "EEE");
            Student s1 = new Student ("Sadman Sakib", "33604", 3.25f);
            Student s2 = new Student("Akil Ahmed", "42519", 3.01f);
            s1.Depertment = den1;
            s2.Depertment = den2;
            s1.show();
            s2.show();

        }
    }
}
