using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebrum
{
    class Knn
    {
        private static Product found;
        static List<Product> products;

        //Let's find a nearest product
        //Product static found;

        public static Product nearest(uint needp, uint needf, uint needc)
        {
            found = new Product();
            products = new List<Product>();
            products = SoftSet.calculate(needp, needf, needc);
            //products = new List<Product>();
            //found = products[0];
            double distance = double.PositiveInfinity;
            //List<Product> Accepted = SoftSet.calculate();
            foreach (Product item in products)
            {
                //double dis = Math.Sqrt(Math.Pow(needp - item.protein, 2) * 0.4 + Math.Pow(item.fat - needf, 2) * 0.9 + Math.Pow(item.carbs - needc, 2) * 0.4);
                uint dis = ((needp - item.protein) * 2)  + (needf - item.fat) + (needc - item.carbs);
                //Console.WriteLine("Dystans " + distance);
                if (dis < distance)
                {
                    found = item;
                    distance = dis;
                    //Console.WriteLine("Dystans " + distance);
                }
            }
            //Console.WriteLine("id: " + found.id + " " + found.protein + " " + found.fat + " " + found.carbs + found.name);
            return found;
        }

    }
}
