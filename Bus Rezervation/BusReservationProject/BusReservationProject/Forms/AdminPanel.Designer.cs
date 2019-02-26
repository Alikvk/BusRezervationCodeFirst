namespace BusReservationProject.Forms
{
    partial class AdminPanel
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
            this.BtnBusAdd = new System.Windows.Forms.Button();
            this.BtnDriverAdd = new System.Windows.Forms.Button();
            this.BtnControl = new System.Windows.Forms.Button();
            this.BtnBusControlling = new System.Windows.Forms.Button();
            this.BtnCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBusAdd
            // 
            this.BtnBusAdd.Location = new System.Drawing.Point(12, 31);
            this.BtnBusAdd.Name = "BtnBusAdd";
            this.BtnBusAdd.Size = new System.Drawing.Size(106, 77);
            this.BtnBusAdd.TabIndex = 0;
            this.BtnBusAdd.Text = "Otobüs Ekle";
            this.BtnBusAdd.UseVisualStyleBackColor = true;
            this.BtnBusAdd.Click += new System.EventHandler(this.BtnBusAdd_Click);
            // 
            // BtnDriverAdd
            // 
            this.BtnDriverAdd.Location = new System.Drawing.Point(140, 31);
            this.BtnDriverAdd.Name = "BtnDriverAdd";
            this.BtnDriverAdd.Size = new System.Drawing.Size(106, 77);
            this.BtnDriverAdd.TabIndex = 0;
            this.BtnDriverAdd.Text = "Sürücü Ekle";
            this.BtnDriverAdd.UseVisualStyleBackColor = true;
            this.BtnDriverAdd.Click += new System.EventHandler(this.BtnDriverAdd_Click);
            // 
            // BtnControl
            // 
            this.BtnControl.Location = new System.Drawing.Point(412, 31);
            this.BtnControl.Name = "BtnControl";
            this.BtnControl.Size = new System.Drawing.Size(106, 77);
            this.BtnControl.TabIndex = 0;
            this.BtnControl.Text = "Kontrol";
            this.BtnControl.UseVisualStyleBackColor = true;
            this.BtnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // BtnBusControlling
            // 
            this.BtnBusControlling.Location = new System.Drawing.Point(541, 31);
            this.BtnBusControlling.Name = "BtnBusControlling";
            this.BtnBusControlling.Size = new System.Drawing.Size(106, 77);
            this.BtnBusControlling.TabIndex = 0;
            this.BtnBusControlling.Text = "Araç Kontrol";
            this.BtnBusControlling.UseVisualStyleBackColor = true;
            this.BtnBusControlling.Click += new System.EventHandler(this.BtnBusControlling_Click);
            // 
            // BtnCity
            // 
            this.BtnCity.Location = new System.Drawing.Point(272, 31);
            this.BtnCity.Name = "BtnCity";
            this.BtnCity.Size = new System.Drawing.Size(106, 77);
            this.BtnCity.TabIndex = 0;
            this.BtnCity.Text = "Şehir Ekle";
            this.BtnCity.UseVisualStyleBackColor = true;
            this.BtnCity.Click += new System.EventHandler(this.BtnCity_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 128);
            this.Controls.Add(this.BtnBusControlling);
            this.Controls.Add(this.BtnControl);
            this.Controls.Add(this.BtnCity);
            this.Controls.Add(this.BtnDriverAdd);
            this.Controls.Add(this.BtnBusAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBusAdd;
        private System.Windows.Forms.Button BtnDriverAdd;
        private System.Windows.Forms.Button BtnControl;
        private System.Windows.Forms.Button BtnBusControlling;
        private System.Windows.Forms.Button BtnCity;
    }
}