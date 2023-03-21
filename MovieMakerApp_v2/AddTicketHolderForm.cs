using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMakerApp_v2
{
    public partial class AddTicketHolderForm : Form
    {
        TicketManager tm;

        public AddTicketHolderForm(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();
        }

        private void btnSnackBar_Click(object sender, EventArgs e)
        {

            // Add new ticket holder to tm 
            tm.AddTicketHolder(new TicketHolder(tbxTicketHolderName.Text, (int)nudAge.Value, (int)nudNoTickets.Value, rbnCard.Checked));

            // continue to snack bar form
            this.Hide();
            SnackBarForm myNewForm = new SnackBarForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
