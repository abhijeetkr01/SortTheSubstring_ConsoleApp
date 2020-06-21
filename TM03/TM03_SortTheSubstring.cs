using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM03
{
    class TM03_SortTheSubstring
    {
        static void sort(string args)
        {

            string str1 = args.Split()[0];
            string str2 = args.Split()[1];
            string str3 = args.Split()[2];
            int n = Convert.ToInt32(str2);
            int m = Convert.ToInt32(str3);
            int l = m - n + 1;
            string l1 = str1.Substring(0, n);
            string l2 = str1.Substring(n, l);
            string l3 = str1.Substring(m + 1);
            char[] ch = l2.ToCharArray();
            Array.Sort(ch);
            Array.Reverse(ch);
            Console.WriteLine("{0}{1}{2}", l1, new string(ch), l3);
        }

        static void Main()
        {
            int t;
            t = int.Parse(Console.ReadLine());
            string[] str = new string[t];
            for (int i = 0; i < t; i++)
                str[i] = Console.ReadLine();
            for (int i = 0; i < t; i++)
                sort(str[i]);
            Console.ReadKey();
        }
    }
}
