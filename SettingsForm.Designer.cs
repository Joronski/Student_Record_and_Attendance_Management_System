namespace FinalsProject
{
    partial class SettingsForm
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
            panel1 = new Panel();
            Security_And_Privacy = new Label();
            Notification = new Label();
            Date_And_Records = new Label();
            Scan_Settings = new Label();
            System_General_Settings = new Label();
            panel2 = new Panel();
            BackButton = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSystem = new Button();
            btnLanguage = new Button();
            btnAppearance = new Button();
            btnDataAndTime = new Button();
            btnFileLocation = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(227, 450);
            panel1.TabIndex = 0;
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
            Scan_Settings.ForeColor = SystemColors.ButtonFace;
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
            System_General_Settings.ForeColor = SystemColors.ButtonShadow;
            System_General_Settings.Location = new Point(34, 63);
            System_General_Settings.Name = "System_General_Settings";
            System_General_Settings.Size = new Size(190, 21);
            System_General_Settings.TabIndex = 5;
            System_General_Settings.Text = "System/General Settings";
            System_General_Settings.Click += System_General_Settings_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(227, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 35);
            panel2.TabIndex = 1;
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
            BackButton.Click += label3_Click;
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
            label1.Location = new Point(486, 8);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 2;
            label1.Text = "General";
            label1.Click += label1_Click;
            // 
            // btnSystem
            // 
            btnSystem.Anchor = AnchorStyles.Top;
            btnSystem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSystem.ForeColor = Color.Black;
            btnSystem.Location = new Point(300, 47);
            btnSystem.Margin = new Padding(3, 2, 3, 2);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(477, 74);
            btnSystem.TabIndex = 2;
            btnSystem.Text = "System";
            btnSystem.UseVisualStyleBackColor = true;
            btnSystem.Click += btnSystem_Click;
            // 
            // btnLanguage
            // 
            btnLanguage.Anchor = AnchorStyles.Top;
            btnLanguage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLanguage.ForeColor = Color.Black;
            btnLanguage.Location = new Point(300, 136);
            btnLanguage.Margin = new Padding(3, 2, 3, 2);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Size = new Size(230, 53);
            btnLanguage.TabIndex = 3;
            btnLanguage.Text = "Language";
            btnLanguage.UseVisualStyleBackColor = true;
            btnLanguage.Click += btnLanguage_Click;
            // 
            // btnAppearance
            // 
            btnAppearance.Anchor = AnchorStyles.Top;
            btnAppearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppearance.ForeColor = Color.Black;
            btnAppearance.Location = new Point(547, 136);
            btnAppearance.Margin = new Padding(3, 2, 3, 2);
            btnAppearance.Name = "btnAppearance";
            btnAppearance.Size = new Size(230, 53);
            btnAppearance.TabIndex = 4;
            btnAppearance.Text = "Appearance";
            btnAppearance.UseVisualStyleBackColor = true;
            btnAppearance.Click += btnAppearance_Click;
            // 
            // btnDataAndTime
            // 
            btnDataAndTime.Anchor = AnchorStyles.Top;
            btnDataAndTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDataAndTime.ForeColor = Color.Black;
            btnDataAndTime.Location = new Point(547, 204);
            btnDataAndTime.Margin = new Padding(3, 2, 3, 2);
            btnDataAndTime.Name = "btnDataAndTime";
            btnDataAndTime.Size = new Size(230, 53);
            btnDataAndTime.TabIndex = 6;
            btnDataAndTime.Text = "Date and Time";
            btnDataAndTime.UseVisualStyleBackColor = true;
            btnDataAndTime.Click += btnDataAndTime_Click;
            // 
            // btnFileLocation
            // 
            btnFileLocation.Anchor = AnchorStyles.Top;
            btnFileLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFileLocation.ForeColor = Color.Black;
            btnFileLocation.Location = new Point(300, 204);
            btnFileLocation.Margin = new Padding(3, 2, 3, 2);
            btnFileLocation.Name = "btnFileLocation";
            btnFileLocation.Size = new Size(230, 53);
            btnFileLocation.TabIndex = 5;
            btnFileLocation.Text = "File Location";
            btnFileLocation.UseVisualStyleBackColor = true;
            btnFileLocation.Click += btnFileLocation_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDataAndTime);
            Controls.Add(btnFileLocation);
            Controls.Add(btnAppearance);
            Controls.Add(btnLanguage);
            Controls.Add(btnSystem);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings | General";
            Load += SettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label BackButton;
        private Label label2;
        private Label Scan_Settings;
        private Label System_General_Settings;
        private Label Security_And_Privacy;
        private Label Notification;
        private Label Date_And_Records;
        private Button btnSystem;
        private Button btnLanguage;
        private Button btnAppearance;
        private Button btnDataAndTime;
        private Button btnFileLocation;
    }
}