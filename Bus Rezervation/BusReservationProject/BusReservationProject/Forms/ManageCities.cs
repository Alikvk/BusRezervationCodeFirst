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
    public partial class ManageCities : Form
    {
        BusModel _busModel = new BusModel();
        int _secilenID;
        public ManageCities()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityName = txtCityName.Text;
            _busModel.Cities.Add(city);
            _busModel.SaveChanges();
            CityListe();
            ClearInput();

        }

        private void ClearInput()
        {
            txtCityName.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                City city = _busModel.Cities.Find(_secilenID); // Datagridview den seçilen şehiri bulup textbox içerisinde bulunan text ile güncelliyoruz
                city.CityName = txtCityName.Text;
                _busModel.SaveChanges();
                CityListe();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir Şehir Seçinizi");

                MessageBox.Show("Hata ile karşılaşıldı" + ex.Message);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                City city = _busModel.Cities.Find(_secilenID);
                _busModel.Cities.Remove(city);
                _busModel.SaveChanges();
                CityListe();
                ClearInput();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir Şehir Seçinizi");

            }
        }

        private void dgvCityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCityList.CurrentRow == null || e.RowIndex == -1)
                return;


            _secilenID = Convert.ToInt32(dgvCityList.CurrentRow.Cells[0].Value);
            City city = _busModel.Cities.Find(_secilenID);
            txtCityName.Text = city.CityName;
        }

        private void ManageCities_Load(object sender, EventArgs e)
        {
            CityListe();

        }

        private void CityListe()
        {
           List<City> cityList = _busModel.Cities.Select(c => c).ToList();

            dgvCityList.DataSource = cityList;

        }
    }
}
