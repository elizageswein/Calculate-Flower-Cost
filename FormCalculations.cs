// displays price and discount information based on user input of flowers and garden type

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string[] gardens = { "Premium", "Standard", "Discount" }; // garden type
            double[] baseRates = { 1.10, 1.00, 0.9 }; // rates
            int[] itemNums = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; // item numbers
            double[] flowerCosts = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; // costs per flower
            int[] quantities = { 0, 6, 16, 20 }; // valid flwoer quantities to discount
            double[] discounts = { 1.00, .95, .90, .85 }; // discounts based on quantity
            
            int itemNum; // variable used with TryParse
            int quant; // variable used with TryParse

            bool grdnFound = false; // variable used to end loop
            bool flwrFound = false; // variable used to end loop
            bool qtyFound = false; // variable used to end loop

            double baseRate = 0; // variable used with base rates array
            double flwrCost = 0; // variable used with flower costs array
            double discnt = 0;  // variable used with with discounts array

            // makes sure user input is valid
            if (int.TryParse(itemNumInpt.Text, out itemNum) && itemNum >= 10001 && itemNum <= 10007)
            {
                // makes sure user input is valid
                if (int.TryParse(quantInpt.Text, out quant) && quant >= 0)
                {
                    // makes sure user input is valid
                    if (grdnInpt.SelectedIndex >= 0)
                    {
                        // loop for garden type
                        for (int x = 0; x < gardens.Length && !grdnFound; ++x)
                        {
                            if (grdnInpt.Text == gardens[x])
                            {
                                baseRate = baseRates[x];
                                grdnFound = true;
                            }
                        }
                        // loop used to compare item numbers to itemNums
                        for (int y = 0; y < itemNums.Length && !flwrFound; ++y)
                        {
                            if (itemNum == itemNums[y])
                            {
                                flwrCost = flowerCosts[y];
                                flwrFound = true;
                            }
                        }
                        
                        // loop used to compare quantity to quantites array with discounts
                        for (int z = quantities.Length - 1; z >= 0 && !qtyFound; --z)
                        {
                            if (quant >= quantities[z])
                            {
                                discnt = discounts[z];
                                qtyFound = true;
                            }
                        }

                        double totalFlwrCost = quant * flwrCost; // calculates flower cost
                        double adjstCost = totalFlwrCost * baseRate; // calculates base adjusted cost
                        double totalCost = adjstCost * discnt; // calculates total cost

                        flwrCostOutpt.Text = $"{totalFlwrCost:C}"; // displays flower cost
                        adjstCostOutpt.Text = $"{adjstCost:C}"; // displays base adjusted cost
                        discntOutpt.Text = $"{(1 - discnt):P}"; // displays discount %
                        totalOutpt.Text = $"{totalCost:C}"; // displays total cost

                    }
                    else MessageBox.Show("Select a garden");
                }
                else MessageBox.Show("Enter a quantity");
            }
            else MessageBox.Show("Enter an item number between 10001 and 10007");
        }
    }
}
