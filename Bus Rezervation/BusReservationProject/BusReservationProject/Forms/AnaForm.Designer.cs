namespace BusReservationProject
{
    partial class AnaForm
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
            this.BtnAdminPanel = new System.Windows.Forms.Button();
            this.BtnPurchaseTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminPanel
            // 
            this.BtnAdminPanel.Location = new System.Drawing.Point(13, 13);
            this.BtnAdminPanel.Name = "BtnAdminPanel";
            this.BtnAdminPanel.Size = new System.Drawing.Size(116, 58);
            this.BtnAdminPanel.TabIndex = 0;
            this.BtnAdminPanel.Text = "Admin Panel";
            this.BtnAdminPanel.UseVisualStyleBackColor = true;
            this.BtnAdminPanel.Click += new System.EventHandler(this.BtnAdminPanel_Click);
            // 
            // BtnPurchaseTicket
            // 
            this.BtnPurchaseTicket.Location = new System.Drawing.Point(148, 13);
            this.BtnPurchaseTicket.Name = "BtnPurchaseTicket";
            this.BtnPurchaseTicket.Size = new System.Drawing.Size(116, 58);
            this.BtnPurchaseTicket.TabIndex = 0;
            this.BtnPurchaseTicket.Text = "Bilet Kes";
            this.BtnPurchaseTicket.UseVisualStyleBackColor = true;
            this.BtnPurchaseTicket.Click += new System.EventHandler(this.BtnPurchaseTicket_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 92);
            this.Controls.Add(this.BtnPurchaseTicket);
            this.Controls.Add(this.BtnAdminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminPanel;
        private System.Windows.Forms.Button BtnPurchaseTicket;
    }
}

