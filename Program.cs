using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int num = 0;
            string input = Console.ReadLine();
            num = int.Parse(input);
            
            int varloop = 0;
            string result = string.Empty;
            string location = "";
            int totalones = 0;
            string actualnum = "";

            while (num >= 1)
            {
                res = num / 2;
                varloop = num % 2;

                result += varloop.ToString();
                num = res;
            }
            
            for (int i = result.Length - 1; i >= 0; i--)
            {
                actualnum = actualnum + result[i];
            }
            int pos = 0;
            for (int i = 0; i <= actualnum.Length - 1; i++)
            {
                if (actualnum[i].ToString() == "1")
                {
                    pos = i + 1;
                    location += pos.ToString();
                    totalones++;
                }
            }
            string finalres = totalones + location;
            string[] arr = new string[finalres.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = finalres[i].ToString();
                Console.WriteLine(arr[i]+",");
            }

            Console.WriteLine("Position "+location);
            Console.WriteLine("Onebits " + totalones);
            Console.ReadLine();
        }
    }
}
