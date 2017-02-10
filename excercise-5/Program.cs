using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            add<int> ad = new add<int>();
            int result = ad.addtion(10, 20);
            Console.WriteLine("The result is " + result);
        }
    }

    public class add<T>
    {
        dynamic val1, val2;
        public T addtion(T a,T b)
        {
            this.val1 = a;
            this.val2 = b;
            T c = val1+val2;
            return c;
        }
    }
}
