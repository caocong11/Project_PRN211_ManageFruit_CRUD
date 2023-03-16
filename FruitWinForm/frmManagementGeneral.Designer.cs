namespace FruitWinForm
{
    partial class frmManagementGeneral
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
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tpFruit = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.txtSearchF = new System.Windows.Forms.TextBox();
            this.btnReloadF = new System.Windows.Forms.Button();
            this.btnDeleteF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameF = new System.Windows.Forms.TextBox();
            this.btnAddF = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIDf = new System.Windows.Forms.TextBox();
            this.btnUpdateF = new System.Windows.Forms.Button();
            this.tcGeneral.SuspendLayout();
            this.tpEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tpFruit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.tpEmployee);
            this.tcGeneral.Controls.Add(this.tpFruit);
            this.tcGeneral.Location = new System.Drawing.Point(12, 12);
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(1074, 586);
            this.tcGeneral.TabIndex = 0;
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.btnReload);
            this.tpEmployee.Controls.Add(this.cbAddress);
            this.tpEmployee.Controls.Add(this.txtSearch);
            this.tpEmployee.Controls.Add(this.label7);
            this.tpEmployee.Controls.Add(this.panel1);
            this.tpEmployee.Controls.Add(this.btnDelete);
            this.tpEmployee.Controls.Add(this.dgvEmployee);
            this.tpEmployee.Location = new System.Drawing.Point(4, 29);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployee.Size = new System.Drawing.Size(1066, 553);
            this.tpEmployee.TabIndex = 0;
            this.tpEmployee.Text = "Infomation ";
            this.tpEmployee.UseVisualStyleBackColor = true;
            this.tpEmployee.Click += new System.EventHandler(this.tpEmployee_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(138, 76);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(126, 48);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(319, 86);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(119, 28);
            this.cbAddress.TabIndex = 6;
            this.cbAddress.Text = "Address";
            this.cbAddress.SelectedIndexChanged += new System.EventHandler(this.cbAddress_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(465, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 27);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(374, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Management Employee";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(697, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 418);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txtAddress);
            this.panel7.Location = new System.Drawing.Point(17, 293);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 52);
            this.panel7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 10);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(130, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpDOB);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 52);
            this.panel6.TabIndex = 5;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(86, 11);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(244, 27);
            this.dtpDOB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "DOB";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Location = new System.Drawing.Point(17, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 52);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 27);
            this.txtName.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Location = new System.Drawing.Point(3, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 52);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 11);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Location = new System.Drawing.Point(3, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 52);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(86, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 48);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(32, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 52);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(57, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(103, 27);
            this.txtID.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 48);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 129);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(688, 418);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // tpFruit
            // 
            this.tpFruit.Controls.Add(this.label14);
            this.tpFruit.Controls.Add(this.cboFrom);
            this.tpFruit.Controls.Add(this.txtSearchF);
            this.tpFruit.Controls.Add(this.btnReloadF);
            this.tpFruit.Controls.Add(this.btnDeleteF);
            this.tpFruit.Controls.Add(this.dataGridView1);
            this.tpFruit.Controls.Add(this.panel8);
            this.tpFruit.Location = new System.Drawing.Point(4, 29);
            this.tpFruit.Name = "tpFruit";
            this.tpFruit.Padding = new System.Windows.Forms.Padding(3);
            this.tpFruit.Size = new System.Drawing.Size(1066, 553);
            this.tpFruit.TabIndex = 1;
            this.tpFruit.Text = "Fruit";
            this.tpFruit.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(377, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 45);
            this.label14.TabIndex = 11;
            this.label14.Text = "Management Fruit";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(436, 86);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(119, 28);
            this.cboFrom.TabIndex = 10;
            this.cboFrom.Text = "From";
            this.cboFrom.SelectedIndexChanged += new System.EventHandler(this.cboFrom_SelectedIndexChanged);
            // 
            // txtSearchF
            // 
            this.txtSearchF.Location = new System.Drawing.Point(561, 86);
            this.txtSearchF.Name = "txtSearchF";
            this.txtSearchF.Size = new System.Drawing.Size(130, 27);
            this.txtSearchF.TabIndex = 9;
            this.txtSearchF.TextChanged += new System.EventHandler(this.txtSearchF_TextChanged);
            // 
            // btnReloadF
            // 
            this.btnReloadF.Location = new System.Drawing.Point(138, 75);
            this.btnReloadF.Name = "btnReloadF";
            this.btnReloadF.Size = new System.Drawing.Size(126, 48);
            this.btnReloadF.TabIndex = 8;
            this.btnReloadF.Text = "Reload";
            this.btnReloadF.UseVisualStyleBackColor = true;
            this.btnReloadF.Click += new System.EventHandler(this.btnReloadF_Click);
            // 
            // btnDeleteF
            // 
            this.btnDeleteF.Location = new System.Drawing.Point(6, 75);
            this.btnDeleteF.Name = "btnDeleteF";
            this.btnDeleteF.Size = new System.Drawing.Size(126, 48);
            this.btnDeleteF.TabIndex = 7;
            this.btnDeleteF.Text = "Delete";
            this.btnDeleteF.UseVisualStyleBackColor = true;
            this.btnDeleteF.Click += new System.EventHandler(this.btnDeleteF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(685, 418);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.btnAddF);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.btnUpdateF);
            this.panel8.Location = new System.Drawing.Point(694, 178);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 337);
            this.panel8.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.txtPrice);
            this.panel11.Location = new System.Drawing.Point(17, 177);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(298, 52);
            this.panel11.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(72, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.txtFrom);
            this.panel12.Location = new System.Drawing.Point(3, 119);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(312, 52);
            this.panel12.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(86, 11);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(170, 27);
            this.txtFrom.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.txtNameF);
            this.panel13.Location = new System.Drawing.Point(3, 61);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(312, 52);
            this.panel13.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // txtNameF
            // 
            this.txtNameF.Location = new System.Drawing.Point(86, 10);
            this.txtNameF.Name = "txtNameF";
            this.txtNameF.Size = new System.Drawing.Size(170, 27);
            this.txtNameF.TabIndex = 1;
            // 
            // btnAddF
            // 
            this.btnAddF.Location = new System.Drawing.Point(32, 235);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(126, 48);
            this.btnAddF.TabIndex = 6;
            this.btnAddF.Text = "Add";
            this.btnAddF.UseVisualStyleBackColor = true;
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label13);
            this.panel14.Controls.Add(this.txtIDf);
            this.panel14.Location = new System.Drawing.Point(32, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(250, 52);
            this.panel14.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID";
            // 
            // txtIDf
            // 
            this.txtIDf.Location = new System.Drawing.Point(57, 14);
            this.txtIDf.Name = "txtIDf";
            this.txtIDf.ReadOnly = true;
            this.txtIDf.Size = new System.Drawing.Size(103, 27);
            this.txtIDf.TabIndex = 3;
            // 
            // btnUpdateF
            // 
            this.btnUpdateF.Location = new System.Drawing.Point(164, 235);
            this.btnUpdateF.Name = "btnUpdateF";
            this.btnUpdateF.Size = new System.Drawing.Size(126, 48);
            this.btnUpdateF.TabIndex = 7;
            this.btnUpdateF.Text = "Update";
            this.btnUpdateF.UseVisualStyleBackColor = true;
            this.btnUpdateF.Click += new System.EventHandler(this.btnUpdateF_Click);
            // 
            // frmManagementGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 610);
            this.Controls.Add(this.tcGeneral);
            this.Name = "frmManagementGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementGeneral";
            this.Load += new System.EventHandler(this.frmManagementGeneral_Load);
            this.tcGeneral.ResumeLayout(false);
            this.tpEmployee.ResumeLayout(false);
            this.tpEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tpFruit.ResumeLayout(false);
            this.tpFruit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcGeneral;
        private TabPage tpEmployee;
        private Panel panel1;
        private Button btnUpdate;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvEmployee;
        private TabPage tpFruit;
        private Panel panel2;
        private TextBox txtID;
        private Panel panel7;
        private Label label6;
        private TextBox txtAddress;
        private Panel panel6;
        private DateTimePicker dtpDOB;
        private Label label5;
        private Panel panel5;
        private Label label4;
        private TextBox txtName;
        private Panel panel4;
        private Label label3;
        private TextBox txtPassword;
        private Panel panel3;
        private Label label2;
        private TextBox txtUsername;
        private ComboBox cbAddress;
        private TextBox txtSearch;
        private Label label7;
        private Button btnReload;
        private Label label14;
        private ComboBox cboFrom;
        private TextBox txtSearchF;
        private Button btnReloadF;
        private Button btnDeleteF;
        private DataGridView dataGridView1;
        private Panel panel8;
        private Panel panel11;
        private Label label10;
        private TextBox txtPrice;
        private Panel panel12;
        private Label label11;
        private TextBox txtFrom;
        private Panel panel13;
        private Label label12;
        private TextBox txtNameF;
        private Button btnAddF;
        private Panel panel14;
        private Label label13;
        private TextBox txtIDf;
        private Button btnUpdateF;
    }
}