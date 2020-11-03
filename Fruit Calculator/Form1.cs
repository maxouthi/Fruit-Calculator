using Fruit_Calculator.FruitBasket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket(new Fruit(Enum.FruitType.Orange,
                                                 Convert.ToInt32(this.textBoxOranges.Text),
                                                 Convert.ToDecimal(this.textBoxOrangesCost.Text),
                                                 Convert.ToDecimal(this.textBoxOrangesPromotion.Text)),
                                        new Fruit(Enum.FruitType.Apple,
                                                 Convert.ToInt32(this.textBoxApples.Text),
                                                 Convert.ToDecimal(this.textBoxApplesCost.Text),
                                                 Convert.ToDecimal(this.textBoxApplesPromotion.Text))
                                       );

            this.textBoxOrangeTotal.Text = basket.Oranges.ToString();
            this.textBoxAppleTotal.Text = basket.Apples.ToString();
            this.textBoxGrandTotal.Text = basket.GrandTotal();
        }

    }
}
