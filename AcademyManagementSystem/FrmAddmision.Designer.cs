﻿namespace AcademyManagementSystem
{
    partial class FrmAddmision
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
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlCourse = new System.Windows.Forms.ComboBox();
            this.ddlTeacher = new System.Windows.Forms.ComboBox();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.ddlStudent = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvList
            // 
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvList.Location = new System.Drawing.Point(617, 174);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowHeadersWidth = 62;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(378, 371);
            this.DgvList.TabIndex = 96;
            this.DgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edit";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(5, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 33);
            this.label4.TabIndex = 97;
            this.label4.Text = "Teacher";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(276, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(222, 53);
            this.btnSubmit.TabIndex = 94;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.ddlStatus.Location = new System.Drawing.Point(267, 365);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(301, 28);
            this.ddlStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 30);
            this.label3.TabIndex = 92;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 90;
            this.label2.Text = "Student";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1013, 53);
            this.label1.TabIndex = 89;
            this.label1.Text = "Form Addmision";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 33);
            this.label6.TabIndex = 102;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 33);
            this.label7.TabIndex = 104;
            this.label7.Text = "Class";
            // 
            // ddlCourse
            // 
            this.ddlCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCourse.FormattingEnabled = true;
            this.ddlCourse.Location = new System.Drawing.Point(267, 254);
            this.ddlCourse.Name = "ddlCourse";
            this.ddlCourse.Size = new System.Drawing.Size(301, 28);
            this.ddlCourse.TabIndex = 3;
            // 
            // ddlTeacher
            // 
            this.ddlTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeacher.FormattingEnabled = true;
            this.ddlTeacher.Location = new System.Drawing.Point(267, 196);
            this.ddlTeacher.Name = "ddlTeacher";
            this.ddlTeacher.Size = new System.Drawing.Size(301, 28);
            this.ddlTeacher.TabIndex = 2;
            // 
            // ddlClass
            // 
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(267, 315);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(301, 28);
            this.ddlClass.TabIndex = 4;
            // 
            // ddlStudent
            // 
            this.ddlStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStudent.FormattingEnabled = true;
            this.ddlStudent.Items.AddRange(new object[] {
            ""});
            this.ddlStudent.Location = new System.Drawing.Point(267, 128);
            this.ddlStudent.Name = "ddlStudent";
            this.ddlStudent.Size = new System.Drawing.Size(301, 28);
            this.ddlStudent.TabIndex = 1;
            // 
            // txtClass
            // 
            this.txtClass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtClass.Location = new System.Drawing.Point(810, 142);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(187, 26);
            this.txtClass.TabIndex = 109;
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCourse.Location = new System.Drawing.Point(617, 143);
            this.txtCourse.Multiline = true;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(187, 26);
            this.txtCourse.TabIndex = 108;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // txtTeacher
            // 
            this.txtTeacher.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTeacher.Location = new System.Drawing.Point(808, 107);
            this.txtTeacher.Multiline = true;
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(187, 26);
            this.txtTeacher.TabIndex = 107;
            this.txtTeacher.TextChanged += new System.EventHandler(this.txtTeacher_TextChanged);
            // 
            // txtStudent
            // 
            this.txtStudent.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStudent.Location = new System.Drawing.Point(617, 108);
            this.txtStudent.Multiline = true;
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(185, 26);
            this.txtStudent.TabIndex = 106;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(617, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 33);
            this.label14.TabIndex = 105;
            this.label14.Text = "Search By ...";
            // 
            // FrmAddmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 548);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ddlStudent);
            this.Controls.Add(this.ddlClass);
            this.Controls.Add(this.ddlTeacher);
            this.Controls.Add(this.ddlCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddmision";
            this.Text = "FrmAddmision";
            this.Load += new System.EventHandler(this.FrmAddmision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlCourse;
        private System.Windows.Forms.ComboBox ddlTeacher;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.ComboBox ddlStudent;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label14;
    }
}