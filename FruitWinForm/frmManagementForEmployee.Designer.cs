namespace FruitWinForm
{
    partial class frmManagementForEmployee
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(380, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 45);
            this.label14.TabIndex = 18;
            this.label14.Text = "Management Fruit";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(439, 112);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(119, 28);
            this.cboFrom.TabIndex = 17;
            this.cboFrom.Text = "From";
            this.cboFrom.SelectedIndexChanged += new System.EventHandler(this.cboFrom_SelectedIndexChanged_1);
            // 
            // txtSearchF
            // 
            this.txtSearchF.Location = new System.Drawing.Point(564, 112);
            this.txtSearchF.Name = "txtSearchF";
            this.txtSearchF.Size = new System.Drawing.Size(130, 27);
            this.txtSearchF.TabIndex = 16;
            this.txtSearchF.TextChanged += new System.EventHandler(this.txtSearchF_TextChanged_1);
            // 
            // btnReloadF
            // 
            this.btnReloadF.Location = new System.Drawing.Point(141, 101);
            this.btnReloadF.Name = "btnReloadF";
            this.btnReloadF.Size = new System.Drawing.Size(126, 48);
            this.btnReloadF.TabIndex = 15;
            this.btnReloadF.Text = "Reload";
            this.btnReloadF.UseVisualStyleBackColor = true;
            this.btnReloadF.Click += new System.EventHandler(this.btnReloadF_Click_1);
            // 
            // btnDeleteF
            // 
            this.btnDeleteF.Location = new System.Drawing.Point(9, 101);
            this.btnDeleteF.Name = "btnDeleteF";
            this.btnDeleteF.Size = new System.Drawing.Size(126, 48);
            this.btnDeleteF.TabIndex = 14;
            this.btnDeleteF.Text = "Delete";
            this.btnDeleteF.UseVisualStyleBackColor = true;
            this.btnDeleteF.Click += new System.EventHandler(this.btnDeleteF_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(685, 418);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.panel8.Location = new System.Drawing.Point(697, 204);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 337);
            this.panel8.TabIndex = 12;
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
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click_1);
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
            this.btnUpdateF.Click += new System.EventHandler(this.btnUpdateF_Click_1);
            // 
            // frmManagementForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 603);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.txtSearchF);
            this.Controls.Add(this.btnReloadF);
            this.Controls.Add(this.btnDeleteF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel8);
            this.Name = "frmManagementForEmployee";
            this.Text = "frmManagementForEmployee";
            this.Load += new System.EventHandler(this.frmManagementForEmployee_Load);
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
            this.PerformLayout();

        }

        #endregion

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