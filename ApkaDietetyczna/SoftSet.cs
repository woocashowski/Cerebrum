using Cerebrum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebrum
{
    class SoftSet
    {
        static List<Product> Accepted;
        static List<Product> products;

        public static List<Product> calculate(uint needp, uint needf, uint needc)
        {
            //public static List<Product> products;
            products = Download.download();
            Accepted = new List<Product>();
            //foreach (Product item in products)
                //Console.WriteLine("id: " + item.id + " " + item.protein + " " + item.fat + " " + item.carbs);
            foreach (Product item in products)
                if (item.protein <= needp )
                    if (item.fat <= needf )
                        if (item.carbs <= needc)
                            //if(Req.Chosen.Contains(item) == false)
                            Accepted.Add(item);
            //foreach (Product item in Accepted)
                //Console.WriteLine("id: " + item.id);
            return Accepted;
        }


    }
}

