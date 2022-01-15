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
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */

    public static List<int> rotLeft(List<int> a, int d)
    {
        /*List<int> b=a;
        int i, j, z=1, First;        
        for(i=0;i<d;i++)
        {        
            First=a[0];
            z=1;
            for(j=0;j<a.Count-1;j++)
            {
                    b[j]=a[z];                       
                    z++;                    
            }
            b[a.Count-1]=First;                                    
            for (int x=0;x<b.Count;x++)
            {
                a[x]=b[x];
               Console.WriteLine(a[x]);                
            }
        }
        return a;
        */
        
        
        int[] newarry = new int[a.Count];
        for(int i=0;i<a.Count;i++)
        {
            newarry[i]=a[(i+d)%a.Count];
        }
         
        List<int> list = newarry.ToList();
        return list;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = Result.rotLeft(a, d);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
