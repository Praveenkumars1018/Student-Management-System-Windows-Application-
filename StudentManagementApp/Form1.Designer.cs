namespace StudentManagementApp
{
    partial class Form1
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblUpgradeCourse = new System.Windows.Forms.Label();
            this.lblUpgradeStudentID = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtUpgradeStudentID = new System.Windows.Forms.TextBox();
            this.cmbUpgradeCourse = new System.Windows.Forms.ComboBox();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.lblAverageStudentID = new System.Windows.Forms.Label();
            this.txtAverageStudentID = new System.Windows.Forms.TextBox();
            this.btnFindAverage = new System.Windows.Forms.Button();
            this.lblPassFailStudentID = new System.Windows.Forms.Label();
            this.txtPassFailStudentID = new System.Windows.Forms.TextBox();
            this.btnCheckPassFail = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.txtdeleteid = new System.Windows.Forms.TextBox();
            this.btndeleteid = new System.Windows.Forms.Button();
            this.btnRetrieveGrades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRetrivebtn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStudentID.Location = new System.Drawing.Point(57, 58);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(95, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID :";
            this.lblStudentID.Click += new System.EventHandler(this.lblStudentID_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(190, 52);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(187, 26);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStudentName.Location = new System.Drawing.Point(93, 114);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(59, 20);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Name :";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(190, 114);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(187, 26);
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGrade.Location = new System.Drawing.Point(556, 179);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 20);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // lblUpgradeCourse
            // 
            this.lblUpgradeCourse.AutoSize = true;
            this.lblUpgradeCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUpgradeCourse.Location = new System.Drawing.Point(556, 117);
            this.lblUpgradeCourse.Name = "lblUpgradeCourse";
            this.lblUpgradeCourse.Size = new System.Drawing.Size(60, 20);
            this.lblUpgradeCourse.TabIndex = 5;
            this.lblUpgradeCourse.Text = "Course";
            this.lblUpgradeCourse.Click += new System.EventHandler(this.lblUpgradeCourse_Click);
            // 
            // lblUpgradeStudentID
            // 
            this.lblUpgradeStudentID.AutoSize = true;
            this.lblUpgradeStudentID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUpgradeStudentID.Location = new System.Drawing.Point(521, 58);
            this.lblUpgradeStudentID.Name = "lblUpgradeStudentID";
            this.lblUpgradeStudentID.Size = new System.Drawing.Size(95, 20);
            this.lblUpgradeStudentID.TabIndex = 6;
            this.lblUpgradeStudentID.Text = "Student ID :";
            this.lblUpgradeStudentID.Click += new System.EventHandler(this.lblUpgradeStudentID_Click);
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStudentAge.Location = new System.Drawing.Point(114, 179);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(38, 20);
            this.lblStudentAge.TabIndex = 8;
            this.lblStudentAge.Text = "Age";
            this.lblStudentAge.Click += new System.EventHandler(this.lblStudentAge_Click);
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(190, 173);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(187, 26);
            this.txtStudentAge.TabIndex = 9;
            this.txtStudentAge.TextChanged += new System.EventHandler(this.txtStudentAge_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStudent.Location = new System.Drawing.Point(161, 235);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(93, 34);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student : ";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(652, 173);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(173, 26);
            this.txtGrade.TabIndex = 14;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // txtUpgradeStudentID
            // 
            this.txtUpgradeStudentID.Location = new System.Drawing.Point(652, 55);
            this.txtUpgradeStudentID.Name = "txtUpgradeStudentID";
            this.txtUpgradeStudentID.Size = new System.Drawing.Size(173, 26);
            this.txtUpgradeStudentID.TabIndex = 15;
            this.txtUpgradeStudentID.TextChanged += new System.EventHandler(this.txtUpgradeStudentID_TextChanged);
            // 
            // cmbUpgradeCourse
            // 
            this.cmbUpgradeCourse.FormattingEnabled = true;
            this.cmbUpgradeCourse.Location = new System.Drawing.Point(652, 114);
            this.cmbUpgradeCourse.Name = "cmbUpgradeCourse";
            this.cmbUpgradeCourse.Size = new System.Drawing.Size(173, 28);
            this.cmbUpgradeCourse.TabIndex = 16;
            this.cmbUpgradeCourse.SelectedIndexChanged += new System.EventHandler(this.cmbUpgradeCourse_SelectedIndexChanged);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateGrade.Location = new System.Drawing.Point(626, 234);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(95, 35);
            this.btnUpdateGrade.TabIndex = 17;
            this.btnUpdateGrade.Text = "Update Grade";
            this.btnUpdateGrade.UseVisualStyleBackColor = false;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // lblAverageStudentID
            // 
            this.lblAverageStudentID.AutoSize = true;
            this.lblAverageStudentID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAverageStudentID.Location = new System.Drawing.Point(74, 334);
            this.lblAverageStudentID.Name = "lblAverageStudentID";
            this.lblAverageStudentID.Size = new System.Drawing.Size(87, 20);
            this.lblAverageStudentID.TabIndex = 18;
            this.lblAverageStudentID.Text = "Student ID";
            this.lblAverageStudentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAverageStudentID
            // 
            this.txtAverageStudentID.Location = new System.Drawing.Point(190, 331);
            this.txtAverageStudentID.Name = "txtAverageStudentID";
            this.txtAverageStudentID.Size = new System.Drawing.Size(211, 26);
            this.txtAverageStudentID.TabIndex = 19;
            this.txtAverageStudentID.TextChanged += new System.EventHandler(this.txtAverageStudentID_TextChanged);
            // 
            // btnFindAverage
            // 
            this.btnFindAverage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindAverage.Location = new System.Drawing.Point(161, 387);
            this.btnFindAverage.Name = "btnFindAverage";
            this.btnFindAverage.Size = new System.Drawing.Size(75, 36);
            this.btnFindAverage.TabIndex = 20;
            this.btnFindAverage.Text = "Average";
            this.btnFindAverage.UseVisualStyleBackColor = false;
            this.btnFindAverage.Click += new System.EventHandler(this.btnFindAverage_Click);
            // 
            // lblPassFailStudentID
            // 
            this.lblPassFailStudentID.AutoSize = true;
            this.lblPassFailStudentID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPassFailStudentID.Location = new System.Drawing.Point(74, 463);
            this.lblPassFailStudentID.Name = "lblPassFailStudentID";
            this.lblPassFailStudentID.Size = new System.Drawing.Size(83, 20);
            this.lblPassFailStudentID.TabIndex = 21;
            this.lblPassFailStudentID.Text = "StudentID";
            this.lblPassFailStudentID.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPassFailStudentID
            // 
            this.txtPassFailStudentID.Location = new System.Drawing.Point(190, 457);
            this.txtPassFailStudentID.Name = "txtPassFailStudentID";
            this.txtPassFailStudentID.Size = new System.Drawing.Size(211, 26);
            this.txtPassFailStudentID.TabIndex = 22;
            this.txtPassFailStudentID.TextChanged += new System.EventHandler(this.txtPassFailStudentID_TextChanged);
            // 
            // btnCheckPassFail
            // 
            this.btnCheckPassFail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckPassFail.Location = new System.Drawing.Point(161, 511);
            this.btnCheckPassFail.Name = "btnCheckPassFail";
            this.btnCheckPassFail.Size = new System.Drawing.Size(75, 32);
            this.btnCheckPassFail.TabIndex = 23;
            this.btnCheckPassFail.Text = "Pass/Fail";
            this.btnCheckPassFail.UseVisualStyleBackColor = false;
            this.btnCheckPassFail.Click += new System.EventHandler(this.btnCheckPassFail_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveData.Location = new System.Drawing.Point(575, 511);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 35);
            this.btnSaveData.TabIndex = 24;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadData.Location = new System.Drawing.Point(731, 514);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 32);
            this.btnLoadData.TabIndex = 25;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.idlabel.Location = new System.Drawing.Point(524, 337);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(92, 20);
            this.idlabel.TabIndex = 27;
            this.idlabel.Text = "Student Id :";
            this.idlabel.Click += new System.EventHandler(this.idlabel_Click);
            // 
            // txtdeleteid
            // 
            this.txtdeleteid.Location = new System.Drawing.Point(649, 334);
            this.txtdeleteid.Name = "txtdeleteid";
            this.txtdeleteid.Size = new System.Drawing.Size(176, 26);
            this.txtdeleteid.TabIndex = 28;
            this.txtdeleteid.TextChanged += new System.EventHandler(this.txtdeleteid_TextChanged);
            // 
            // btndeleteid
            // 
            this.btndeleteid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndeleteid.Location = new System.Drawing.Point(626, 390);
            this.btndeleteid.Name = "btndeleteid";
            this.btndeleteid.Size = new System.Drawing.Size(95, 33);
            this.btndeleteid.TabIndex = 29;
            this.btndeleteid.Text = "Delete";
            this.btndeleteid.UseVisualStyleBackColor = false;
            this.btndeleteid.Click += new System.EventHandler(this.btndeleteid_Click);
            // 
            // btnRetrieveGrades
            // 
            this.btnRetrieveGrades.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRetrieveGrades.Location = new System.Drawing.Point(951, 234);
            this.btnRetrieveGrades.Name = "btnRetrieveGrades";
            this.btnRetrieveGrades.Size = new System.Drawing.Size(118, 44);
            this.btnRetrieveGrades.TabIndex = 30;
            this.btnRetrieveGrades.Text = "Retrive";
            this.btnRetrieveGrades.UseVisualStyleBackColor = false;
            this.btnRetrieveGrades.Click += new System.EventHandler(this.btnRetrieveGrades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(886, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Student Id :";
            // 
            // TxtRetrivebtn
            // 
            this.TxtRetrivebtn.Location = new System.Drawing.Point(1001, 184);
            this.TxtRetrivebtn.Name = "TxtRetrivebtn";
            this.TxtRetrivebtn.Size = new System.Drawing.Size(128, 26);
            this.TxtRetrivebtn.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 607);
            this.Controls.Add(this.TxtRetrivebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetrieveGrades);
            this.Controls.Add(this.btndeleteid);
            this.Controls.Add(this.txtdeleteid);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnCheckPassFail);
            this.Controls.Add(this.txtPassFailStudentID);
            this.Controls.Add(this.lblPassFailStudentID);
            this.Controls.Add(this.btnFindAverage);
            this.Controls.Add(this.txtAverageStudentID);
            this.Controls.Add(this.lblAverageStudentID);
            this.Controls.Add(this.btnUpdateGrade);
            this.Controls.Add(this.cmbUpgradeCourse);
            this.Controls.Add(this.txtUpgradeStudentID);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.lblUpgradeStudentID);
            this.Controls.Add(this.lblUpgradeCourse);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblUpgradeCourse;
        private System.Windows.Forms.Label lblUpgradeStudentID;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtUpgradeStudentID;
        private System.Windows.Forms.ComboBox cmbUpgradeCourse;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Label lblAverageStudentID;
        private System.Windows.Forms.TextBox txtAverageStudentID;
        private System.Windows.Forms.Button btnFindAverage;
        private System.Windows.Forms.Label lblPassFailStudentID;
        private System.Windows.Forms.TextBox txtPassFailStudentID;
        private System.Windows.Forms.Button btnCheckPassFail;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox txtdeleteid;
        private System.Windows.Forms.Button btndeleteid;
        private System.Windows.Forms.Button btnRetrieveGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRetrivebtn;
    }
}

