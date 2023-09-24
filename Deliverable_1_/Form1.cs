using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliverable_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputSodasSold_TextChanged(object sender, EventArgs e)
        {
            int intSodasSold = int.Parse(inputSodasSold.Text);

            int intSodaInventory = 100; 

            if (intSodasSold <= intSodaInventory)
            {
                int remainingSodas = intSodaInventory - intSodasSold;
                if (remainingSodas <= 40)
                {
                    calcSodas.Text = "Soda Stock is running low, please refil";

                }
                else
                {
                    calcSodas.Text = "You have " + remainingSodas + " sodas remaining"; 

                }

                intSodaInventory= remainingSodas;
            }

            else
            {
                lblSodaWarning.Visible = true;
            }
        }

        

       

        private void inputChipsSold_TextChanged_1(object sender, EventArgs e)
        {

            int intChipsSold = int.Parse(inputChipsSold.Text);

            int intChipsInventory = 40;

            if (intChipsSold <= intChipsInventory)
            {
                int remainingChips = intChipsInventory - intChipsSold;
                if (remainingChips <= 20)
                {
                    calcChips.Text = "Chip Stock is running low, please refil";

                }
                else
                {
                    calcChips.Text = "You have " + remainingChips + " chips remaining";

                }

                intChipsInventory = remainingChips;
            }

            else
            {
                lblChipsWarning.Visible = true;
            }
        }

        private void inputCandySold_TextChanged_1(object sender, EventArgs e)
        {
            int intCandySold = int.Parse(inputCandySold.Text);

            int intCandyInventory = 60;

            if (intCandySold <= intCandyInventory)
            {
                int remainingCandy = intCandyInventory - intCandySold;
                if (remainingCandy <= 40)
                {
                    calcCandy.Text = "Chip Stock is running low, please refil";

                }
                else
                {
                    calcCandy.Text = "You have " + remainingCandy + " Candy units remaining";

                }

                intCandyInventory = remainingCandy;
            }

            else
            {
                lblCandyWarning.Visible = true;
            }
        }
    }
}
