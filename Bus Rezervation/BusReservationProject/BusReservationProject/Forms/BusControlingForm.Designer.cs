namespace BusReservationProject.Forms
{
    partial class BusControlingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBusMove = new System.Windows.Forms.Button();
            this.txtPassengerCount = new System.Windows.Forms.TextBox();
            this.comboxTripList = new System.Windows.Forms.ComboBox();
            this.comboxBusList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDailyArchive = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBusStateSave = new System.Windows.Forms.Button();
            this.lstDailyArchive = new System.Windows.Forms.ListBox();
            this.lstTotalPrice = new System.Windows.Forms.ListBox();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lstPlate = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnBusMove);
            this.groupBox1.Controls.Add(this.txtPassengerCount);
            this.groupBox1.Controls.Add(this.comboxTripList);
            this.groupBox1.Controls.Add(this.comboxBusList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Takip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kişi Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sefer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Otobüs";
            // 
            // BtnBusMove
            // 
            this.BtnBusMove.Location = new System.Drawing.Point(167, 134);
            this.BtnBusMove.Name = "BtnBusMove";
            this.BtnBusMove.Size = new System.Drawing.Size(121, 42);
            this.BtnBusMove.TabIndex = 2;
            this.BtnBusMove.Text = "Araç Hareketlendir";
            this.BtnBusMove.UseVisualStyleBackColor = true;
            this.BtnBusMove.Click += new System.EventHandler(this.BtnBusMove_Click);
            // 
            // txtPassengerCount
            // 
            this.txtPassengerCount.Enabled = false;
            this.txtPassengerCount.Location = new System.Drawing.Point(15, 146);
            this.txtPassengerCount.Name = "txtPassengerCount";
            this.txtPassengerCount.Size = new System.Drawing.Size(121, 20);
            this.txtPassengerCount.TabIndex = 1;
            // 
            // comboxTripList
            // 
            this.comboxTripList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTripList.FormattingEnabled = true;
            this.comboxTripList.Location = new System.Drawing.Point(167, 46);
            this.comboxTripList.Name = "comboxTripList";
            this.comboxTripList.Size = new System.Drawing.Size(121, 21);
            this.comboxTripList.TabIndex = 0;
            this.comboxTripList.SelectedIndexChanged += new System.EventHandler(this.comboxTripList_SelectedIndexChanged);
            this.comboxTripList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboxTripList_Format);
            // 
            // comboxBusList
            // 
            this.comboxBusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBusList.FormattingEnabled = true;
            this.comboxBusList.Location = new System.Drawing.Point(15, 46);
            this.comboxBusList.Name = "comboxBusList";
            this.comboxBusList.Size = new System.Drawing.Size(121, 21);
            this.comboxBusList.TabIndex = 0;
            this.comboxBusList.SelectedIndexChanged += new System.EventHandler(this.comboxBusList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDailyArchive);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnBusStateSave);
            this.groupBox2.Controls.Add(this.lstDailyArchive);
            this.groupBox2.Controls.Add(this.lstTotalPrice);
            this.groupBox2.Controls.Add(this.lstDate);
            this.groupBox2.Controls.Add(this.lstPlate);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Günlük Arşiv";
            // 
            // BtnDailyArchive
            // 
            this.BtnDailyArchive.Location = new System.Drawing.Point(388, 117);
            this.BtnDailyArchive.Name = "BtnDailyArchive";
            this.BtnDailyArchive.Size = new System.Drawing.Size(75, 76);
            this.BtnDailyArchive.TabIndex = 1;
            this.BtnDailyArchive.Text = "Günlük Arşiv";
            this.BtnDailyArchive.UseVisualStyleBackColor = true;
            this.BtnDailyArchive.Click += new System.EventHandler(this.BtnDailyArchive_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Günlük Arşiv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Toplam Hasılat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plaka";
            // 
            // BtnBusStateSave
            // 
            this.BtnBusStateSave.Location = new System.Drawing.Point(388, 47);
            this.BtnBusStateSave.Name = "BtnBusStateSave";
            this.BtnBusStateSave.Size = new System.Drawing.Size(75, 65);
            this.BtnBusStateSave.TabIndex = 1;
            this.BtnBusStateSave.Text = "Araç Durumu Kaydet";
            this.BtnBusStateSave.UseVisualStyleBackColor = true;
            this.BtnBusStateSave.Click += new System.EventHandler(this.BtnBusStateSave_Click);
            // 
            // lstDailyArchive
            // 
            this.lstDailyArchive.FormattingEnabled = true;
            this.lstDailyArchive.Location = new System.Drawing.Point(469, 46);
            this.lstDailyArchive.Name = "lstDailyArchive";
            this.lstDailyArchive.Size = new System.Drawing.Size(142, 147);
            this.lstDailyArchive.TabIndex = 0;
            // 
            // lstTotalPrice
            // 
            this.lstTotalPrice.FormattingEnabled = true;
            this.lstTotalPrice.Location = new System.Drawing.Point(258, 46);
            this.lstTotalPrice.Name = "lstTotalPrice";
            this.lstTotalPrice.Size = new System.Drawing.Size(120, 147);
            this.lstTotalPrice.TabIndex = 0;
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.Location = new System.Drawing.Point(132, 46);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(120, 147);
            this.lstDate.TabIndex = 0;
            // 
            // lstPlate
            // 
            this.lstPlate.FormattingEnabled = true;
            this.lstPlate.Location = new System.Drawing.Point(6, 46);
            this.lstPlate.Name = "lstPlate";
            this.lstPlate.Size = new System.Drawing.Size(120, 147);
            this.lstPlate.TabIndex = 0;
            // 
            // BusControlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BusControlingForm";
            this.Text = "BusControlingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBusMove;
        private System.Windows.Forms.TextBox txtPassengerCount;
        private System.Windows.Forms.ComboBox comboxTripList;
        private System.Windows.Forms.ComboBox comboxBusList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDailyArchive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBusStateSave;
        private System.Windows.Forms.ListBox lstDailyArchive;
        private System.Windows.Forms.ListBox lstTotalPrice;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.ListBox lstPlate;
    }
}