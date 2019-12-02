using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingBigNumbersApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("9223372036854775807", "9223372036854775801")); 
        }
        public static string Add(string a, string b)
        {
            try
            {
                return (Convert.ToInt64(a) + Convert.ToInt64(b)).ToString();
            }
            catch (Exception)
            {
                return (Convert.ToUInt64(a) + Convert.ToUInt64(b)).ToString();
            }
            
        }
    }
}
