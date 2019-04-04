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

            int[,] arr = new int[6, 6];

            for (var i = 0; i < 6; i++)
            {
                var numList = new string[6];
                numList = Console.ReadLine().Split(' ');
                for (var j = 0; j < 6; j++)
                {
                    arr[i, j] = Convert.ToInt32(numList[j]);
                }
            }

            int result = hourglassSum(arr);

            
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
    //-9 -9 -9  1 1 1 
    //0  -9  0  4 3 2
    //-9 -9 -9  1 2 3
    //0   0  8  6 6 0
    //0   0  0 -2 0 0
    //0   0  1  2 4 0
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[,] arr) 
        {
            int nRow=6,nCol=6;
            //TODO: Take the centre value 
            //If we take value at arr[1,1], hourglass will be arr[0,0],arr[0,1],arr[0,2] and bottom will be arr[2,0],arr[2,1],arr[2,2]
            int sum =0;
            var max = int.MinValue;
            int hgTopRow,hgBotRow,hgLeftCol,hgRightCol;
            for(int i=1;i<nRow-1;i++)
            {
                for(int j=1;j<nCol-1;j++)
                {
                    sum=arr[i,j];
                    hgTopRow = i-1;
                    hgBotRow = i+1;
                    hgLeftCol = j-1;
                    hgRightCol = j+1;
                    sum = sum + arr[hgTopRow,hgLeftCol] + arr[hgTopRow,j] + arr[hgTopRow,hgRightCol];
                    sum = sum + arr[hgBotRow,hgLeftCol] + arr[hgBotRow,j] + arr[hgBotRow,hgRightCol];
                    if(sum>max)
                        max=sum;
                }               
               
            }
            return max;
        }

        //        5 4
        //1 2 3 4 5
        //sample output:5 1 2 3 4

        // Complete the rotLeft function below.
        public static int[] rotLeft(int[] a, int d)
        {
            //int n = a.Length;
            //int rotations = n - d;
            ////implement array element rotation by d times
            //for(int i=1;i<=rotations;i++)
            //{
            //    int[] transformed = new int[n];
            //    for (int j=0;j<n;j++)
            //    {
            //        if (j + 1 >= n)
            //            transformed[0] = a[j];
            //        else
            //            transformed[j + 1] = a[j];
            //    }
            //    a = transformed;
            //}
            //return a;

            int n = a.Length;
            int[]  transformed = new int[n];
           
            //implement array element rotation by d times
            for (int i = 0; i < n; i++)
            {
                int newLocation = (i + (n - d)) % n;
                transformed[newLocation] = a[i];
            }
            return transformed;
        }

//        Sample Input

//2
//5
//2 1 5 3 4
//5
//2 5 1 3 4
//Sample Output

//3
//Too chaotic

        // Complete the minimumBribes function below.
        public static void minimumBribes(int[] q)
        {
            int n,nBribes=0;
            n = q.Length;
                      
            //no person can make more than 2 bribes, if found, return "Too chaotic"
            for(int i=0;i<n;i++)
            {
                int jump = q[i] - (i + 1);
                if (jump > 0)
                    if (jump > 2)
                    {
                        nBribes = 0;
                        break;
                    }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        nBribes++;
            }

           
            if (nBribes > 0)
                Console.WriteLine(nBribes);
            else
                Console.WriteLine("Too chaotic");


        }



    }
}
