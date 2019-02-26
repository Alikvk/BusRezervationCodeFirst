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
    public partial class ManageBussesForm : Form
    {
        BusModel _busModel = new BusModel();
        int _secilenID;


        public ManageBussesForm()
        {
            InitializeComponent();
            comboxDriver.DisplayMember = "FirstName";
            comboxDriver.ValueMember = "DriverID";
            comboxDriver.DataSource = _busModel.Drivers.Select(driver => driver).ToList();
            //Yukarıdaki ve aşağıdaki aynı görevi görmektedir.
            //comboxDriver.DataSource= _busModel.Drivers.Select(driver => new { driver.DriverId,driver.FirstName,driver.SurName}).ToList();
            BusListe();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text) || pbBusPicture.Image == null)
            {
                MessageBox.Show("Bilgiler Eksiktir Lütfen Doldurunuz");
                return;
            }

            Bus bus = new Bus()
            {
                Name = txtName.Text,
                Plate = txtPlateNumber.Text,
                SeatCount = (int)nudSeatCount.Value,
                Image = AuxiliaryMethods.ImageToByteArray(pbBusPicture.Image),
                Driver = (Driver)comboxDriver.SelectedItem
            };
            _busModel.Buses.Add(bus);
            _busModel.SaveChanges();

            BusListe();
        }

        private void BusListe()
        {
            dgvBusList.DataSource = _busModel.Buses.Select(bus => bus).ToList();

        }

        private void pbBusPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = dialog.FileName;
                pbBusPicture.Image = new Bitmap(dialog.FileName);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Bus bus = _busModel.Buses.Find(_secilenID); // Datagridview den seçilen şehiri bulup textbox içerisinde bulunan text ile güncelliyoruz
                bus.Name = txtName.Text;
                bus.Plate = txtPlateNumber.Text;
                bus.SeatCount =(int) nudSeatCount.Value;
                bus.Image = AuxiliaryMethods.ImageToByteArray(pbBusPicture.Image);
                _busModel.SaveChanges();
                BusListe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir Şoför Seçinizi");

                MessageBox.Show("Hata ile karşılaşıldı" + ex.Message);

            }

            _busModel.SaveChanges();
        }

        private void dgvBusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvBusList.CurrentRow == null || e.RowIndex == -1)
                return;


            _secilenID = Convert.ToInt32(dgvBusList.CurrentRow.Cells[0].Value);
            Bus selectedBus = _busModel.Buses.Find(_secilenID);
            txtName.Text = selectedBus.Name;
            txtPlateNumber.Text = selectedBus.Plate;
            nudSeatCount.Value = selectedBus.SeatCount;
            comboxDriver.SelectedItem = selectedBus.Driver;
            pbBusPicture.Image = (Image)((new ImageConverter()).ConvertFrom(selectedBus.Image));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Bus bus = _busModel.Buses.Find(_secilenID);
                _busModel.Buses.Remove(bus);
                _busModel.SaveChanges();
                BusListe();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir Şoför Seçinizi");

            }
        }
    }
}
