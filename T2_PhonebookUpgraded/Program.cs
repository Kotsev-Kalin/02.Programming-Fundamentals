﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_PhonebookUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, string>();
            List<string> vhod = new List<string>();
            List<string> result = new List<string>();
            while (true)
            {
                if (vhod.Contains("END"))
                {
                    break;  
                }
                else
                {
                    vhod = Console.ReadLine().Split(' ').ToList();
                    if (vhod[0] == "A")
                    {
                        dict[vhod[1]] = vhod[2];
                    }
                }
                if (vhod[0] == "A")
                {           

                    if (dict.ContainsKey(vhod[1]))
                    {
                        result.Add($"{vhod[1]} -> {dict[vhod[1]]}");
                    }
                    else  
                    {
                        result.Add($"Contact {vhod[1]} does not exist.");
                    }
                }
            }
            result.Sort();
            foreach (var item in result)
            { 
                
                Console.WriteLine(item);
            }
        }
    }
}
