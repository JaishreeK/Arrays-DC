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

        // Complete the minimumSwaps function below.
        public static int minimumSwaps(int[] arr)
        {
            ////[7, 1, 3, 2, 4, 5, 6]
            //int n = arr.Length;
            //int nSwaps = 0;
            //for(int i=0;i<n;i++)
            //{
            //    int j = i + 1;
            //    int midIndex = (int)Math.Floor((decimal)(n / 2));
                
            //    if (arr[midIndex] > arr[midIndex + 1])
            //    {
            //        //Swap
            //        int temp;
            //        temp = arr[midIndex];
            //        arr[midIndex+1] = arr[midIndex];
            //        arr[midIndex] = temp;
            //        nSwaps++;
            //    }             

            //}

            int first = 0, last = arr.Length - 1;
            int swaps = 0;
            while (first < last)
            {
                while (arr[first] == first + 1 && first < last)
                    first++;
                if (first < last)
                {
                    int temp = arr[arr[first] - 1];
                    arr[arr[first] - 1] = arr[first];
                    arr[first] = temp;
                    swaps++;
                }
            }
            return swaps;
        }

        //n=10
        //a b k
        //1 5 3
        //4 8 7
        //6 9 1

        // Complete the arrayManipulation function below.
        public static long arrayManipulation(int n, int[,] queries)
        {
            int[] arr = new int[n+1];
            //initialise the array with 0s;
            Array.Clear(arr, 1, n);
            for (int i = 0; i < queries.GetLength(0);i++)
            {
                //get the indices
                int left = queries[i, 0];
                int right = queries[i, 1];
                int k = queries[i, 2];
                arr[left] += k;
                if (right + 1 <= n) arr[right + 1] -= k;
                //for(int j=left;j<=right;j++)
                //{
                //    arr[j] = arr[j] + k;
                //}
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += arr[i];
                if (tempMax > max) max = tempMax;
            }
            return max;
        }

        //        6 4
        //give me one grand today night
        //give one grand today

        // Complete the checkMagazine function below.
        public static void checkMagazine(string[] magazine, string[] note)
        {
            int m = magazine.Length;
            int n = note.Length;
            string answer = "Yes";
            //use of dictionaries
            Dictionary<string,int> magazineDict = new Dictionary<string,int>();
            foreach (var word in magazine)
            {
                if (magazineDict.ContainsKey(word))
                    magazineDict[word] += 1;
                else
                    magazineDict.Add(word, 1);

            }                  
            //check
            foreach (string item in note)
            {
                if (!magazineDict.ContainsKey(item))
                {
                    answer = "No";
                    break;
                }
                else
                {
                    //consume the value by getting the key
                    magazineDict[item] -= 1;
                    if(magazineDict[item]==0)
                        magazineDict.Remove(item);
                }
            }

            Console.WriteLine(answer);

        }

//        2
//hello
//world
//hi
//world

        //, . The substrings  and  are common to both strings.
        // Complete the twoStrings function below.
        public static string twoStrings(string s1, string s2)
        {
            var returnStr = "NO";    
            Dictionary<char, int> s1CharDict = new Dictionary<char, int>();
            foreach (var char1 in s1)
            {
                if (s1CharDict.ContainsKey(char1))
                    s1CharDict[char1] += 1;
                else
                    s1CharDict.Add(char1, 1);
                
            }
            foreach (var char2 in s2)
            {
                if (s1CharDict.ContainsKey(char2))
                {
                    returnStr = "YES";
                    break;
                }
            }
            return returnStr;
        }

//        1
//cdcd
        // Complete the sherlockAndAnagrams function below.
        public static int sherlockAndAnagrams(string s)
        {
            int AnagramCount = 0;
            int strLength = s.Length;
            string temp2 = "";
            string temp = "";
            // TODO: similarly we have to do for 2,3..until n-1 characters where n is the length of the string
            for (int cnt = 1; cnt < strLength; cnt++)
            {
                for (int k = 0; k < strLength; k++)
                {                   
                    if (strLength - k >= cnt)
                    {
                        temp = s.Substring(k, cnt);
                        for (int i = k + 1; i < strLength; i++)
                        {                            
                            if (strLength - i >= cnt)
                            {
                                temp2 = s.Substring(i, cnt);
                                if (Check_Anagram(temp, temp2))
                                    AnagramCount++;
                            }
                            else
                                break;
                        }
                    }
                    else
                        break;
                }
            }
            return AnagramCount;
        }

        public static string GetKElements(string s, int k)
        {
            return s.Substring(0, k);
        }

        public static bool Check_Anagram(string temp, string temp2)
        {
            var tempChars = temp.ToCharArray();
            var temp2Chars = temp2.ToCharArray();

            Array.Sort(tempChars);
            Array.Sort(temp2Chars);

            string resultTemp = new string(tempChars);
            string resultTemp2 = new string(temp2Chars);

            if (resultTemp == resultTemp2)
                return true;
            else
                return false;
        }
    }
}
