namespace FinalsProject
{
    partial class SettingsForm4
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
            btnAdminControl = new Button();
            btnUserPreference = new Button();
            btnFrequency = new Button();
            btnDeliveryMethod = new Button();
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
            label1.Location = new Point(399, 7);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 2;
            label1.Text = "Notification";
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
            Notification.ForeColor = SystemColors.ButtonShadow;
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
            System_General_Settings.ForeColor = SystemColors.ButtonFace;
            System_General_Settings.Location = new Point(34, 63);
            System_General_Settings.Name = "System_General_Settings";
            System_General_Settings.Size = new Size(190, 21);
            System_General_Settings.TabIndex = 5;
            System_General_Settings.Text = "System/General Settings";
            System_General_Settings.Click += System_General_Settings_Click;
            // 
            // btnAdminControl
            // 
            btnAdminControl.Anchor = AnchorStyles.Top;
            btnAdminControl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminControl.ForeColor = Color.Black;
            btnAdminControl.Location = new Point(303, 297);
            btnAdminControl.Margin = new Padding(3, 2, 3, 2);
            btnAdminControl.Name = "btnAdminControl";
            btnAdminControl.Size = new Size(477, 74);
            btnAdminControl.TabIndex = 15;
            btnAdminControl.Text = "Admin Control";
            btnAdminControl.UseVisualStyleBackColor = true;
            btnAdminControl.Click += btnAdminControl_Click;
            // 
            // btnUserPreference
            // 
            btnUserPreference.Anchor = AnchorStyles.Top;
            btnUserPreference.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserPreference.ForeColor = Color.Black;
            btnUserPreference.Location = new Point(303, 214);
            btnUserPreference.Margin = new Padding(3, 2, 3, 2);
            btnUserPreference.Name = "btnUserPreference";
            btnUserPreference.Size = new Size(477, 74);
            btnUserPreference.TabIndex = 14;
            btnUserPreference.Text = "User Preference";
            btnUserPreference.UseVisualStyleBackColor = true;
            btnUserPreference.Click += btnUserPreference_Click;
            // 
            // btnFrequency
            // 
            btnFrequency.Anchor = AnchorStyles.Top;
            btnFrequency.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrequency.ForeColor = Color.Black;
            btnFrequency.Location = new Point(303, 134);
            btnFrequency.Margin = new Padding(3, 2, 3, 2);
            btnFrequency.Name = "btnFrequency";
            btnFrequency.Size = new Size(477, 74);
            btnFrequency.TabIndex = 13;
            btnFrequency.Text = "Frequency";
            btnFrequency.UseVisualStyleBackColor = true;
            btnFrequency.Click += btnFrequency_Click;
            // 
            // btnDeliveryMethod
            // 
            btnDeliveryMethod.Anchor = AnchorStyles.Top;
            btnDeliveryMethod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeliveryMethod.ForeColor = Color.Black;
            btnDeliveryMethod.Location = new Point(303, 52);
            btnDeliveryMethod.Margin = new Padding(3, 2, 3, 2);
            btnDeliveryMethod.Name = "btnDeliveryMethod";
            btnDeliveryMethod.Size = new Size(477, 74);
            btnDeliveryMethod.TabIndex = 12;
            btnDeliveryMethod.Text = "Delivery Method";
            btnDeliveryMethod.UseVisualStyleBackColor = true;
            btnDeliveryMethod.Click += btnDeliveryMethod_Click;
            // 
            // SettingsForm4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminControl);
            Controls.Add(btnUserPreference);
            Controls.Add(btnFrequency);
            Controls.Add(btnDeliveryMethod);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsForm4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings | Notification";
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
        private Button btnAdminControl;
        private Button btnUserPreference;
        private Button btnFrequency;
        private Button btnDeliveryMethod;
    }
}