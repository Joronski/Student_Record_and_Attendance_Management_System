namespace FinalsProject
{
    partial class ScanForm
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanForm));
            btnBack = new Button();
            pictureBoxQR = new PictureBox();
            btnAttendance = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 55);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Anchor = AnchorStyles.None;
            pictureBoxQR.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxQR.Location = new Point(206, 72);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(290, 260);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQR.TabIndex = 4;
            pictureBoxQR.TabStop = false;
            // 
            // btnAttendance
            // 
            btnAttendance.Anchor = AnchorStyles.None;
            btnAttendance.BackColor = Color.DeepSkyBlue;
            btnAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(286, 354);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(131, 35);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // ScanForm
            // 
            ClientSize = new Size(700, 424);
            Controls.Add(btnAttendance);
            Controls.Add(pictureBoxQR);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ScanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QR Scanner";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
        }
        private Button btnBack;
        private PictureBox pictureBoxQR;
        private Button btnAttendance;
    }
}