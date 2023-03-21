
namespace MovieMakerApp_v2
{
    partial class HomeForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddTicketHolder = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 103);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Movie Maker App";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTicketHolder
            // 
            this.btnAddTicketHolder.Location = new System.Drawing.Point(295, 115);
            this.btnAddTicketHolder.Name = "btnAddTicketHolder";
            this.btnAddTicketHolder.Size = new System.Drawing.Size(207, 71);
            this.btnAddTicketHolder.TabIndex = 1;
            this.btnAddTicketHolder.Text = "Add Ticket Holder";
            this.btnAddTicketHolder.UseVisualStyleBackColor = true;
            this.btnAddTicketHolder.Click += new System.EventHandler(this.btnAddTicketHolder_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(297, 190);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(207, 71);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "View Sale Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnAddTicketHolder);
            this.Controls.Add(this.lblTitle);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddTicketHolder;
        private System.Windows.Forms.Button btnStats;
    }
}

