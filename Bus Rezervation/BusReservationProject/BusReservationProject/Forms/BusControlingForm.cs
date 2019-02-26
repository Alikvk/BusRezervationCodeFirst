using BusReservationProject.Classes;
using BusReservationProject.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationProject.Forms
{
    public partial class BusControlingForm : Form
    {
        BusModel _busModel = new BusModel();
        List<Bus> _busList; // Otobüs comboboxımızı doldurmak için kullanıyoruz
        List<Trip> _tripList; // Listboxları sefer bilgilerini  doldurmak içiin kullanıcağız
        public BusControlingForm()
        {
            InitializeComponent();
            _tripList = new List<Trip>();

            _busList= _busModel.Buses.Select(bus => bus).ToList();

            comboxBusList.ValueMember = "BusId";
            comboxBusList.DisplayMember = "Plate";
            comboxBusList.DataSource = _busList;
            
        }


        private void BtnBusMove_Click(object sender, EventArgs e)
        {
            List<Trip> tripListMove = _busModel.Trips.Select(t => t).ToList();
            Trip tripCombo = (Trip)comboxTripList.SelectedItem;
  
            int passengerCount = Convert.ToInt32(txtPassengerCount.Text);

            lstPlate.Items.Add(comboxBusList.Text);
            //Aşağıdaki linq içinde kalkış ve varış isimleri eşit olan
            lstTotalPrice.Items.Add(tripListMove.Where(x => x.DepartureCity.CityName.Equals(tripCombo.DepartureCity.CityName) && x.DestinationCity.CityName.Equals(tripCombo.DestinationCity.CityName)).Sum(t => t.Price)*passengerCount );
            lstDate.Items.Add(DateTime.Now);

        }



        private void comboxBusList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Bus bus = (Bus)comboxBusList.SelectedItem;
            _tripList = _busModel.Trips.Where(x => x.Bus.BusId== bus.BusId).ToList();
            comboxTripList.ResetText();
            //comboxTripList.Items.Clear(); // DataSource Da sildiği için hata veriyot
            


            //var departureDestination = _tripList.Select(x => new
            //{
                
            //    Departure = x.DepartureCity.CityName,
            //    Destination = x.DestinationCity.CityName,
            //    x.TripId,
            //    x.TripPassengerInfo,
            //    x.Bus

            //}).ToList();

            comboxTripList.DataSource = _tripList;
            comboxTripList.ValueMember = "TripId";
            comboxTripList.DisplayMember = "DepartureCity.Name";

            //foreach (var item in departureDestination)
            //{
            //    comboxTripList.Items.Add(item.Departure + " => " + item.Destination);
         
            //}
            
        }

        private void comboxTripList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trip countList = (Trip)comboxTripList.SelectedItem;
            List<TripPassengerInfo> _passengerCount = _busModel.TripPassengerInfos.Where(x => x.TripId == countList.TripId).ToList();
            txtPassengerCount.Text = _passengerCount.Count().ToString();
        }

        // Sefer şehirlerini KALKIŞ = > VARIŞ şehri şeklinde göstermek amacıyla comboboxımızın format eventını değiştiriyoruz
        private void comboxTripList_Format(object sender, ListControlConvertEventArgs e)
        {
            var departure = ((Trip)e.ListItem).DepartureCity.CityName.ToString();
            var destination = ((Trip)e.ListItem).DestinationCity.CityName.ToString();
            e.Value = departure + " => " + destination;

        }

        private void BtnBusStateSave_Click(object sender, EventArgs e)
        {
            #region Descriptions
            // string path = System.AppDomain.CurrentDomain.BaseDirectory + @"Kayit\GunlukArsiv.txt";
            // yukarıdaki path çalıştırılan projenin içerisindeki bin klasörü içerisine gunluk arşiv şeklinde yazılmaktadır.


            // Using içerisindeki bulunan işlemleri yaptıktan sonra bellekten siliyor buda ramden yer kazanmamızı sağlıyor Burada örnek açısından uygulandı. Bu keywoed genelde garbage colloctorrun ne zaman geleceğini bilmeidğimiz durumlarda yapolan işlemden sonra kesin olrak çağrılmasını istediğimiz durumlarda kullanılır. https://stackoverflow.com/questions/75401/what-are-the-uses-of-using-in-c-sharp
            #endregion

            string path2;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Metin Dosyası|*.txt";
            saveFile.FileName = DateTime.Now.ToShortDateString();
            saveFile.OverwritePrompt = true;//üzerine yazılsın mı?
            saveFile.CreatePrompt = true; // Yoksa oluşturulsun mu?
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path2 = Path.GetFullPath(saveFile.FileName);
                int CountListboxItem = lstPlate.Items.Count;
                DailyArchive dailyArchive;
                using (StreamWriter writer = new StreamWriter(path2, true))

                    for (int i = 0; i < CountListboxItem; i++)
                    {
                        dailyArchive = new DailyArchive
                        {
                            ArchiveDate = Convert.ToDateTime(lstDate.Items[i]),
                            Plate = lstPlate.Items[i].ToString(),
                            TotalPrice = Convert.ToInt32(lstTotalPrice.Items[i])
                        };
                        _busModel.DailyArchives.Add(dailyArchive);
                        _busModel.SaveChanges();
                        writer.WriteLine($"Plaka: {lstPlate.Items[i].ToString()} Tarih: {lstDate.Items[i].ToString()} Toplam Gelir: {lstTotalPrice.Items[i].ToString()}");

                    }
                MessageBox.Show("Kaydedildi");
                lstPlate.Items.Clear();
                lstDate.Items.Clear();
                lstTotalPrice.Items.Clear();


            }
            else
            {
                return;
            }
         

            
            }


        private void BtnDailyArchive_Click(object sender, EventArgs e)
        {
            List<DailyArchive> dailyArchives = _busModel.DailyArchives.Select(x => x).ToList();
            foreach (var item in dailyArchives)
            {
               
                lstDailyArchive.Items.Add(item.ArchiveDate);
                lstDailyArchive.Items.Add(item.Plate);
                lstDailyArchive.Items.Add(item.TotalPrice);
                lstDailyArchive.Items.Add("------------------");



            }
        }
    }
    
}
