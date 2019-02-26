namespace BusReservationProject.Forms
{
    partial class ControlForm
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
            this.lstPlate = new System.Windows.Forms.ListBox();
            this.lstSeatNumber = new System.Windows.Forms.ListBox();
            this.lstTrip = new System.Windows.Forms.ListBox();
            this.lstNameSurname = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.comboxBus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlate
            // 
            this.lstPlate.FormattingEnabled = true;
            this.lstPlate.Location = new System.Drawing.Point(22, 32);
            this.lstPlate.Name = "lstPlate";
            this.lstPlate.Size = new System.Drawing.Size(120, 186);
            this.lstPlate.TabIndex = 0;
            // 
            // lstSeatNumber
            // 
            this.lstSeatNumber.FormattingEnabled = true;
            this.lstSeatNumber.Location = new System.Drawing.Point(148, 32);
            this.lstSeatNumber.Name = "lstSeatNumber";
            this.lstSeatNumber.Size = new System.Drawing.Size(120, 186);
            this.lstSeatNumber.TabIndex = 0;
            // 
            // lstTrip
            // 
            this.lstTrip.FormattingEnabled = true;
            this.lstTrip.Location = new System.Drawing.Point(274, 32);
            this.lstTrip.Name = "lstTrip";
            this.lstTrip.Size = new System.Drawing.Size(120, 186);
            this.lstTrip.TabIndex = 0;
            // 
            // lstNameSurname
            // 
            this.lstNameSurname.FormattingEnabled = true;
            this.lstNameSurname.Location = new System.Drawing.Point(410, 32);
            this.lstNameSurname.Name = "lstNameSurname";
            this.lstNameSurname.Size = new System.Drawing.Size(120, 186);
            this.lstNameSurname.TabIndex = 0;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(536, 32);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(120, 186);
            this.lstPrice.TabIndex = 0;
            // 
            // comboxBus
            // 
            this.comboxBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBus.FormattingEnabled = true;
            this.comboxBus.Location = new System.Drawing.Point(66, 243);
            this.comboxBus.Name = "comboxBus";
            this.comboxBus.Size = new System.Drawing.Size(121, 21);
            this.comboxBus.TabIndex = 1;
            this.comboxBus.SelectedIndexChanged += new System.EventHandler(this.comboxBus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Fiyat";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(306, 246);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plaka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Koltuk No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sefer Kalkış -> Varış";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tutar";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 283);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxBus);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstNameSurname);
            this.Controls.Add(this.lstTrip);
            this.Controls.Add(this.lstSeatNumber);
            this.Controls.Add(this.lstPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlate;
        private System.Windows.Forms.ListBox lstSeatNumber;
        private System.Windows.Forms.ListBox lstTrip;
        private System.Windows.Forms.ListBox lstNameSurname;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ComboBox comboxBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}