using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo1
{
    class SomeObject
    {
        public int Price { get; set; }
        public string Model { get; set; }

        public SomeObject(int price, string model)
        {
            Price = price;
            Model = model;
        }

        public override string ToString()
        {
            return String.Format("Product {0} with total price: {1}", Model, Price);
        }
    }
}
