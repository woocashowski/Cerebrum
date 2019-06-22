using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebrum
{
    class Product
    {
        public uint id;
        public uint protein;
        public uint fat;
        public uint carbs;
        public string name;

        public Product(uint id, uint protein, uint fat, uint carbs, string name)
        {
            this.id = id;
            this.protein = protein;
            this.fat = fat;
            this.carbs = carbs;
            this.name = name;
        }

        public Product()
        {
        }
    }
}
