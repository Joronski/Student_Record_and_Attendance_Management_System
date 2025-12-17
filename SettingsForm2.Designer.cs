namespace FinalsProject
{
    partial class SettingsForm2
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
            panel2 = new Panel();
            BackButton = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            Security_And_Privacy = new Label();
            Notification = new Label();
            Date_And_Records = new Label();
            Scan_Settings = new Label();
            System_General_Settings = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            btnAutoScan = new Button();
            btnFlashlight = new Button();
            btnSaveScanHistory = new Button();
            btnVibrateOnScan = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(280, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 35);
            panel2.TabIndex = 3;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(11, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(29, 30);
            BackButton.TabIndex = 4;
            BackButton.Text = "<";
            BackButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(43, 7);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(386, 6);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 2;
            label1.Text = "Scan Settings";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(Security_And_Privacy);
            panel1.Controls.Add(Notification);
            panel1.Controls.Add(Date_And_Records);
            panel1.Controls.Add(Scan_Settings);
            panel1.Controls.Add(System_General_Settings);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 450);
            panel1.TabIndex = 2;
            // 
            // Security_And_Privacy
            // 
            Security_And_Privacy.AutoSize = true;
            Security_And_Privacy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Security_And_Privacy.ForeColor = SystemColors.ButtonFace;
            Security_And_Privacy.Location = new Point(34, 297);
            Security_And_Privacy.Name = "Security_And_Privacy";
            Security_And_Privacy.Size = new Size(155, 21);
            Security_And_Privacy.TabIndex = 9;
            Security_And_Privacy.Text = "Security and Privacy";
            Security_And_Privacy.Click += Security_And_Privacy_Click;
            // 
            // Notification
            // 
            Notification.AutoSize = true;
            Notification.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Notification.ForeColor = SystemColors.ButtonFace;
            Notification.Location = new Point(34, 239);
            Notification.Name = "Notification";
            Notification.Size = new Size(97, 21);
            Notification.TabIndex = 8;
            Notification.Text = "Notification";
            Notification.Click += Notification_Click;
            // 
            // Date_And_Records
            // 
            Date_And_Records.AutoSize = true;
            Date_And_Records.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date_And_Records.ForeColor = SystemColors.ButtonFace;
            Date_And_Records.Location = new Point(34, 179);
            Date_And_Records.Name = "Date_And_Records";
            Date_And_Records.Size = new Size(139, 21);
            Date_And_Records.TabIndex = 7;
            Date_And_Records.Text = "Date and Records";
            Date_And_Records.Click += Date_And_Records_Click;
            // 
            // Scan_Settings
            // 
            Scan_Settings.AutoSize = true;
            Scan_Settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Scan_Settings.ForeColor = SystemColors.ButtonShadow;
            Scan_Settings.Location = new Point(34, 119);
            Scan_Settings.Name = "Scan_Settings";
            Scan_Settings.Size = new Size(108, 21);
            Scan_Settings.TabIndex = 6;
            Scan_Settings.Text = "Scan Settings";
            Scan_Settings.Click += Scan_Settings_Click;
            // 
            // System_General_Settings
            // 
            System_General_Settings.AutoSize = true;
            System_General_Settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            System_General_Settings.ForeColor = SystemColors.ButtonFace;
            System_General_Settings.Location = new Point(34, 63);
            System_General_Settings.Name = "System_General_Settings";
            System_General_Settings.Size = new Size(190, 21);
            System_General_Settings.TabIndex = 5;
            System_General_Settings.Text = "System/General Settings";
            System_General_Settings.Click += System_General_Settings_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnAutoScan
            // 
            btnAutoScan.Anchor = AnchorStyles.Top;
            btnAutoScan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoScan.ForeColor = Color.Black;
            btnAutoScan.Location = new Point(303, 52);
            btnAutoScan.Margin = new Padding(3, 2, 3, 2);
            btnAutoScan.Name = "btnAutoScan";
            btnAutoScan.Size = new Size(477, 74);
            btnAutoScan.TabIndex = 4;
            btnAutoScan.Text = "Auto Scan";
            btnAutoScan.UseVisualStyleBackColor = true;
            btnAutoScan.Click += btnAutoScan_Click;
            // 
            // btnFlashlight
            // 
            btnFlashlight.Anchor = AnchorStyles.Top;
            btnFlashlight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlashlight.ForeColor = Color.Black;
            btnFlashlight.Location = new Point(303, 134);
            btnFlashlight.Margin = new Padding(3, 2, 3, 2);
            btnFlashlight.Name = "btnFlashlight";
            btnFlashlight.Size = new Size(477, 74);
            btnFlashlight.TabIndex = 5;
            btnFlashlight.Text = "Flashlight";
            btnFlashlight.UseVisualStyleBackColor = true;
            btnFlashlight.Click += btnFlashlight_Click;
            // 
            // btnSaveScanHistory
            // 
            btnSaveScanHistory.Anchor = AnchorStyles.Top;
            btnSaveScanHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveScanHistory.ForeColor = Color.Black;
            btnSaveScanHistory.Location = new Point(303, 214);
            btnSaveScanHistory.Margin = new Padding(3, 2, 3, 2);
            btnSaveScanHistory.Name = "btnSaveScanHistory";
            btnSaveScanHistory.Size = new Size(477, 74);
            btnSaveScanHistory.TabIndex = 6;
            btnSaveScanHistory.Text = "Save Scan History";
            btnSaveScanHistory.UseVisualStyleBackColor = true;
            btnSaveScanHistory.Click += btnSaveScanHistory_Click;
            // 
            // btnVibrateOnScan
            // 
            btnVibrateOnScan.Anchor = AnchorStyles.Top;
            btnVibrateOnScan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVibrateOnScan.ForeColor = Color.Black;
            btnVibrateOnScan.Location = new Point(303, 297);
            btnVibrateOnScan.Margin = new Padding(3, 2, 3, 2);
            btnVibrateOnScan.Name = "btnVibrateOnScan";
            btnVibrateOnScan.Size = new Size(477, 74);
            btnVibrateOnScan.TabIndex = 7;
            btnVibrateOnScan.Text = "Vibrate on Scan";
            btnVibrateOnScan.UseVisualStyleBackColor = true;
            btnVibrateOnScan.Click += btnVibrateOnScan_Click;
            // 
            // SettingsForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVibrateOnScan);
            Controls.Add(btnSaveScanHistory);
            Controls.Add(btnFlashlight);
            Controls.Add(btnAutoScan);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings | Scan Settings";
            Load += SettingsForm2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label BackButton;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label Security_And_Privacy;
        private Label Notification;
        private Label Date_And_Records;
        private Label Scan_Settings;
        private Label System_General_Settings;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Button btnAutoScan;
        private Button btnFlashlight;
        private Button btnSaveScanHistory;
        private Button btnVibrateOnScan;
    }
}