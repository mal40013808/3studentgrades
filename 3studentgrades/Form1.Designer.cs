namespace _3studentgrades
{
    partial class frmStudentGrades
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStudentDetails = new System.Windows.Forms.TabPage();
            this.btnEnterDetails = new System.Windows.Forms.Button();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblStudentMarks = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.tbGrades = new System.Windows.Forms.TabPage();
            this.tbResults = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblEnglish2 = new System.Windows.Forms.Label();
            this.lblMaths2 = new System.Windows.Forms.Label();
            this.lblScience2 = new System.Windows.Forms.Label();
            this.txtStudentName2 = new System.Windows.Forms.TextBox();
            this.txtStudentNumber2 = new System.Windows.Forms.TextBox();
            this.txtEnglish2 = new System.Windows.Forms.TextBox();
            this.txtMaths2 = new System.Windows.Forms.TextBox();
            this.txtScience2 = new System.Windows.Forms.TextBox();
            this.txtGroup2 = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblStudentName3 = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtStudentDetails2 = new System.Windows.Forms.TextBox();
            this.txtAverageMark = new System.Windows.Forms.TextBox();
            this.txtStudentGrade = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.tbGrades.SuspendLayout();
            this.tbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(481, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Grades";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbStudentDetails);
            this.tabControl1.Controls.Add(this.tbGrades);
            this.tabControl1.Controls.Add(this.tbResults);
            this.tabControl1.Location = new System.Drawing.Point(257, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 320);
            this.tabControl1.TabIndex = 1;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.btnClear);
            this.tbStudentDetails.Controls.Add(this.btnEnterDetails);
            this.tbStudentDetails.Controls.Add(this.txtScience);
            this.tbStudentDetails.Controls.Add(this.txtMaths);
            this.tbStudentDetails.Controls.Add(this.txtEnglish);
            this.tbStudentDetails.Controls.Add(this.cboGroup);
            this.tbStudentDetails.Controls.Add(this.txtStudentNumber);
            this.tbStudentDetails.Controls.Add(this.txtStudentName);
            this.tbStudentDetails.Controls.Add(this.lblGroup);
            this.tbStudentDetails.Controls.Add(this.lblStudentNumber);
            this.tbStudentDetails.Controls.Add(this.lblStudentName);
            this.tbStudentDetails.Controls.Add(this.lblScience);
            this.tbStudentDetails.Controls.Add(this.lblMaths);
            this.tbStudentDetails.Controls.Add(this.lblEnglish);
            this.tbStudentDetails.Controls.Add(this.lblStudentMarks);
            this.tbStudentDetails.Controls.Add(this.lblInformation);
            this.tbStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDetails.Size = new System.Drawing.Size(538, 294);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.Text = "StudentDetails";
            this.tbStudentDetails.UseVisualStyleBackColor = true;
            // 
            // btnEnterDetails
            // 
            this.btnEnterDetails.Location = new System.Drawing.Point(377, 215);
            this.btnEnterDetails.Name = "btnEnterDetails";
            this.btnEnterDetails.Size = new System.Drawing.Size(75, 23);
            this.btnEnterDetails.TabIndex = 14;
            this.btnEnterDetails.Text = "Enter Details";
            this.btnEnterDetails.UseVisualStyleBackColor = true;
            this.btnEnterDetails.Click += new System.EventHandler(this.btnEnterDetails_Click);
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(377, 134);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 13;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(377, 105);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 20);
            this.txtMaths.TabIndex = 12;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(377, 77);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 11;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "DPD1A",
            "DPD1B",
            "BRA1A",
            "BRA1B"});
            this.cboGroup.Location = new System.Drawing.Point(121, 133);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(100, 21);
            this.cboGroup.TabIndex = 10;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(121, 105);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(121, 69);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 8;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(24, 133);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Group";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(24, 105);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 6;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(24, 72);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(307, 133);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 4;
            this.lblScience.Text = "Science";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(307, 105);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 3;
            this.lblMaths.Text = "Maths";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(307, 72);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 2;
            this.lblEnglish.Text = "English";
            // 
            // lblStudentMarks
            // 
            this.lblStudentMarks.AutoSize = true;
            this.lblStudentMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMarks.Location = new System.Drawing.Point(295, 26);
            this.lblStudentMarks.Name = "lblStudentMarks";
            this.lblStudentMarks.Size = new System.Drawing.Size(183, 13);
            this.lblStudentMarks.TabIndex = 1;
            this.lblStudentMarks.Text = "Please enter the student marks";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(24, 21);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(187, 13);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Please enter the student details";
            // 
            // tbGrades
            // 
            this.tbGrades.Controls.Add(this.txtGroup2);
            this.tbGrades.Controls.Add(this.txtScience2);
            this.tbGrades.Controls.Add(this.txtMaths2);
            this.tbGrades.Controls.Add(this.txtEnglish2);
            this.tbGrades.Controls.Add(this.txtStudentNumber2);
            this.tbGrades.Controls.Add(this.txtStudentName2);
            this.tbGrades.Controls.Add(this.lblScience2);
            this.tbGrades.Controls.Add(this.lblMaths2);
            this.tbGrades.Controls.Add(this.lblEnglish2);
            this.tbGrades.Controls.Add(this.lblGroups);
            this.tbGrades.Controls.Add(this.lblNumber);
            this.tbGrades.Controls.Add(this.lblName);
            this.tbGrades.Controls.Add(this.lblMarks);
            this.tbGrades.Controls.Add(this.lblDetails);
            this.tbGrades.Controls.Add(this.txtSearch);
            this.tbGrades.Controls.Add(this.btnSearch);
            this.tbGrades.Controls.Add(this.lblStudentNo);
            this.tbGrades.Location = new System.Drawing.Point(4, 22);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrades.Size = new System.Drawing.Size(538, 294);
            this.tbGrades.TabIndex = 1;
            this.tbGrades.Text = "Grades";
            this.tbGrades.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            this.tbResults.Controls.Add(this.txtStudentGrade);
            this.tbResults.Controls.Add(this.txtAverageMark);
            this.tbResults.Controls.Add(this.txtStudentDetails2);
            this.tbResults.Controls.Add(this.btnCalculate);
            this.tbResults.Controls.Add(this.btnClear2);
            this.tbResults.Controls.Add(this.lblStudentGrade);
            this.tbResults.Controls.Add(this.lblAverageMark);
            this.tbResults.Controls.Add(this.lblStudentName3);
            this.tbResults.Controls.Add(this.lblResults);
            this.tbResults.Location = new System.Drawing.Point(4, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(538, 294);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Results";
            this.tbResults.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(874, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(377, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Details";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(36, 12);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNo.TabIndex = 0;
            this.lblStudentNo.Text = "Student Number";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(158, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(36, 80);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(94, 13);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Student Details";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(333, 86);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(89, 13);
            this.lblMarks.TabIndex = 4;
            this.lblMarks.Text = "Student Marks";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Student Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(46, 147);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 13);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Student Number";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(46, 177);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(36, 13);
            this.lblGroups.TabIndex = 7;
            this.lblGroups.Text = "Group";
            // 
            // lblEnglish2
            // 
            this.lblEnglish2.AutoSize = true;
            this.lblEnglish2.Location = new System.Drawing.Point(333, 118);
            this.lblEnglish2.Name = "lblEnglish2";
            this.lblEnglish2.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish2.TabIndex = 8;
            this.lblEnglish2.Text = "English";
            // 
            // lblMaths2
            // 
            this.lblMaths2.AutoSize = true;
            this.lblMaths2.Location = new System.Drawing.Point(333, 147);
            this.lblMaths2.Name = "lblMaths2";
            this.lblMaths2.Size = new System.Drawing.Size(36, 13);
            this.lblMaths2.TabIndex = 9;
            this.lblMaths2.Text = "Maths";
            // 
            // lblScience2
            // 
            this.lblScience2.AutoSize = true;
            this.lblScience2.Location = new System.Drawing.Point(333, 177);
            this.lblScience2.Name = "lblScience2";
            this.lblScience2.Size = new System.Drawing.Size(46, 13);
            this.lblScience2.TabIndex = 10;
            this.lblScience2.Text = "Science";
            // 
            // txtStudentName2
            // 
            this.txtStudentName2.Location = new System.Drawing.Point(137, 115);
            this.txtStudentName2.Name = "txtStudentName2";
            this.txtStudentName2.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName2.TabIndex = 11;
            // 
            // txtStudentNumber2
            // 
            this.txtStudentNumber2.Location = new System.Drawing.Point(137, 147);
            this.txtStudentNumber2.Name = "txtStudentNumber2";
            this.txtStudentNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber2.TabIndex = 12;
            // 
            // txtEnglish2
            // 
            this.txtEnglish2.Location = new System.Drawing.Point(390, 115);
            this.txtEnglish2.Name = "txtEnglish2";
            this.txtEnglish2.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish2.TabIndex = 14;
            // 
            // txtMaths2
            // 
            this.txtMaths2.Location = new System.Drawing.Point(390, 147);
            this.txtMaths2.Name = "txtMaths2";
            this.txtMaths2.Size = new System.Drawing.Size(100, 20);
            this.txtMaths2.TabIndex = 15;
            // 
            // txtScience2
            // 
            this.txtScience2.Location = new System.Drawing.Point(390, 177);
            this.txtScience2.Name = "txtScience2";
            this.txtScience2.Size = new System.Drawing.Size(100, 20);
            this.txtScience2.TabIndex = 16;
            // 
            // txtGroup2
            // 
            this.txtGroup2.Location = new System.Drawing.Point(137, 177);
            this.txtGroup2.Name = "txtGroup2";
            this.txtGroup2.Size = new System.Drawing.Size(100, 20);
            this.txtGroup2.TabIndex = 17;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(25, 20);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results";
            // 
            // lblStudentName3
            // 
            this.lblStudentName3.AutoSize = true;
            this.lblStudentName3.Location = new System.Drawing.Point(41, 66);
            this.lblStudentName3.Name = "lblStudentName3";
            this.lblStudentName3.Size = new System.Drawing.Size(79, 13);
            this.lblStudentName3.TabIndex = 1;
            this.lblStudentName3.Text = "Student Details";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(41, 94);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(74, 13);
            this.lblAverageMark.TabIndex = 2;
            this.lblAverageMark.Text = "Average Mark";
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(41, 126);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(76, 13);
            this.lblStudentGrade.TabIndex = 3;
            this.lblStudentGrade.Text = "Student Grade";
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(342, 243);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 4;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(435, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtStudentDetails2
            // 
            this.txtStudentDetails2.Location = new System.Drawing.Point(159, 63);
            this.txtStudentDetails2.Name = "txtStudentDetails2";
            this.txtStudentDetails2.Size = new System.Drawing.Size(331, 20);
            this.txtStudentDetails2.TabIndex = 6;
            // 
            // txtAverageMark
            // 
            this.txtAverageMark.Location = new System.Drawing.Point(159, 94);
            this.txtAverageMark.Name = "txtAverageMark";
            this.txtAverageMark.Size = new System.Drawing.Size(331, 20);
            this.txtAverageMark.TabIndex = 7;
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(159, 126);
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.Size = new System.Drawing.Size(331, 20);
            this.txtStudentGrade.TabIndex = 8;
            this.txtStudentGrade.TextChanged += new System.EventHandler(this.txtStudentGrade_TextChanged);
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grades";
            this.Load += new System.EventHandler(this.frmStudentGrades_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbStudentDetails.PerformLayout();
            this.tbGrades.ResumeLayout(false);
            this.tbGrades.PerformLayout();
            this.tbResults.ResumeLayout(false);
            this.tbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbStudentDetails;
        private System.Windows.Forms.Button btnEnterDetails;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblStudentMarks;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TabPage tbGrades;
        private System.Windows.Forms.TabPage tbResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblScience2;
        private System.Windows.Forms.Label lblMaths2;
        private System.Windows.Forms.Label lblEnglish2;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtScience2;
        private System.Windows.Forms.TextBox txtMaths2;
        private System.Windows.Forms.TextBox txtEnglish2;
        private System.Windows.Forms.TextBox txtStudentNumber2;
        private System.Windows.Forms.TextBox txtStudentName2;
        private System.Windows.Forms.TextBox txtGroup2;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.TextBox txtAverageMark;
        private System.Windows.Forms.TextBox txtStudentDetails2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblStudentName3;
        private System.Windows.Forms.Label lblResults;
    }
}

