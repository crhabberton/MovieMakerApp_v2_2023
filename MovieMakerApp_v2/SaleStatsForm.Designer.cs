
namespace MovieMakerApp_v2
{
    partial class SaleStatsForm
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
            this.rtbSnackStats = new System.Windows.Forms.RichTextBox();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblSalesStats = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSnackStats
            // 
            this.rtbSnackStats.Location = new System.Drawing.Point(12, 84);
            this.rtbSnackStats.Name = "rtbSnackStats";
            this.rtbSnackStats.ReadOnly = true;
            this.rtbSnackStats.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSnackStats.Size = new System.Drawing.Size(383, 354);
            this.rtbSnackStats.TabIndex = 0;
            this.rtbSnackStats.Text = "";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(401, 84);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(387, 86);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "Total Profit : $";
            // 
            // lblSalesStats
            // 
            this.lblSalesStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesStats.Location = new System.Drawing.Point(12, 9);
            this.lblSalesStats.Name = "lblSalesStats";
            this.lblSalesStats.Size = new System.Drawing.Size(776, 51);
            this.lblSalesStats.TabIndex = 2;
            this.lblSalesStats.Text = "Sales Statistics";
            this.lblSalesStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(635, 384);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(153, 54);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Back to home Screen";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SaleStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSalesStats);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.rtbSnackStats);
            this.Name = "SaleStatsForm";
            this.Text = "Sales Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSnackStats;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblSalesStats;
        private System.Windows.Forms.Button btnHome;
    }
}