using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
    
    namespace Sorted_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList<string, int> sortList =new SortedList<string, int>();

            string[] inecArray = { "shola", "ayo", "nas", "odun", "emma", "nas", "ayo", "mac", "john", "ayo" };

            

            foreach (var name in inecArray)
            {
                int count = 0;
                if (sortList.ContainsKey(name))
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)
                {
                    if(name == inecArray[i])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    sortList.Add(name, count);
                }
            }
            foreach(var item in sortList)
            {
                Console.WriteLine(item);

            }
        }
    }
}