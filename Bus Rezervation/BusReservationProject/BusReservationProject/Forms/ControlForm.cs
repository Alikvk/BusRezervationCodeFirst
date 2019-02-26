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
    public partial class ControlForm : Form
    {
        BusModel _busModel = new BusModel();
        //  Trip _trip;
      
        public ControlForm()
        {
            InitializeComponent();
            // _trip = new Trip();

            comboxBus.DisplayMember = "Plate";
            comboxBus.ValueMember = "BusID";
            comboxBus.DataSource = _busModel.Buses.ToList();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            var joinTable = from tpinfo in _busModel.TripPassengerInfos
                            join trp in _busModel.Trips
                            on tpinfo.TripId equals trp.TripId
                            select new
                            {
                                tpinfo.Passenger,
                                tpinfo.SeatNumber,
                                trp.Price,
                                trp.Bus,
                                trp.DepartureCity,
                                trp.DestinationCity,
                                trp.DepartureTime
                            };

            // Linq Lambda Expression
            //var joinTable2 = _busModel.TripPassengerInfos.Join(_busModel.Trips, tripPass => tripPass.TripId, trip => trip.TripId, (tripPass, trip) => new { TripPassengerInfo = tripPass, Trip = trip }).Select(x => new
            //{
            //    x.TripPassengerInfo.Passenger,
            //    x.TripPassengerInfo.SeatNumber,
            //    x.Trip.Price,
            //    x.Trip.DepartureCity,
            //    x.Trip.DestinationCity,
            //    x.Trip.DepartureTime

            //});
            foreach (var item in joinTable)
            {
                lstNameSurname.Items.Add(item.Passenger.FirstName + " " + item.Passenger.SurName);
                lstPlate.Items.Add(item.Bus.Plate);
                lstPrice.Items.Add(item.Price);
                lstSeatNumber.Items.Add(item.SeatNumber);
                lstTrip.Items.Add(item.DepartureCity.CityName + " -> " + item.DestinationCity.CityName);
            }
            
        }

        private void comboxBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            Bus bus = (Bus)comboxBus.SelectedItem; // Selecteditem içerisinde bus classında bulunan propertlerin içerikleri vardır.
          
            var joinTable = from tpinfo in _busModel.TripPassengerInfos
                            join trp in _busModel.Trips
                            on tpinfo.TripId equals trp.TripId
                            select new
                            {
                                tpinfo.Passenger,
                                tpinfo.SeatNumber,
                                trp.Price,
                                trp.Bus,
                                trp.DepartureCity,
                                trp.DestinationCity,
                                trp.DepartureTime
                            };

            var totalTicketPrice = joinTable.Where(x => x.Bus.Plate == bus.Plate).ToList();
            if (totalTicketPrice != null)
            {
                totalPrice = Convert.ToDecimal(totalTicketPrice.Sum(x => x.Price));
            }
            lblTotalPrice.Text = totalPrice.ToString();
        }
    }
}
