using BusReservationProject.Classes;
using BusReservationProject.Context;
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
    public partial class ManageDriversForm : Form
    {
        BusModel _busModel = new BusModel();
        private int _secilenID;

        public ManageDriversForm()
        {
            InitializeComponent();


            DriverListe();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.FirstName = txtName.Text;
            driver.SurName = txtSurname.Text;
            _busModel.Drivers.Add(driver);
            _busModel.SaveChanges();
            DriverListe();
        }

        private void DriverListe()
        {
            dgvDriverList.DataSource = _busModel.Drivers.Select(driver => driver).ToList();
        }

        private void dgvDriverList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDriverList.CurrentRow == null || e.RowIndex == -1)
                return;


            _secilenID = Convert.ToInt32(dgvDriverList.CurrentRow.Cells[0].Value);
            Driver driver = _busModel.Drivers.Find(_secilenID);
            txtName.Text = driver.FirstName;
            txtSurname.Text = driver.SurName;
    
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = _busModel.Drivers.Find(_secilenID); // Datagridview den seçilen şehiri bulup textbox içerisinde bulunan text ile güncelliyoruz
                driver.FirstName = txtName.Text;
                driver.SurName = txtSurname.Text;

                _busModel.SaveChanges();
                DriverListe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir Şoför Seçinizi");

                MessageBox.Show("Hata ile karşılaşıldı" + ex.Message);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = _busModel.Drivers.Find(_secilenID);
                _busModel.Drivers.Remove(driver);
                _busModel.SaveChanges();
                DriverListe();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir Şoför Seçinizi");

            }
        }
    }
}
