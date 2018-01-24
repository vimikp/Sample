using System;
using System.Collections.Generic;
using System.Linq;

namespace CoderChallenge
{
    class Program
    {
        int i = 0;
       // string global_str = "";
        public static string FirstReverse()
        {
            var str = "Hello World and Coders";
            var splitstr = str.Split(' ');
            var maxln = splitstr.Length-1;
            var resultstr = "";
            int i;
            for ( i = maxln; i >=0; i--)
            {
                var tempstr = splitstr[i];
                char[] charArray = tempstr.ToCharArray();
                Array.Reverse(charArray);
                resultstr += (new string(charArray) + " ");


               // return global_str;
            }

            return resultstr;
        }

        public void largestnum()
        {
           // int i = 0;
            Console.WriteLine("Enter the string:");
            //  string thestr = "what are you not typing and what not are you not";
            string thestr = Console.ReadLine();
            string[] substr = thestr.Split(' ');


            Dictionary<int, string> dictionarystr = new Dictionary<int, string>();
            for (int i = 0; i < substr.Length; i++)
            {
                dictionarystr.Add(i, substr[i]);
            }
      
            foreach (KeyValuePair<int, string> strKeyValue in dictionarystr)
            {
                string temp = strKeyValue.Value;
                Console.WriteLine(temp);
            }

            //var myresult = new Dictionary<int, string>();
            Console.WriteLine("=====================");

            var myresult = dictionarystr.GroupBy(x => x.Value).Where(c => c.Count() > 1).ToDictionary(g => g.Key, g => g.Select(x => x.Value).ToList());

            var indexval = myresult.Count;
            int[] anArray = new int[indexval];

            foreach (var result in myresult)
            {
                anArray[i] = result.Value.Count();
                i++;
            }
            int maxval = anArray.Max();

            foreach ( var result in myresult )
            {
                if (result.Value.Count() == maxval)
                {
                    Console.WriteLine("The word with maximum occurences is:" + result.Key);
                }

            }
            
        }
        public int factfun(int num)
        {
            if (num == 0)

                return 1;
            else
            {
                num = num * factfun(num - 1);
                return num;
            }

        }


        static void Main(string[] args)
        {
            Program p = new Program();
            // var val = p.factfun(5);
            // Console.WriteLine("The value of factorial is:" + val);
            //  p.largestnum();
            var localstr = FirstReverse();
            Console.WriteLine("The reverse of string is:" + localstr);
            Console.ReadLine();
        }
    }
}
