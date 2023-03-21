﻿
namespace MovieMakerApp_v2
{
    partial class AddTicketHolderForm
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
            this.lblTicketHolderName = new System.Windows.Forms.Label();
            this.tbxTicketHolderName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblNoTickets = new System.Windows.Forms.Label();
            this.nudNoTickets = new System.Windows.Forms.NumericUpDown();
            this.btnSnackBar = new System.Windows.Forms.Button();
            this.lblAddTicketHolder = new System.Windows.Forms.Label();
            this.rbnCash = new System.Windows.Forms.RadioButton();
            this.rbnCard = new System.Windows.Forms.RadioButton();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketHolderName
            // 
            this.lblTicketHolderName.AutoSize = true;
            this.lblTicketHolderName.Location = new System.Drawing.Point(9, 85);
            this.lblTicketHolderName.Name = "lblTicketHolderName";
            this.lblTicketHolderName.Size = new System.Drawing.Size(200, 17);
            this.lblTicketHolderName.TabIndex = 0;
            this.lblTicketHolderName.Text = "Enter the ticket holder\'s name:";
            // 
            // tbxTicketHolderName
            // 
            this.tbxTicketHolderName.Location = new System.Drawing.Point(12, 105);
            this.tbxTicketHolderName.Name = "tbxTicketHolderName";
            this.tbxTicketHolderName.Size = new System.Drawing.Size(205, 22);
            this.tbxTicketHolderName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 148);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(189, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Enter the ticket holder\'s age:";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 168);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(205, 22);
            this.nudAge.TabIndex = 3;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNoTickets
            // 
            this.lblNoTickets.AutoSize = true;
            this.lblNoTickets.Location = new System.Drawing.Point(9, 207);
            this.lblNoTickets.Name = "lblNoTickets";
            this.lblNoTickets.Size = new System.Drawing.Size(261, 17);
            this.lblNoTickets.TabIndex = 4;
            this.lblNoTickets.Text = "Enter the number of tickets to purchase:";
            // 
            // nudNoTickets
            // 
            this.nudNoTickets.Location = new System.Drawing.Point(12, 227);
            this.nudNoTickets.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudNoTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoTickets.Name = "nudNoTickets";
            this.nudNoTickets.Size = new System.Drawing.Size(205, 22);
            this.nudNoTickets.TabIndex = 5;
            this.nudNoTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSnackBar
            // 
            this.btnSnackBar.Location = new System.Drawing.Point(12, 331);
            this.btnSnackBar.Name = "btnSnackBar";
            this.btnSnackBar.Size = new System.Drawing.Size(211, 44);
            this.btnSnackBar.TabIndex = 6;
            this.btnSnackBar.Text = "Conitnue to Snack Bar";
            this.btnSnackBar.UseVisualStyleBackColor = true;
            this.btnSnackBar.Click += new System.EventHandler(this.btnSnackBar_Click);
            // 
            // lblAddTicketHolder
            // 
            this.lblAddTicketHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTicketHolder.Location = new System.Drawing.Point(12, 9);
            this.lblAddTicketHolder.Name = "lblAddTicketHolder";
            this.lblAddTicketHolder.Size = new System.Drawing.Size(776, 64);
            this.lblAddTicketHolder.TabIndex = 7;
            this.lblAddTicketHolder.Text = "Add New Ticket Holder";
            this.lblAddTicketHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbnCash
            // 
            this.rbnCash.AutoSize = true;
            this.rbnCash.Location = new System.Drawing.Point(12, 284);
            this.rbnCash.Name = "rbnCash";
            this.rbnCash.Size = new System.Drawing.Size(61, 21);
            this.rbnCash.TabIndex = 8;
            this.rbnCash.TabStop = true;
            this.rbnCash.Text = "Cash";
            this.rbnCash.UseVisualStyleBackColor = true;
            // 
            // rbnCard
            // 
            this.rbnCard.AutoSize = true;
            this.rbnCard.Location = new System.Drawing.Point(94, 284);
            this.rbnCard.Name = "rbnCard";
            this.rbnCard.Size = new System.Drawing.Size(59, 21);
            this.rbnCard.TabIndex = 9;
            this.rbnCard.TabStop = true;
            this.rbnCard.Text = "Card";
            this.rbnCard.UseVisualStyleBackColor = true;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(12, 264);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(169, 17);
            this.lblPaymentType.TabIndex = 10;
            this.lblPaymentType.Text = "Choose payment method:";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(611, 390);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(177, 48);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Cancel ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AddTicketHolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.rbnCard);
            this.Controls.Add(this.rbnCash);
            this.Controls.Add(this.lblAddTicketHolder);
            this.Controls.Add(this.btnSnackBar);
            this.Controls.Add(this.nudNoTickets);
            this.Controls.Add(this.lblNoTickets);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxTicketHolderName);
            this.Controls.Add(this.lblTicketHolderName);
            this.Name = "AddTicketHolderForm";
            this.Text = "Add Ticket Holder";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketHolderName;
        private System.Windows.Forms.TextBox tbxTicketHolderName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblNoTickets;
        private System.Windows.Forms.NumericUpDown nudNoTickets;
        private System.Windows.Forms.Button btnSnackBar;
        private System.Windows.Forms.Label lblAddTicketHolder;
        private System.Windows.Forms.RadioButton rbnCash;
        private System.Windows.Forms.RadioButton rbnCard;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnHome;
    }
}