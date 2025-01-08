namespace StudentApplicationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            cmbCourseName = new ComboBox();
            txtMarksObtained = new TextBox();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtStudentID = new TextBox();
            label4 = new Label();
            txtStudentName = new TextBox();
            label3 = new Label();
            lblBaseFee = new TextBox();
            lblConcession = new TextBox();
            lblFinalFee = new TextBox();
            btnSubmit = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 18);
            label1.Name = "label1";
            label1.Size = new Size(335, 40);
            label1.TabIndex = 0;
            label1.Text = "Student Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 15F);
            label2.Location = new Point(45, 58);
            label2.Name = "label2";
            label2.Size = new Size(676, 29);
            label2.TabIndex = 1;
            label2.Text = "***************************************************";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbCourseName);
            groupBox1.Controls.Add(txtMarksObtained);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(78, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 409);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter your details :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 268);
            label7.Name = "label7";
            label7.Size = new Size(249, 40);
            label7.TabIndex = 9;
            label7.Text = "Course Name :";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Items.AddRange(new object[] { "Computer Science", "Commerce", "Media Studies", "Psychology" });
            cmbCourseName.Location = new Point(272, 265);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(313, 47);
            cmbCourseName.TabIndex = 8;
            // 
            // txtMarksObtained
            // 
            txtMarksObtained.Location = new Point(500, 340);
            txtMarksObtained.Name = "txtMarksObtained";
            txtMarksObtained.Size = new Size(85, 47);
            txtMarksObtained.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 343);
            label6.Name = "label6";
            label6.Size = new Size(477, 40);
            label6.TabIndex = 6;
            label6.Text = "Marks Obtained (out of 100) :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(296, 197);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(289, 47);
            txtPhoneNumber.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 200);
            label5.Name = "label5";
            label5.Size = new Size(273, 40);
            label5.TabIndex = 4;
            label5.Text = "Phone Number :";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(233, 128);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(286, 47);
            txtStudentID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 131);
            label4.Name = "label4";
            label4.Size = new Size(210, 40);
            label4.TabIndex = 2;
            label4.Text = "Student ID :";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(287, 57);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(298, 47);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 60);
            label3.Name = "label3";
            label3.Size = new Size(264, 40);
            label3.TabIndex = 0;
            label3.Text = "Student Name :";
            // 
            // lblBaseFee
            // 
            lblBaseFee.Location = new Point(95, 537);
            lblBaseFee.Name = "lblBaseFee";
            lblBaseFee.Size = new Size(358, 47);
            lblBaseFee.TabIndex = 3;
            // 
            // lblConcession
            // 
            lblConcession.Location = new Point(95, 613);
            lblConcession.Name = "lblConcession";
            lblConcession.Size = new Size(358, 47);
            lblConcession.TabIndex = 4;
            // 
            // lblFinalFee
            // 
            lblFinalFee.Location = new Point(95, 687);
            lblFinalFee.Name = "lblFinalFee";
            lblFinalFee.Size = new Size(358, 47);
            lblFinalFee.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(493, 537);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(211, 100);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit Application";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 658);
            button1.Name = "button1";
            button1.Size = new Size(211, 55);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(751, 757);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(lblFinalFee);
            Controls.Add(lblConcession);
            Controls.Add(lblBaseFee);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 6, 8, 6);
            Name = "Form1";
            Text = "StudentApplicationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtStudentName;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtStudentID;
        private Label label4;
        private Label label7;
        private ComboBox cmbCourseName;
        private TextBox txtMarksObtained;
        private Label label6;
        private TextBox lblBaseFee;
        private TextBox lblConcession;
        private TextBox lblFinalFee;
        private Button btnSubmit;
        private Button button1;
    }
}
