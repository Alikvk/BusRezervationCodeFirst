namespace BusReservationProject.Forms
{
    partial class ManageBussesForm
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvBusList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSeatCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxDriver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBusPicture = new System.Windows.Forms.PictureBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(246, 243);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 60);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(141, 243);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 60);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(38, 243);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 60);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(108, 68);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(120, 20);
            this.txtPlateNumber.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 8;
            // 
            // dgvBusList
            // 
            this.dgvBusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusList.Location = new System.Drawing.Point(468, 12);
            this.dgvBusList.Name = "dgvBusList";
            this.dgvBusList.Size = new System.Drawing.Size(470, 318);
            this.dgvBusList.TabIndex = 6;
            this.dgvBusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plaka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otobüs Adı";
            // 
            // nudSeatCount
            // 
            this.nudSeatCount.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSeatCount.Location = new System.Drawing.Point(108, 121);
            this.nudSeatCount.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeatCount.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSeatCount.Name = "nudSeatCount";
            this.nudSeatCount.Size = new System.Drawing.Size(120, 20);
            this.nudSeatCount.TabIndex = 12;
            this.nudSeatCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk Sayısı";
            // 
            // comboxDriver
            // 
            this.comboxDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDriver.FormattingEnabled = true;
            this.comboxDriver.Location = new System.Drawing.Point(108, 182);
            this.comboxDriver.Name = "comboxDriver";
            this.comboxDriver.Size = new System.Drawing.Size(121, 21);
            this.comboxDriver.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şoför";
            // 
            // pbBusPicture
            // 
            this.pbBusPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbBusPicture.Location = new System.Drawing.Point(246, 24);
            this.pbBusPicture.Name = "pbBusPicture";
            this.pbBusPicture.Size = new System.Drawing.Size(205, 190);
            this.pbBusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusPicture.TabIndex = 14;
            this.pbBusPicture.TabStop = false;
            this.pbBusPicture.Click += new System.EventHandler(this.pbBusPicture_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(270, 220);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFilePath.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Picture";
            // 
            // ManageBussesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbBusPicture);
            this.Controls.Add(this.comboxDriver);
            this.Controls.Add(this.nudSeatCount);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvBusList);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageBussesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvBusList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSeatCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbBusPicture;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label5;
    }
}