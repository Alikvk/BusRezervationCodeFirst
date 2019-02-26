namespace BusReservationProject.Forms
{
    partial class PurchaseTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTicketPurchase = new System.Windows.Forms.GroupBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpTicket = new System.Windows.Forms.DateTimePicker();
            this.comboxDestination = new System.Windows.Forms.ComboBox();
            this.comboxDeparture = new System.Windows.Forms.ComboBox();
            this.comboxBus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusSeat = new System.Windows.Forms.Panel();
            this.pbPictureBus = new System.Windows.Forms.PictureBox();
            this.lblBusName = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.gbTicketPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBus)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTicketPurchase
            // 
            this.gbTicketPurchase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTicketPurchase.Controls.Add(this.lblPlate);
            this.gbTicketPurchase.Controls.Add(this.nudPrice);
            this.gbTicketPurchase.Controls.Add(this.dtpTicket);
            this.gbTicketPurchase.Controls.Add(this.comboxDestination);
            this.gbTicketPurchase.Controls.Add(this.comboxDeparture);
            this.gbTicketPurchase.Controls.Add(this.comboxBus);
            this.gbTicketPurchase.Controls.Add(this.label5);
            this.gbTicketPurchase.Controls.Add(this.label4);
            this.gbTicketPurchase.Controls.Add(this.label3);
            this.gbTicketPurchase.Controls.Add(this.label2);
            this.gbTicketPurchase.Controls.Add(this.label1);
            this.gbTicketPurchase.Location = new System.Drawing.Point(2, 2);
            this.gbTicketPurchase.Name = "gbTicketPurchase";
            this.gbTicketPurchase.Size = new System.Drawing.Size(200, 362);
            this.gbTicketPurchase.TabIndex = 0;
            this.gbTicketPurchase.TabStop = false;
            this.gbTicketPurchase.Text = "Bilet İşlemleri";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(54, 305);
            this.nudPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dtpTicket
            // 
            this.dtpTicket.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTicket.Location = new System.Drawing.Point(53, 232);
            this.dtpTicket.Name = "dtpTicket";
            this.dtpTicket.Size = new System.Drawing.Size(121, 20);
            this.dtpTicket.TabIndex = 2;
            // 
            // comboxDestination
            // 
            this.comboxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDestination.FormattingEnabled = true;
            this.comboxDestination.Location = new System.Drawing.Point(53, 160);
            this.comboxDestination.Name = "comboxDestination";
            this.comboxDestination.Size = new System.Drawing.Size(121, 21);
            this.comboxDestination.TabIndex = 1;
            this.comboxDestination.SelectedIndexChanged += new System.EventHandler(this.comboxDestination_SelectedIndexChanged);
            // 
            // comboxDeparture
            // 
            this.comboxDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDeparture.FormattingEnabled = true;
            this.comboxDeparture.Location = new System.Drawing.Point(52, 96);
            this.comboxDeparture.Name = "comboxDeparture";
            this.comboxDeparture.Size = new System.Drawing.Size(121, 21);
            this.comboxDeparture.TabIndex = 1;
            this.comboxDeparture.SelectedIndexChanged += new System.EventHandler(this.comboxDeparture_SelectedIndexChanged);
            // 
            // comboxBus
            // 
            this.comboxBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBus.FormattingEnabled = true;
            this.comboxBus.Location = new System.Drawing.Point(52, 29);
            this.comboxBus.Name = "comboxBus";
            this.comboxBus.Size = new System.Drawing.Size(121, 21);
            this.comboxBus.TabIndex = 1;
            this.comboxBus.SelectedIndexChanged += new System.EventHandler(this.comboxBus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Varış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kalkış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otobüs";
            // 
            // panelBusSeat
            // 
            this.panelBusSeat.Location = new System.Drawing.Point(209, 31);
            this.panelBusSeat.Name = "panelBusSeat";
            this.panelBusSeat.Size = new System.Drawing.Size(306, 333);
            this.panelBusSeat.TabIndex = 1;
            // 
            // pbPictureBus
            // 
            this.pbPictureBus.Location = new System.Drawing.Point(521, 2);
            this.pbPictureBus.Name = "pbPictureBus";
            this.pbPictureBus.Size = new System.Drawing.Size(191, 320);
            this.pbPictureBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureBus.TabIndex = 2;
            this.pbPictureBus.TabStop = false;
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Location = new System.Drawing.Point(209, 12);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(0, 13);
            this.lblBusName.TabIndex = 3;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(51, 63);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(14, 15);
            this.lblPlate.TabIndex = 17;
            this.lblPlate.Text = "s";
            // 
            // PurchaseTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 367);
            this.Controls.Add(this.lblBusName);
            this.Controls.Add(this.pbPictureBus);
            this.Controls.Add(this.panelBusSeat);
            this.Controls.Add(this.gbTicketPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PurchaseTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseTicket";
            this.Load += new System.EventHandler(this.PurchaseTicketForm_Load);
            this.gbTicketPurchase.ResumeLayout(false);
            this.gbTicketPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTicketPurchase;
        private System.Windows.Forms.ComboBox comboxDestination;
        private System.Windows.Forms.ComboBox comboxDeparture;
        private System.Windows.Forms.ComboBox comboxBus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBusSeat;
        private System.Windows.Forms.PictureBox pbPictureBus;
        private System.Windows.Forms.DateTimePicker dtpTicket;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.Label lblPlate;
    }
}