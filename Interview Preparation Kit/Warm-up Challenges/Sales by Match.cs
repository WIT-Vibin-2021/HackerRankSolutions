using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int cnt=0, cnteven=0, val;
        for(int i= 0 ;i<n ;i++)
        {       
            cnteven=1   ;               
            for(int j=i+1;j<n;j++)
            {                      
                if(ar[i]==ar[j] && ar[i]!=0)
                {
                    cnteven++;    
                    ar[j]=0;                  
                }
                if(cnteven%2==0 && cnteven!=0)
                {
                    cnt++;
                    cnteven=0;                 
                }
            }  
            cnteven=0;          
        }
        return cnt;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
-----------------------------------------
Sample Input

STDIN                       	Function
-----                       	--------
9                           	n = 9
10 20 20 10 10 30 50 10 20  	ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]
Sample Output

3
Explanation

sock.png

There are three pairs of socks.
