using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class ExtensionClass
    {
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;
            return result;
        }

        public static string MyReverse(this string myStr)
        {
            char[] charArray = myStr.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            string str = "hello, World";

            Console.WriteLine(a.Power(b));
            Console.WriteLine(str.MyReverse());
        }
    }
}
