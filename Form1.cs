using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            updateWhereToEat();
            UpdateTotalPrice();

        }
        private void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdSmallSize.Checked)
            {
                SizeTextBox.Text = rdSmallSize.Text;
                return;
            }
            if (rdMediumSize.Checked)
            {
                SizeTextBox.Text = rdMediumSize.Text;
                return;
            }
            if (rdLargeSize.Checked)
            {
                SizeTextBox.Text = rdLargeSize.Text;
                return;
            }


        }
        private void rdSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rdThinCrust.Checked)
            {
                CrustTextBox.Text = rdThinCrust.Text;
                return;
            }
            if (rdThickCrust.Checked)
            {
                CrustTextBox.Text = rdThickCrust.Text;
                return;
            }

        }
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();

        }


        private void UpdateToppings()
        {
            UpdateTotalPrice();
            string toppings = "";
            if (chkExtraCheese.Checked)
            {
                toppings += ", " + chkExtraCheese.Text;
            }

            if (chkMushrooms.Checked)
            {
                toppings += ", " + chkMushrooms.Text;
            }

            if (chkTomatoes.Checked)
            {
                toppings += ", " + chkTomatoes.Text;
            }
            if (chkOnion.Checked)
            {
                toppings += ", " + chkOnion.Text;
            }
            if (chkOlives.Checked)
            {
                toppings += ", " + chkOlives.Text;
            }
            if (chkGreenPepper.Checked)
            {
                toppings += ", " + chkGreenPepper.Text;
            }
            
            if(toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1).Trim();
            }

            if(toppings == "")
            {
                toppings = "No toppings.";
            }
            ToppingsTextBox.Text = toppings;
        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void updateWhereToEat()
        {
            if (rdEatIn.Checked)
            {
                WhereToEatTextBox.Text = rdEatIn.Text;
                return;
            }
            if (rdEatOut.Checked)
            {
                WhereToEatTextBox.Text = rdEatOut.Text;
                return;
            }

        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rdEatOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void UpdateTotalPrice()
        {
            int total = 0;

            // Add size price
            if (rdSmallSize.Checked)
                total += Convert.ToInt32(rdSmallSize.Tag);
            else if (rdMediumSize.Checked)
                total += Convert.ToInt32(rdMediumSize.Tag);
            else if (rdLargeSize.Checked)
                total += Convert.ToInt32(rdLargeSize.Tag);

            // Add crust price
            if (rdThinCrust.Checked)
                total += Convert.ToInt32(rdThinCrust.Tag);
            else if (rdThickCrust.Checked)
                total += Convert.ToInt32(rdThickCrust.Tag);

            // Add toppings price
            if (chkExtraCheese.Checked)
                total += Convert.ToInt32(chkExtraCheese.Tag);
            if (chkMushrooms.Checked)
                total += Convert.ToInt32(chkMushrooms.Tag);
            if (chkTomatoes.Checked)
                total += Convert.ToInt32(chkTomatoes.Tag);
            if (chkOnion.Checked)
                total += Convert.ToInt32(chkOnion.Tag);
            if (chkOlives.Checked)
                total += Convert.ToInt32(chkOlives.Tag);
            if (chkGreenPepper.Checked)
                total += Convert.ToInt32(chkGreenPepper.Tag);

            // Display price
            priceTextBox.Text = "$" + total.ToString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm your order ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                grpCrustType.Enabled = false;
                grpSize.Enabled = false;
                grpWhereToEat.Enabled = false;
                grpToppings.Enabled = false;
            } else
            {
                MessageBox.Show("Update your order", "Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        void ResetForm()
        {
            //reset groups
            grpCrustType.Enabled = true;
            grpSize.Enabled = true;
            grpWhereToEat.Enabled = true;
            grpToppings.Enabled = true;

            //reset size
            rdSmallSize.Checked = true;

            //reset crust type
            rdThinCrust.Checked = true;

            //reset where to eat 
            rdEatIn.Checked = true;

            //reset toppings
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPepper.Checked = false;

            //reset Order button
            btnOrderPizza.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        

    }
}
