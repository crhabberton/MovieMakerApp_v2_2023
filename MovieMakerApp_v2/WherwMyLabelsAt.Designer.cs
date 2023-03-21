
using System.Collections.Generic;

namespace MovieMakerApp_v2
{
    partial class WherwMyLabelsAt
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

            //Initialising controls
            this.lblSnackItem = new System.Windows.Forms.Label();
            this.snackItems = new List<System.Windows.Forms.Label>();
            this.nudSnackQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnackQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSnackItems
            // 

            int lblSnackY = 65; 

            foreach (var item in tm.GetAvailableSnacks())
            {
                snackItems.Add(new System.Windows.Forms.Label());
                lblSnackY += 25;

                this.snackItems[snackItems.Count - 1].AutoSize = true;
                this.snackItems[snackItems.Count - 1].Location = new System.Drawing.Point(85, lblSnackY);
                this.snackItems[snackItems.Count - 1].Name = $"lbl{item}";
                this.snackItems[snackItems.Count - 1].Size = new System.Drawing.Size(96, 21);
                this.snackItems[snackItems.Count - 1].TabIndex = tabIndex;
                tabIndex++;
                this.snackItems[snackItems.Count - 1].Text = item;
            }

            this.lblSnackItem.AutoSize = true;
            this.lblSnackItem.Location = new System.Drawing.Point(85, 90);
            this.lblSnackItem.Name = "lblSnackItem";
            this.lblSnackItem.Size = new System.Drawing.Size(96, 21);
            this.lblSnackItem.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnackItem.Text = "Snack Item";
            // 
            // nudSnackQuantity
            // 
            this.nudSnackQuantity.Location = new System.Drawing.Point(187, 88);
            this.nudSnackQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSnackQuantity.Name = "nudSnackQuantity";
            this.nudSnackQuantity.Size = new System.Drawing.Size(146, 22);
            this.nudSnackQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // WherwMyLabelsAt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudSnackQuantity);
            this.Controls.Add(this.lblSnackItem);

            foreach (var item in snackItems)
            {
                this.Controls.Add(item);
            }

            this.Name = "WherwMyLabelsAt";
            this.Text = "WherwMyLabelsAt";

            ((System.ComponentModel.ISupportInitialize)(this.nudSnackQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Decalring controls
        private System.Windows.Forms.Label lblSnackItem;
        private List<System.Windows.Forms.Label> snackItems;
        private System.Windows.Forms.NumericUpDown nudSnackQuantity;
    }
}