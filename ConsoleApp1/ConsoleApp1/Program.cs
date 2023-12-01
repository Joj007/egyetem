using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bemenet = System.Console.ReadLine();
            List<string> list = new List<string>();
            list = bemenet.Split().ToList();
            string eredmeny = "";
            foreach (string item in list)
            {
                switch (item.Substring(item.Length-2))
                {
                    case "sp":
                        for (int i = 1; i < 1 + Convert.ToInt32(item.Substring(0, item.Length - 2)); i++)
                            eredmeny += " ";
                        break;
                    case "bS":
                        for (int i = 1; i < 1 + Convert.ToInt32(item.Substring(0,item.Length-2)); i++)
                            eredmeny+="\\";
                        break;
                    case "sQ":
                        for (int i = 1; i < 1 + Convert.ToInt32(item.Substring(0, item.Length - 2)); i++)
                            eredmeny+="\'";
                        break;
                    case "nl":
                        eredmeny+="\n";
                        break;
                    default:
                        for (int i = 1; i < 1 + Convert.ToInt32(item.Substring(0, item.Length-1)); i++) {
                            eredmeny+=item.Substring(item.Length-1);
                        }
                        break;
                }
            }
            System.Console.WriteLine(eredmeny);
        }
    }
}