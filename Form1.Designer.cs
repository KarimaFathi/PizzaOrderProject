namespace PizzaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLargeSize = new System.Windows.Forms.RadioButton();
            this.rdMediumSize = new System.Windows.Forms.RadioButton();
            this.rdSmallSize = new System.Windows.Forms.RadioButton();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdEatOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.WhereToEatTextBox = new System.Windows.Forms.TextBox();
            this.CrustTextBox = new System.Windows.Forms.TextBox();
            this.ToppingsTextBox = new System.Windows.Forms.RichTextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA ";
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.rdLargeSize);
            this.grpSize.Controls.Add(this.rdMediumSize);
            this.grpSize.Controls.Add(this.rdSmallSize);
            this.grpSize.Location = new System.Drawing.Point(33, 89);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(166, 155);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Tag = "0";
            this.grpSize.Text = "Size";
            // 
            // rdLargeSize
            // 
            this.rdLargeSize.AutoSize = true;
            this.rdLargeSize.Location = new System.Drawing.Point(28, 111);
            this.rdLargeSize.Name = "rdLargeSize";
            this.rdLargeSize.Size = new System.Drawing.Size(75, 24);
            this.rdLargeSize.TabIndex = 2;
            this.rdLargeSize.Tag = "15";
            this.rdLargeSize.Text = "Large";
            this.rdLargeSize.UseVisualStyleBackColor = true;
            this.rdLargeSize.CheckedChanged += new System.EventHandler(this.rdLargeSize_CheckedChanged);
            // 
            // rdMediumSize
            // 
            this.rdMediumSize.AutoSize = true;
            this.rdMediumSize.Location = new System.Drawing.Point(28, 74);
            this.rdMediumSize.Name = "rdMediumSize";
            this.rdMediumSize.Size = new System.Drawing.Size(90, 24);
            this.rdMediumSize.TabIndex = 1;
            this.rdMediumSize.Tag = "10";
            this.rdMediumSize.Text = "Medium";
            this.rdMediumSize.UseVisualStyleBackColor = true;
            this.rdMediumSize.CheckedChanged += new System.EventHandler(this.rdMediumSize_CheckedChanged);
            // 
            // rdSmallSize
            // 
            this.rdSmallSize.AutoSize = true;
            this.rdSmallSize.Checked = true;
            this.rdSmallSize.Location = new System.Drawing.Point(28, 37);
            this.rdSmallSize.Name = "rdSmallSize";
            this.rdSmallSize.Size = new System.Drawing.Size(73, 24);
            this.rdSmallSize.TabIndex = 0;
            this.rdSmallSize.Tag = "5";
            this.rdSmallSize.Text = "Small";
            this.rdSmallSize.UseVisualStyleBackColor = true;
            this.rdSmallSize.CheckedChanged += new System.EventHandler(this.rdSmallSize_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.grpCrustType.Controls.Add(this.rdThickCrust);
            this.grpCrustType.Controls.Add(this.rdThinCrust);
            this.grpCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCrustType.Location = new System.Drawing.Point(33, 271);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(166, 124);
            this.grpCrustType.TabIndex = 2;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Tag = "0";
            this.grpCrustType.Text = "Crust type";
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.Location = new System.Drawing.Point(28, 82);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(110, 24);
            this.rdThickCrust.TabIndex = 1;
            this.rdThickCrust.Tag = "10";
            this.rdThickCrust.Text = "Thick crust";
            this.rdThickCrust.UseVisualStyleBackColor = true;
            this.rdThickCrust.CheckedChanged += new System.EventHandler(this.rdThickCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Checked = true;
            this.rdThinCrust.Location = new System.Drawing.Point(28, 37);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(103, 24);
            this.rdThinCrust.TabIndex = 0;
            this.rdThinCrust.Tag = "5";
            this.rdThinCrust.Text = "Thin crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkGreenPepper);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraCheese);
            this.grpToppings.Location = new System.Drawing.Point(229, 89);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(322, 145);
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Tag = "0";
            this.grpToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(167, 103);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(134, 24);
            this.chkGreenPepper.TabIndex = 5;
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.Text = "Green pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(167, 72);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 24);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(167, 41);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(77, 24);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(20, 101);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(106, 24);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(20, 71);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(118, 24);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(20, 41);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(128, 24);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.grpWhereToEat.Controls.Add(this.rdEatOut);
            this.grpWhereToEat.Controls.Add(this.rdEatIn);
            this.grpWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpWhereToEat.Location = new System.Drawing.Point(229, 271);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(322, 79);
            this.grpWhereToEat.TabIndex = 4;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to eat ";
            // 
            // rdEatOut
            // 
            this.rdEatOut.AutoSize = true;
            this.rdEatOut.Location = new System.Drawing.Point(167, 37);
            this.rdEatOut.Name = "rdEatOut";
            this.rdEatOut.Size = new System.Drawing.Size(86, 24);
            this.rdEatOut.TabIndex = 1;
            this.rdEatOut.Text = "Eat out";
            this.rdEatOut.UseVisualStyleBackColor = true;
            this.rdEatOut.CheckedChanged += new System.EventHandler(this.rdEatOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Checked = true;
            this.rdEatIn.Location = new System.Drawing.Point(28, 37);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(75, 24);
            this.rdEatIn.TabIndex = 0;
            this.rdEatIn.Text = "Eat in";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.priceTextBox);
            this.groupBox5.Controls.Add(this.WhereToEatTextBox);
            this.groupBox5.Controls.Add(this.CrustTextBox);
            this.groupBox5.Controls.Add(this.ToppingsTextBox);
            this.groupBox5.Controls.Add(this.SizeTextBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(567, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 418);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order summary";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(75, 368);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 26);
            this.priceTextBox.TabIndex = 9;
            // 
            // WhereToEatTextBox
            // 
            this.WhereToEatTextBox.Location = new System.Drawing.Point(75, 295);
            this.WhereToEatTextBox.Name = "WhereToEatTextBox";
            this.WhereToEatTextBox.Size = new System.Drawing.Size(125, 26);
            this.WhereToEatTextBox.TabIndex = 8;
            this.WhereToEatTextBox.Text = "Eat in";
            // 
            // CrustTextBox
            // 
            this.CrustTextBox.Location = new System.Drawing.Point(75, 229);
            this.CrustTextBox.Name = "CrustTextBox";
            this.CrustTextBox.Size = new System.Drawing.Size(125, 26);
            this.CrustTextBox.TabIndex = 7;
            this.CrustTextBox.Text = "Thin crust";
            // 
            // ToppingsTextBox
            // 
            this.ToppingsTextBox.Location = new System.Drawing.Point(75, 109);
            this.ToppingsTextBox.Name = "ToppingsTextBox";
            this.ToppingsTextBox.Size = new System.Drawing.Size(245, 70);
            this.ToppingsTextBox.TabIndex = 6;
            this.ToppingsTextBox.Text = "No toppings !";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(75, 31);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(125, 26);
            this.SizeTextBox.TabIndex = 5;
            this.SizeTextBox.Text = "Small";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where to eat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crust type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size : ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(240, 379);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(137, 41);
            this.btnOrderPizza.TabIndex = 6;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(396, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 41);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 539);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdLargeSize;
        private System.Windows.Forms.RadioButton rdMediumSize;
        private System.Windows.Forms.RadioButton rdSmallSize;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton rdEatOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ToppingsTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox WhereToEatTextBox;
        private System.Windows.Forms.TextBox CrustTextBox;
    }
}

