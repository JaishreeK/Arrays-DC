using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_DS
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        // Complete the reverseArray function below.
        public static int[] reverseArray(int[] a) {
           //reverse a given array
            int n = a.Length;
            int[] reversed =  new int[n];            
            for(int i=n-1,j=0;i>-1;i--,j++)
            {
                reversed[j]=a[i];
            }
            return reversed;


        }
    }
}
