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


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("c:\\temp\\test.txt", true);

            string sInput = Console.ReadLine();

            int cCount = Convert.ToInt32(sInput.Trim());

            List<string> c = new List<string>();

            for (int i = 0; i < cCount; i++)
            {
                string cItem = Console.ReadLine();
                c.Add(cItem);
            }

            int xCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> x = new List<int>();

            for (int i = 0; i < xCount; i++)
            {
                int xItem = Convert.ToInt32(Console.ReadLine().Trim());
                x.Add(xItem);
            }

            int yCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> y = new List<int>();

            for (int i = 0; i < yCount; i++)
            {
                int yItem = Convert.ToInt32(Console.ReadLine().Trim());
                y.Add(yItem);
            }

            int qCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> q = new List<string>();

            for (int i = 0; i < qCount; i++)
            {
                string qItem = Console.ReadLine();
                q.Add(qItem);
            }

            List<string> result = Result.closestStraightCity(c, x, y, q);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

