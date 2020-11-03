using Fruit_Calculator.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fruit_Calculator.Interfaces
{
    public interface IFruit
    {
        decimal Cost { get; set; }
        decimal Promotion { get; set; }
        int Number { get; set; }
        
        FruitType FruitType { get; set; }
    }
}
