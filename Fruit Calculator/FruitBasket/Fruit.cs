using Fruit_Calculator.Enum;
using Fruit_Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Calculator.FruitBasket
{
    public class Fruit : IFruit
    {
        private int _number;
        private decimal _cost;
        private decimal _promotion;
        private FruitType _fruitType;
        

        FruitType IFruit.FruitType { 
            get => _fruitType;
            set => _fruitType = value;
        }
        decimal IFruit.Cost { 
            get => _cost; 
            set => _cost = value; 
        }
        int IFruit.Number {
            get => _number;
            set => _number = value;
        }
        decimal IFruit.Promotion {
            get => _promotion;
            set => _promotion = value;
        }

        public Fruit(FruitType type, int number, decimal cost, decimal promotion)
        {
            _fruitType = type;
            _number = number;
            _cost = cost;
            _promotion = promotion;
        }

        public decimal Total()
        {
            return CalculateTotal();
        }
        private decimal CalculateTotal()
        {
            //number*cost
            return (_cost * _number) * ((1 - _promotion));
        }

        public override string ToString() => CalculateTotal().ToString("C", CultureInfo.CurrentCulture);


    }
}
