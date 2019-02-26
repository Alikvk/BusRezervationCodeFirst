using BusReservationProject.Classes;
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
    public partial class PassengerInfoForm : Form
    {

        private PurchaseTicketForm _purchaseTicketForm;
        private int _seatNumber=0;

        public PassengerInfoForm()
        {
          
        }
        public PassengerInfoForm(int seatNumber,PurchaseTicketForm purchaseTicketForm)
        {
            InitializeComponent();
            _seatNumber = seatNumber;
           lblSeatNumber.Text =Convert.ToString( _seatNumber);
            _purchaseTicketForm = purchaseTicketForm;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
          if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||                string.IsNullOrWhiteSpace(txtTCNo.Text) || string.IsNullOrWhiteSpace(mtxtPhone.Text) || comboxGender.Text == null )
            {
                MessageBox.Show("Boş Bırakılan yerleri doldurunuz");
                return;
            }
            Gender genderInfo;
            if (comboxGender.Text=="Erkek")
            {
                genderInfo = Gender.Male;
            }
            else
            {
                genderInfo = Gender.Female;
            }
            Passenger passenger = new Passenger() {
                FirstName = txtName.Text,
                SurName = txtSurname.Text,
                Gender = genderInfo,
                IdentificationNumber = txtTCNo.Text,
                PhoneNumber=mtxtPhone.Text,
                BirthDate = Convert.ToDateTime(dtpBirthDate.Text)
            };
            this.Close();
            _purchaseTicketForm.PurchaseTicket(passenger, _seatNumber);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
