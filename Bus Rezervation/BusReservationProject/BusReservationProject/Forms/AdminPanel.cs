using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationProject.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BtnBusAdd_Click(object sender, EventArgs e)
        {
            ManageBussesForm manageBus = new ManageBussesForm();
            manageBus.Show();
        }

        private void BtnDriverAdd_Click(object sender, EventArgs e)
        {
            ManageDriversForm manageDriver = new ManageDriversForm();
            manageDriver.Show();
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            ControlForm controlForm = new ControlForm();
            controlForm.Show();

        }

        private void BtnBusControlling_Click(object sender, EventArgs e)
        {
            BusControlingForm busControl = new BusControlingForm();
            busControl.Show();
        }

        private void BtnCity_Click(object sender, EventArgs e)
        {
            ManageCities cityForm = new ManageCities();
            cityForm.Show();
        }
    }
}
