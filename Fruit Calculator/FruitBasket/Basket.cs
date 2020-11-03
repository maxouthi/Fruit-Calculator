using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Calculator.FruitBasket
{
    public class Basket
    {
        public Fruit Oranges { get; set; }
        public Fruit Apples { get; set; }

        public Basket(Fruit oranges, Fruit apples)
        {
            Oranges = oranges;
            Apples = apples;
        }
        public string GrandTotal()
        {
            return Total().ToString("C", CultureInfo.CurrentCulture);
        }

        private decimal Total()
        {
            return this.Oranges.Total() + this.Apples.Total();
        }
    }
}
