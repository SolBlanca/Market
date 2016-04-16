using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Market;
using Market.Exchange;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleOrderBook book = new SimpleOrderBook();

            SimpleOrder a = new SimpleOrder(true, 11, 2);
            SimpleOrder b = new SimpleOrder(false, 10, 1);

            book.Add(b);
            book.Add(a);

            SimpleOrder c = new SimpleOrder(false, 10, 1);
            book.Add(c);

            Console.ReadKey();
        }
    }
}
