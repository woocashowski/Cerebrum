using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebrum
{
    class Cerebrum
    {
        public static uint need_p = 200, need_f = 100, need_c = 200;
        public static List<Product> Chosen;

        public static List<Product> select(uint needp, uint needf, uint needc, uint meals)
        {
            need_p = needp;
            need_f = needf;
            need_c = needc;
            Chosen = new List<Product>();

            for (uint i = 0; i < meals; i++)
            {
                //Console.WriteLine("Zostało: \n Białko: {0} \t Tłuszcz: {1} \t Węglowodany: {2}", needp, needf, needc);
                Product item = Knn.nearest/*(needp / (meals), needf / (meals), needc / (meals)); /*/(needp / (meals - i), needf / (meals - i), needc / (meals - i));
                //Console.WriteLine((item.id));
                //item = new Product();
                Chosen.Add(item);
                needp -= item.protein;
                needf -= item.fat;
                needc -= item.carbs;

                //Console.WriteLine("Zostało: {0} {1} {2}", needp, needf, needc);
                //Console.WriteLine("id: " + item.id + " " + item.protein + " " + item.fat + " " + item.carbs + " " + item.name);
                Console.WriteLine("Produkt: " + item.name + " \n\t\t\tBiałko: " + item.protein + " Tłuszcz: " + item.fat + " Węglowodany: " + item.carbs);
            }
            Console.WriteLine("Zostało: \n\nBiałko: {0}\tTłuszcz: {1}\tWęglowodany: {2}", needp, needf, needc);
            return Chosen;
        }
    }
}
