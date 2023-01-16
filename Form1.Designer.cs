namespace EvDP_07LabExer1_01112023
{
    partial class FrmClubRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_sid = new System.Windows.Forms.TextBox();
            this.txtBox_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_middlename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtBox_age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtg_update = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_update)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID : ";
            // 
            // txtBox_sid
            // 
            this.txtBox_sid.Location = new System.Drawing.Point(12, 40);
            this.txtBox_sid.Name = "txtBox_sid";
            this.txtBox_sid.Size = new System.Drawing.Size(211, 27);
            this.txtBox_sid.TabIndex = 1;
            // 
            // txtBox_lastname
            // 
            this.txtBox_lastname.Location = new System.Drawing.Point(12, 115);
            this.txtBox_lastname.Name = "txtBox_lastname";
            this.txtBox_lastname.Size = new System.Drawing.Size(211, 27);
            this.txtBox_lastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name : ";
            // 
            // txtBox_firstname
            // 
            this.txtBox_firstname.Location = new System.Drawing.Point(246, 115);
            this.txtBox_firstname.Name = "txtBox_firstname";
            this.txtBox_firstname.Size = new System.Drawing.Size(211, 27);
            this.txtBox_firstname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name : ";
            // 
            // txtBox_middlename
            // 
            this.txtBox_middlename.Location = new System.Drawing.Point(482, 115);
            this.txtBox_middlename.Name = "txtBox_middlename";
            this.txtBox_middlename.Size = new System.Drawing.Size(211, 27);
            this.txtBox_middlename.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(482, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Name : ";
            // 
            // cbProgram
            // 
            this.cbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT - Bachelor Science In Information Technology",
            "BSCpE - Bachelor Science in Computer Engineering",
            "IT - 2 Years Information Technology",
            "BSTM - Bachelor Science In Tourism Management",
            "BSCS - Bachelor Science In Computer Science",
            "ACT - 2 Years Associate in Computer Technology",
            "BSA - Bachelor Science in Accountancy",
            "BSBM - Bachelor Science in Business Administration",
            "ART - 2 Years Associate in Retail Technology",
            "BSMA - Bachelor Science in Management Accounting",
            "BSAIS - Bachelor Science in Accounting Information Systems",
            "<---TEST--->"});
            this.cbProgram.Location = new System.Drawing.Point(482, 40);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(298, 28);
            this.cbProgram.TabIndex = 8;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(482, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Program : ";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(786, 25);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 45);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(786, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 45);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(246, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender :  ";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(246, 187);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(150, 28);
            this.cbGender.TabIndex = 14;
            // 
            // txtBox_age
            // 
            this.txtBox_age.Location = new System.Drawing.Point(12, 188);
            this.txtBox_age.Name = "txtBox_age";
            this.txtBox_age.Size = new System.Drawing.Size(136, 27);
            this.txtBox_age.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "List of Club Members";
            // 
            // dtg_update
            // 
            this.dtg_update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_update.Location = new System.Drawing.Point(13, 275);
            this.dtg_update.Name = "dtg_update";
            this.dtg_update.RowHeadersWidth = 51;
            this.dtg_update.RowTemplate.Height = 29;
            this.dtg_update.Size = new System.Drawing.Size(735, 140);
            this.dtg_update.TabIndex = 17;
            this.dtg_update.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_update_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(786, 275);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 45);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 432);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtg_update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_age);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.txtBox_middlename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_sid);
            this.Controls.Add(this.label1);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBox_sid;
        private TextBox txtBox_lastname;
        private Label label2;
        private TextBox txtBox_firstname;
        private Label label3;
        private TextBox txtBox_middlename;
        private Label label4;
        private ComboBox cbProgram;
        private Label label5;
        private Button btnRegister;
        private Button btnUpdate;
        private Label label6;
        private Label label7;
        private ComboBox cbGender;
        private TextBox txtBox_age;
        private Label label8;
        private DataGridView dtg_update;
        private Button btnRefresh;
    }
}