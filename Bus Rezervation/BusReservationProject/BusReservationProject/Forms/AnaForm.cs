using BusReservationProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationProject
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
        }

        private void BtnPurchaseTicket_Click(object sender, EventArgs e)
        {
            PurchaseTicketForm pTicket = new PurchaseTicketForm();
            pTicket.Show();
        }
    }
}
