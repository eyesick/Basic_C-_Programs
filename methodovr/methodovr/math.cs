using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodovr
{
    public class math
    {
        public int by2(int a)
        {
            int result = a * 2;
            return result;

        }

        public int by2(int a, decimal b)
        {
            decimal result = a * 2 * b;
            Convert.ToInt32(result);
            return (int)result;

        }

        public int by2(int a, int b, string word)
        {
            Convert.ToInt32(b);
            int result = a * b;
            Convert.ToString(result);
            Console.WriteLine(result + word);
            return result;


        }
    }
}
