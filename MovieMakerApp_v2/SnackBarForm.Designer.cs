
using System.Collections.Generic;

namespace MovieMakerApp_v2
{
    partial class SnackBarForm
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
            int tabIndex = 0;

            //initialise controls
            this.lblSnackBar = new System.Windows.Forms.Label();
            this.lblSnacks = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();

            this.snackItems = new List<System.Windows.Forms.Label>();
            this.snackQuantities = new List<System.Windows.Forms.NumericUpDown>();
            this.drinkItems = new List<System.Windows.Forms.Label>();
            this.drinkQuanitities = new List<System.Windows.Forms.NumericUpDown>();
            
            this.btnCheckout = new System.Windows.Forms.Button();
            
            foreach (var item in snackQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).BeginInit();
            }
            foreach (var item in drinkQuanitities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).BeginInit();
            }

            this.SuspendLayout();
            // 
            // lblSnackBar
            // 
            this.lblSnackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackBar.Location = new System.Drawing.Point(12, 9);
            this.lblSnackBar.Name = "lblSnackBar";
            this.lblSnackBar.Size = new System.Drawing.Size(776, 76);
            this.lblSnackBar.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnackBar.Text = "Snack Bar";
            this.lblSnackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnacks
            // 
            

            this.lblSnacks.AutoSize = true;
            this.lblSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnacks.Location = new System.Drawing.Point(14, 88);
            this.lblSnacks.Name = "lblSnacks";
            this.lblSnacks.Size = new System.Drawing.Size(114, 32);
            this.lblSnacks.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnacks.Text = "Snacks";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(424, 88);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(101, 32);
            this.lblDrinks.TabIndex = tabIndex;
            tabIndex++;
            this.lblDrinks.Text = "Drinks";
            // 
            // lblSnackItems
            // 
            int lblSnackY = 120;
            
            foreach (string snack in tm.GetAvailableSnacks())
            {
                lblSnackY += 25;
                this.snackItems.Add(new System.Windows.Forms.Label());
                this.snackItems[snackItems.Count - 1].AutoSize = true;
                this.snackItems[snackItems.Count - 1].Location = new System.Drawing.Point(17, lblSnackY);
                this.snackItems[snackItems.Count - 1].Name = $"lbl{snack}";
                this.snackItems[snackItems.Count - 1].Size = new System.Drawing.Size(77, 17);
                this.snackItems[snackItems.Count - 1].TabIndex = tabIndex;
                this.snackItems[snackItems.Count - 1].Text = snack;
                tabIndex++;

            }
            // 
            // nudSnackItems
            // 
            int nudSnackY = 120;
            int nudSnackIndex = 8;
            foreach (string snack in tm.GetAvailableSnacks())
            {
                nudSnackY += 25;
                this.snackQuantities.Add(new System.Windows.Forms.NumericUpDown());
                this.snackQuantities[this.snackQuantities.Count-1].Location = new System.Drawing.Point(119, nudSnackY);
                this.snackQuantities[this.snackQuantities.Count - 1].Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
                this.snackQuantities[this.snackQuantities.Count - 1].Name = $"nud{snack}";
                this.snackQuantities[this.snackQuantities.Count - 1].Size = new System.Drawing.Size(122, 22);
                this.snackQuantities[this.snackQuantities.Count - 1].TabIndex = tabIndex;
                tabIndex++;
            }
            // 
            // nudDrinkItems
            // 
            int drindQuantitiyY = 120;
            foreach (var item in tm.GetAvailableDrinks())
            {
                drindQuantitiyY += 25;
                drinkQuanitities.Add(new System.Windows.Forms.NumericUpDown());

                drinkQuanitities[drinkQuanitities.Count - 1].Location = new System.Drawing.Point(529, drindQuantitiyY);
                drinkQuanitities[drinkQuanitities.Count - 1].Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
                drinkQuanitities[drinkQuanitities.Count - 1].Name = $"nud{item}";
                drinkQuanitities[drinkQuanitities.Count - 1].Size = new System.Drawing.Size(122, 22);
                drinkQuanitities[drinkQuanitities.Count - 1].TabIndex = tabIndex;
                tabIndex++;
            }
            // 
            // lblDrinkItems
            // 
            int lblDrinkY = 120;
            foreach (var item in tm.GetAvailableDrinks())
            {
                lblDrinkY += 25;
                drinkItems.Add(new System.Windows.Forms.Label());
                drinkItems[drinkItems.Count-1].AutoSize = true;
                drinkItems[drinkItems.Count - 1].Location = new System.Drawing.Point(427, lblDrinkY);
                drinkItems[drinkItems.Count - 1].Name = $"lbl{item}";
                drinkItems[drinkItems.Count - 1].Size = new System.Drawing.Size(71, 17);
                drinkItems[drinkItems.Count - 1].TabIndex = tabIndex;
                tabIndex++;
                drinkItems[drinkItems.Count - 1].Text = item;
            }

           
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(334, 395);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(125, 43);
            this.btnCheckout.TabIndex = tabIndex;
            tabIndex++;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // SnackBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblSnacks);
            this.Controls.Add(this.lblSnackBar);

            // adding each snack label as a control on  snack bar form
            foreach (var item in snackItems)
            {
                this.Controls.Add(item);
            }
            // adding each snack quantity nud as a control on  snack bar form
            foreach (var item in snackQuantities)
            {
                this.Controls.Add(item);
            }
            // add each drink label as a control on the snack bar form
            foreach (var item in drinkItems)
            {
                this.Controls.Add(item);
            }
            // adding each drink quantity nud as a control on  snack bar form
            foreach (var item in drinkQuanitities)
            {
                this.Controls.Add(item);
            }



            this.Name = "SnackBarForm";
            this.Text = "Snack Bar ";
            foreach (System.Windows.Forms.NumericUpDown item in snackQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).EndInit();
            }
            foreach (System.Windows.Forms.NumericUpDown item in drinkQuanitities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).EndInit();
            }

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        //Declare controls
        private System.Windows.Forms.Label lblSnackBar;
        private System.Windows.Forms.Label lblSnacks;
        private System.Windows.Forms.Label lblDrinks;

        private List<System.Windows.Forms.Label> snackItems; 
        private List<System.Windows.Forms.NumericUpDown> snackQuantities;
        private List<System.Windows.Forms.Label> drinkItems;
        private List<System.Windows.Forms.NumericUpDown> drinkQuanitities;

        private System.Windows.Forms.Button btnCheckout;
    }
}