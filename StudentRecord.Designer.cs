namespace FinalsProject
{
    partial class StudentRecord
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecord));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtStudentID = new TextBox();
            txtScore = new TextBox();
            txtGrade = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            panelForm = new Panel();
            btnViewRecord = new Button();
            dataGridView1 = new DataGridView();
            panelTable = new Panel();
            label6 = new Label();
            btnReturn = new Button();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTable.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(46, 173);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(75, 132);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(77, 208);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 3;
            label4.Text = "Score:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(74, 246);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 4;
            label5.Text = "Grade:";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 132);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Yobmot, Luis";
            txtName.Size = new Size(209, 23);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(88, 54);
            label1.Name = "label1";
            label1.Size = new Size(223, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Information";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(134, 173);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "2300444";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(134, 208);
            txtScore.Name = "txtScore";
            txtScore.PlaceholderText = "84";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 9;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(134, 246);
            txtGrade.Name = "txtGrade";
            txtGrade.PlaceholderText = "95.23";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 10;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DeepSkyBlue;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(34, 316);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(88, 32);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(154, 316);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 32);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.None;
            panelForm.BackColor = Color.LightSteelBlue;
            panelForm.Controls.Add(btnViewRecord);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(btnBack);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(btnSubmit);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtGrade);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtScore);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtStudentID);
            panelForm.Controls.Add(txtName);
            panelForm.Location = new Point(224, 26);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(387, 426);
            panelForm.TabIndex = 13;
            // 
            // btnViewRecord
            // 
            btnViewRecord.BackColor = Color.MediumOrchid;
            btnViewRecord.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewRecord.ForeColor = Color.White;
            btnViewRecord.Location = new Point(269, 316);
            btnViewRecord.Name = "btnViewRecord";
            btnViewRecord.Size = new Size(88, 32);
            btnViewRecord.TabIndex = 13;
            btnViewRecord.Text = "View Record";
            btnViewRecord.UseVisualStyleBackColor = false;
            btnViewRecord.Click += btnViewRecord_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(4, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(711, 337);
            dataGridView1.TabIndex = 0;
            // 
            // panelTable
            // 
            panelTable.Anchor = AnchorStyles.None;
            panelTable.BackColor = Color.LightSteelBlue;
            panelTable.Controls.Add(label6);
            panelTable.Controls.Add(btnReturn);
            panelTable.Controls.Add(dataGridView1);
            panelTable.Location = new Point(54, 12);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(718, 424);
            panelTable.TabIndex = 14;
            panelTable.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(285, 13);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 2;
            label6.Text = "Student Record";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Gray;
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(324, 384);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(88, 32);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // StudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 464);
            Controls.Add(panelTable);
            Controls.Add(panelForm);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Record";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtName;
        private Label label1;
        private TextBox txtStudentID;
        private TextBox txtScore;
        private TextBox txtGrade;
        private Button btnSubmit;
        private Button btnBack;
        private Panel panelForm;
        private DataGridView dataGridView1;
        private Panel panelTable;
        private Button btnReturn;
        private Label label6;
        private Button btnViewRecord;
    }
}