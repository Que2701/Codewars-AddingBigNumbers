using System;
using System.Numerics;

namespace AddingBigNumbersApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adding Large Numbers";
             
            Console.WriteLine(Add("9223372036854775807", "9223372036854775801"));
        }
        public static string Add(string a, string b)
        {
            try
            {
                return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
            }
            catch (Exception)
            {
                return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
            }
            
        }
    }
}
