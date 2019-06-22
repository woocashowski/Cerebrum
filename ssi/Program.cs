using Cerebrum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebrum
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static List<Product> products;
            //Product = Req.select();
            List<Product> o;
            //białko tłuszcz węgle
            uint p = 200, f = 50, c = 200;
            uint m = 15;
            string line;
            Console.Write("Zapotrzebowanie na białko: ");
            line = Console.ReadLine();
            try
            {
                p = uint.Parse(line);
            }
            catch
            {
                p = 0;
            }

            Console.Write("Zapotrzebowanie na tłuszcz: ");
            line = Console.ReadLine();
            try
            {
                f = uint.Parse(line);
            }
            catch
            {
                f = 0;
            }

            Console.Write("Zapotrzebowanie na węglowodany: ");
            line = Console.ReadLine();
            try
            {
                c = uint.Parse(line);
            }
            catch
            {
                c = 0;
            }
            
            Console.Write("Ilość pokarmów: ");
            line = Console.ReadLine();
            try
            {
                m = uint.Parse(line);
                if (m == 0) m = 1;
            }
            catch
            {
                m = 1;
            }


            o = Cerebrum.select(p, f, c, m);
            //Console.WriteLine(o[0].id);
            Console.ReadKey();



            }
    }
}
