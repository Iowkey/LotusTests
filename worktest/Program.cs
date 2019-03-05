using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worktest
{
    class Program
    {
        /*Реализовал функцию уже с известной переменной encode(один из кейсов в условии) и с пользовательским вводом*/
        public static string Decode(string encoded)
        {
            //string encoded = Console.ReadLine();
            //string encoded = "2312179862310199501872379231018117927";
            string rev_encoded = "";
            for (int i = encoded.Length - 1; i >= 0; i--)
                rev_encoded += encoded[i];
            string decoded = "";
            int count = 0;
            for (int j = 0; j < rev_encoded.Length; j += count)
            {
                count = 0;
                if (rev_encoded[j] == '1')
                {
                    decoded += Convert.ToChar(Convert.ToInt32($"{rev_encoded[j]}" + $"{rev_encoded[j + 1]}" + $"{rev_encoded[j + 2]}"));
                    count += 3;
                }
                else
                {
                    decoded += Convert.ToChar(Convert.ToInt32($"{rev_encoded[j]}" + $"{rev_encoded[j + 1]}"));
                    count += 2;
                }
            }
            return decoded;
        }

        public static void RemoveArrElements(int[] a, int x)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] <= x)
                    Console.WriteLine(a[i]);
                else
                    continue;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 5, 12, 3, 53, 32, 6 };
            RemoveArrElements(arr, 15);
            string Result = Decode("2312179862310199501872379231018117927");
            Console.WriteLine(Result);
            Console.ReadKey();

        }
    }
           
            
}
