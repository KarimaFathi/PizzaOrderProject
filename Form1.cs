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
        int totalTags = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSmallSize.Checked)
            {
                SizeTextBox.Text = rdSmallSize.Text;
                totalTags += Convert.ToInt32(rdSmallSize.Tag);
            }

            UpdateTotalPrice();
        }

        private void rdMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMediumSize.Checked)
            {
                SizeTextBox.Text = rdMediumSize.Text;
            }
            UpdateTotalPrice();
        }

        private void rdLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLargeSize.Checked)
            {
                SizeTextBox.Text = rdLargeSize.Text;
            }
            UpdateTotalPrice();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if( rdThinCrust.Checked)
            {
                CrustTextBox.Text = rdThinCrust.Text;
            }
            UpdateTotalPrice();
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThickCrust.Checked)
            {
                CrustTextBox.Text = rdThickCrust.Text;
            }
            UpdateTotalPrice();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");
                ToppingsTextBox.Text += chkExtraCheese.Text + ", ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkExtraCheese.Text + ", ", "");
            UpdateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");
                ToppingsTextBox.Text += chkMushrooms.Text + ", ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkMushrooms.Text + ", ", "");
            UpdateTotalPrice();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");
                ToppingsTextBox.Text += chkTomatoes.Text + ", ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkTomatoes.Text + ", ", "");
            UpdateTotalPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");

                ToppingsTextBox.Text += chkOnion.Text + ", ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkOnion.Text + ", ", "");
            UpdateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");
                ToppingsTextBox.Text += chkOlives.Text + ", ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkOlives.Text + ", ", "");
            UpdateTotalPrice();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPepper.Checked)
            {
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace("No toppings !", "");

                ToppingsTextBox.Text += chkGreenPepper.Text + " ";
            }
            else
                ToppingsTextBox.Text = ToppingsTextBox.Text.Replace(chkGreenPepper.Text + " ", "");
            UpdateTotalPrice();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rdEatIn.Checked)
                WhereToEatTextBox.Text = rdEatIn.Text;
         
        }

        private void rdEatOut_CheckedChanged(object sender, EventArgs e)
        {
            if(rdEatOut.Checked)
                  WhereToEatTextBox.Text = rdEatOut.Text;
           
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
            priceTextBox.Text = total.ToString() + "$";
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                grpCrustType.Enabled = false;
                grpSize.Enabled = false;
                grpWhereToEat.Enabled = false;
                grpToppings.Enabled = false;
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
