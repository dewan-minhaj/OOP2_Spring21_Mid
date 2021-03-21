using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace unique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;
            Console.WriteLine("print all unique element of an arry:");
            Console.WriteLine("Input the number of elements t:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} element in the array:", a);
            for (i = 0; i < a; i++) ;
            arr1[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The unique elements found in the arrey:");
            for (i = 0; i < a; i++) ;
            {
                ctr = 0;
                for (j = 0; j < i - 1; j++) ;
                {
                    if (arr1[i] == arr1[j]) ;
                    {
                        ctr++;
                    }
                }
            }

            for (k = i + 1; k < a; k++)
            {

                if (arr1[i] == arr1[k])
                {
                    ctr++;
                }

                if (arr1[i] == arr1[i + 1])
                {
                    i++;
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }


            }
            Console.WriteLine();

        }
    }
}
