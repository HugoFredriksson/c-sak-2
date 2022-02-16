using System;
using System.Collections.Generic;
using System.Diagnostics;
 
namespace yuh
{
    class Program
    {
        static void Main(string[] args)
        {
 
        List<int> intList = new List<int>();
 
        Random arr = new Random();
 
        Stopwatch watch = new Stopwatch();
 
        watch.Start();
 
        for(int i = 0; intList.Count < 8000; i++){
                intList.Add(arr.Next(1, 1001));
            }
           for (int i = 0; i < intList.Count - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < intList.Count; j++)
                if (intList[j] < intList[min_idx])
                    min_idx = j;
 
            int temp = intList[min_idx];
            intList[min_idx] = intList[i];
            intList[i] = temp;
 
            watch.Stop();
 
        }
   
   
            foreach(int i in intList){
                Console.WriteLine(i);
           
            }
            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        foreach (int p in intList)
            Console.Write(p +" ");
        Console.Read();
        Console.WriteLine("Tiden: {0} ticks", watch.ElapsedTicks);
}
    }
}
       
     
