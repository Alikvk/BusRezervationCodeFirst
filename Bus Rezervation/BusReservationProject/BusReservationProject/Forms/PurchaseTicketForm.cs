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
    public partial class PurchaseTicketForm : Form
    {
        BusModel _busModel = new BusModel();
        private Bus _bus;
        private object _BtnSender; // O an basılan butonun değerini tutmak için tanımlandı
        private City _ChooseDepartureCity, _ChooseDestinationCity;

        //Form yüklenirken gerekli bilgilerin comboboxlara yüklenmesi ve koltukların doldurulma işlemlerini yapmaktadır.
        public PurchaseTicketForm()
        {
            InitializeComponent();

            _bus = null; // İlk Açıldığında içerisinde  herhangi bir değer bulunmamamkta

            _ChooseDepartureCity = (City)_busModel.Trips.Select(x => x.DepartureCity).FirstOrDefault();

            _ChooseDestinationCity = (City)_busModel.Trips.Select(x => x.DestinationCity).FirstOrDefault();
            //  _busModel.Cities.FirstOrDefault();

            comboxBus.DisplayMember = "Name";
            comboxBus.ValueMember = "BusId";
            comboxBus.DataSource = _busModel.Buses.Select(bus => bus).ToList();
            

            comboxDeparture.DisplayMember = "CityName";
            comboxDeparture.ValueMember = "CityId";
            comboxDeparture.DataSource = _busModel.Cities.Select(city => city).ToList();



            comboxDestination.DisplayMember = "CityName";
            comboxDestination.ValueMember = "CityId";
            comboxDestination.DataSource = _busModel.Cities.Select(city => city).ToList();
            WritePlate();



        }

        //Seçilen otobüs ismine hangi plakanın sahip olduğunu göstermektedir.
        private void WritePlate()
        {
            // Aşağıdaki linq işlemi otobüs içinde seçilen otobüs ID nin seçilen değerin ID sine eşit olup burada plakanın ilkini alıp toString işlemiyle labele yazdırıyoruz
            lblPlate.Text = _busModel.Buses.Where(x=>x.BusId == (int)comboxBus.SelectedValue).Select(bus => bus.Plate).FirstOrDefault().ToString();
        }

        private void PurchaseTicketForm_Load(object sender, EventArgs e)
        {
           // FillSeat();
            SeatRezervationBefore();

        }

        // Otobüs değiştirildiğinde yapılacak işlemler
        private void comboxBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboxBus.SelectedIndex == -1)
                return;

           
            _bus = (Bus)comboxBus.SelectedItem;
            lblBusName.Text = _bus.Name;
            pbPictureBus.Image = (Image)((new ImageConverter()).ConvertFrom(_bus.Image));
            SeatRezervationBefore(); 
            WritePlate();

        }
        
        //kalkış şehrinin değiştirildiği zaman yapılan işlemler

        private void comboxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxDeparture.SelectedIndex == -1)
                return;

            _ChooseDepartureCity = (City)comboxDeparture.SelectedItem;
            SeatRezervationBefore();
            WritePlate();
        }

        //varış şehrinin değiştirildiği zaman yapılan işlemler
        private void comboxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxDestination.SelectedIndex == -1)
                return;

            _ChooseDestinationCity = (City)comboxDestination.SelectedItem;
           SeatRezervationBefore();
            WritePlate();
        }
        //Koltuk doldurma işlemini methodunu yapmaktadır.
        private void FillSeat()
        {
            panelBusSeat.Controls.Clear();
            int seatCount = _bus.SeatCount;

            int number = 1;
            for (int i = 0; i <(int)( Math.Ceiling((double) seatCount/4)); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2 || i * j > seatCount)
                    {

                        continue;
                    }
                    Button newButton = new Button();
                    newButton.Text = (number).ToString();
                    newButton.Location = new Point(15 + (j * 56), 25 + (i * 46));
                    newButton.Width = 50;
                    newButton.Height = 40;
                    newButton.BackColor = Color.Orange;
                    newButton.Name = "Seat" + (number++);
                    newButton.Click += new EventHandler(newSeat_Click);
                   
                    panelBusSeat.Controls.Add(newButton);
                }

            }
            
        }

        //Daha önceden rezervason yapılan koltuklar var mı diye kontrol edip bunları belirten fonksiyon
        private void SeatRezervationBefore()
        {
            panelBusSeat.Controls.Clear();
            Trip trip=new Trip();
            if (!(_ChooseDepartureCity==null) && !(_ChooseDestinationCity == null))
            {
                 trip = _busModel.Trips.FirstOrDefault(t => t.DepartureCity.CityId == _ChooseDepartureCity.CityId && t.DestinationCity.CityId == _ChooseDestinationCity.CityId &&
             t.Bus.BusId == (int)comboxBus.SelectedValue);
            }
         
            FillSeat();
            if (trip != null)
            {
                List<TripPassengerInfo> tripPassengerInfos = trip.TripPassengerInfo.ToList();
                foreach (TripPassengerInfo t in tripPassengerInfos)
                {
                    if (t.Passenger.Gender == Gender.Male)
                    {
                        panelBusSeat.Controls[t.SeatNumber - 1].BackColor = Color.Red; //Controls içinde 0 değerinden itibaren tuttuğu için 1 eksiğini almaktayız
                    }
                    else
                    {
                        panelBusSeat.Controls[t.SeatNumber - 1].BackColor = Color.HotPink;
                    }
                    panelBusSeat.Controls[t.SeatNumber-1].Enabled = false;
                   

                }
            }
        }

        //Her oluşturulan koltuk için click eventı aşağıdaki methotta tanımlıyoruz
        private void newSeat_Click(object sender, EventArgs e)
        {
            PassengerInfoForm passInfo = new PassengerInfoForm(Convert.ToInt32(this.ActiveControl.Text), this);
            passInfo.Show();
            
            _BtnSender = sender;
            
         
        }

        //Kullanıcı bilgileri girildikten sonra gelen verileri database kaydetme işlemlerini yapmaktayız
        public void PurchaseTicket(Passenger passenger , int seatNumber)
        {
            Trip trip = _busModel.Trips.FirstOrDefault(t => t.DepartureCity.CityId == (int)comboxDeparture.SelectedValue && t.DestinationCity.CityId == (int)comboxDestination.SelectedValue &&
              t.Bus.BusId == (int)comboxBus.SelectedValue);

            if (trip == null)
            {
                trip = new Trip()
                {

                    DestinationCity = (City)comboxDestination.SelectedItem,
                    Bus = (Bus)comboxBus.SelectedItem,
                    DepartureCity = (City)comboxDeparture.SelectedItem,
                    Price = nudPrice.Value,
                    DepartureTime = Convert.ToDateTime(dtpTicket.Text)
                };

                _busModel.Trips.Add(trip);
                _busModel.SaveChanges();
            }

            TripPassengerInfo tripPassengerInfo = new TripPassengerInfo()
            {
                Passenger = passenger,
                SeatNumber = seatNumber
            };

            trip.TripPassengerInfo.Add(tripPassengerInfo);
            _busModel.SaveChanges();
            if (passenger.Gender == Gender.Male)
            {
                ((Control)_BtnSender).BackColor = Color.Red;

            }
            else
            {
                ((Control)_BtnSender).BackColor = Color.HotPink;
            }
          ((Control)_BtnSender).Enabled = false;
            SeatRezervationBefore();
        }

       
    }
}
