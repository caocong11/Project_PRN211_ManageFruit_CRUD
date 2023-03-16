using FruitLibrary.DataAccess;
using FruitLibrary.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FruitWinForm
{
    public partial class frmManagementGeneral : Form
    {
        IUserRepository userRepository = new UserRepository();
        private readonly FruitDbContext db = new();
        public frmManagementGeneral()
        {
            InitializeComponent();
        }

       public void LoadDataUser()
        {
            cbAddress.DataSource = (from x in db.Users
                                    select x.Address).Distinct().ToList();
            dgvEmployee.DataSource = (from x in db.Users select new
            {
                Id = x.Id,
                Username = x.Acc,
                Password = x.Pass,
                Name= x.Name,
                Dob = x.Dob,
                Address = x.Address }).ToList();
        }

        public void LoadDataFruit()
        {
            cboFrom.DataSource = (from x in db.Fruits select x.From).Distinct().ToList();
            dataGridView1.DataSource = (from x in db.Fruits
                                        select new
                                        {
                                            Id = x.Id,
                                            Name = x.FruitName,
                                            From = x.From,
                                            Price = x.Price
                                        }).ToList();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtUsername.Text = row.Cells[1].Value.ToString();
                    txtPassword.Text = row.Cells[2].Value.ToString();
                    txtName.Text = row.Cells[3].Value.ToString();
                    dtpDOB.Text = row.Cells[4].Value.ToString();
                    txtAddress.Text = row.Cells[5].Value.ToString();
                     
                  
                }
            }
        }

        private void tpEmployee_Click(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void frmManagementGeneral_Load(object sender, EventArgs e)
        {
          
            
                LoadDataUser();
            
           
                LoadDataFruit();    
            
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var u = db.Users.Find(Int32.Parse(txtID.Text));
                u.Acc = txtUsername.Text;
                u.Pass= txtPassword.Text;
                u.Address = txtAddress.Text;
                u.Dob = dtpDOB.Value;
                u.Name= txtName.Text;
                db.SaveChanges();
                MessageBox.Show("Update Success!");
                LoadDataUser();



            }
            catch
            {
                MessageBox.Show("Update failed!");
            }
        }
   
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string acc = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string address = txtAddress.Text.Trim();


            bool accountExists = db.Users.Any(a => a.Acc == acc);

            if (accountExists)
            {
                MessageBox.Show("An account already exists.");
            }
            else
            {

                FruitLibrary.DataAccess.User u = new FruitLibrary.DataAccess.User();
                u.Name = name;
                u.Acc = acc;
                u.Pass = pass;
                u.Address = address;
                u.Dob = dob;
                db.Add(u);
                db.SaveChanges();
                MessageBox.Show("Add user success!");
                LoadDataUser();
            }
            
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            FruitLibrary.DataAccess.User userToDelete = db.Users.Find(id);
            if (userToDelete != null)
            {
                db.Users.Remove(userToDelete);
                db.SaveChanges();
                MessageBox.Show("Employee deleted successfully.");
                LoadDataUser();
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var users = db.Users.Where(u => u.Address.Contains(cbAddress.Text)).ToList();
            dgvEmployee.DataSource = users;

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            LoadDataUser();
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var users = db.Users.Where(u => u.Acc.Contains(txtSearch.Text)).ToList();
            dgvEmployee.DataSource = users;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtIDf.Text = row.Cells[0].Value.ToString();
                    txtNameF.Text = row.Cells[1].Value.ToString();
                    txtFrom.Text = row.Cells[2].Value.ToString();
                    txtPrice.Text = row.Cells[3].Value.ToString();
                   


                }
            }
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            string name = txtNameF.Text;
            string from = txtFrom.Text;
            string price = txtPrice.Text;
            
            bool fruitExist = db.Fruits.Any(a => a.FruitName == name);
            if (fruitExist)
            {
                MessageBox.Show("Add failed!");
            }
            else
            {
                Fruit f = new Fruit();
                f.FruitName = name;
                f.From = from;
                f.Price = price;
                db.Fruits.Add(f);
                db.SaveChanges();
                MessageBox.Show("Add Fruit Success!");
                LoadDataFruit();


            }


        }

        private void btnUpdateF_Click(object sender, EventArgs e)
        {
           

            try
            {
                var f = db.Fruits.Find(Int32.Parse(txtIDf.Text));
                f.FruitName = txtNameF.Text;
                f.From = txtFrom.Text;
                f.Price = txtPrice.Text;
             
                db.SaveChanges();
                MessageBox.Show("Update Success!");
                LoadDataFruit();



            }
            catch
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnReloadF_Click(object sender, EventArgs e)
        {
            txtIDf.Clear();
            txtNameF.Clear();
            txtFrom.Clear();
            txtPrice.Clear();
            LoadDataFruit() ;
        }

        private void btnDeleteF_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIDf.Text);
          Fruit fruitDelete = db.Fruits.Find(id);
            if (fruitDelete != null)
            {
                db.Fruits.Remove(fruitDelete);
                db.SaveChanges();
                MessageBox.Show("Fruit deleted successfully.");
                LoadDataUser();
            }
            else
            {
                MessageBox.Show("Fruit not found.");
            }
        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fruit = db.Fruits.Where(u => u.From.Contains(cboFrom.Text)).ToList();
            dataGridView1.DataSource = fruit;
        }

        private void txtSearchF_TextChanged(object sender, EventArgs e)
        {
            var fruit = db.Fruits.Where(u => u.FruitName.Contains(txtSearchF.Text)).ToList();
            dataGridView1.DataSource = fruit;
        }
    }
}
