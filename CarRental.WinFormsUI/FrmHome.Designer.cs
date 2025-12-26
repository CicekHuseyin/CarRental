namespace CarRental.WinFormsUI
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            pbCustomer = new PictureBox();
            label1 = new Label();
            pbCar = new PictureBox();
            label2 = new Label();
            pbRent = new PictureBox();
            pbReport = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReport).BeginInit();
            SuspendLayout();
            // 
            // pbCustomer
            // 
            pbCustomer.BackColor = Color.FromArgb(245, 247, 250);
            pbCustomer.BorderStyle = BorderStyle.FixedSingle;
            pbCustomer.Cursor = Cursors.Hand;
            pbCustomer.Image = (Image)resources.GetObject("pbCustomer.Image");
            pbCustomer.Location = new Point(74, 36);
            pbCustomer.Name = "pbCustomer";
            pbCustomer.Size = new Size(168, 146);
            pbCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            pbCustomer.TabIndex = 0;
            pbCustomer.TabStop = false;
            pbCustomer.Click += pbCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 136, 229);
            label1.Location = new Point(70, 203);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "Müşteri İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbCar
            // 
            pbCar.BackColor = Color.FromArgb(245, 247, 250);
            pbCar.BorderStyle = BorderStyle.FixedSingle;
            pbCar.Cursor = Cursors.Hand;
            pbCar.Image = (Image)resources.GetObject("pbCar.Image");
            pbCar.Location = new Point(394, 36);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(168, 146);
            pbCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCar.TabIndex = 0;
            pbCar.TabStop = false;
            pbCar.Click += pbCar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 136, 229);
            label2.Location = new Point(407, 203);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 1;
            label2.Text = "Araç İşlemleri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbRent
            // 
            pbRent.BackColor = Color.FromArgb(245, 247, 250);
            pbRent.BorderStyle = BorderStyle.FixedSingle;
            pbRent.Cursor = Cursors.Hand;
            pbRent.Image = (Image)resources.GetObject("pbRent.Image");
            pbRent.Location = new Point(74, 253);
            pbRent.Name = "pbRent";
            pbRent.Size = new Size(168, 146);
            pbRent.SizeMode = PictureBoxSizeMode.Zoom;
            pbRent.TabIndex = 0;
            pbRent.TabStop = false;
            pbRent.Click += pbRent_Click;
            // 
            // pbReport
            // 
            pbReport.BackColor = Color.FromArgb(245, 247, 250);
            pbReport.BorderStyle = BorderStyle.FixedSingle;
            pbReport.Cursor = Cursors.Hand;
            pbReport.Image = (Image)resources.GetObject("pbReport.Image");
            pbReport.Location = new Point(394, 253);
            pbReport.Name = "pbReport";
            pbReport.Size = new Size(168, 146);
            pbReport.SizeMode = PictureBoxSizeMode.Zoom;
            pbReport.TabIndex = 0;
            pbReport.TabStop = false;
            pbReport.Click += pbReport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 136, 229);
            label3.Location = new Point(87, 420);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 1;
            label3.Text = "Araç Kiralama";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 136, 229);
            label4.Location = new Point(433, 420);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 1;
            label4.Text = "Raporlar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 481);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pbReport);
            Controls.Add(pbRent);
            Controls.Add(pbCar);
            Controls.Add(pbCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)pbCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCustomer;
        private Label label1;
        private PictureBox pbCar;
        private Label label2;
        private PictureBox pbRent;
        private PictureBox pbReport;
        private Label label3;
        private Label label4;
    }
}