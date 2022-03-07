using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    internal class ParamsArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main()
        {
            ParamsArray app = new ParamsArray();
            int sum = app.AddElements(1,2,3,4,5);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
