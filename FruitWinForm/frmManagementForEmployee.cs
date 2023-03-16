using FruitLibrary.DataAccess;
using FruitLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitWinForm
{
    public partial class frmManagementForEmployee : Form
    {
        IUserRepository userRepository = new UserRepository();
        private readonly FruitDbContext db = new();
        public frmManagementForEmployee()
        {
            InitializeComponent();
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
       


      

        

   

        

      

        private void cboFrom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var fruit = db.Fruits.Where(u => u.From.Contains(cboFrom.Text)).ToList();
            dataGridView1.DataSource = fruit;
        }

        private void btnReloadF_Click_1(object sender, EventArgs e)
        {
            txtIDf.Clear();
            txtNameF.Clear();
            txtFrom.Clear();
            txtPrice.Clear();
            LoadDataFruit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtSearchF_TextChanged_1(object sender, EventArgs e)
        {
            var fruit = db.Fruits.Where(u => u.FruitName.Contains(txtSearchF.Text)).ToList();
            dataGridView1.DataSource = fruit;
        }

        private void btnDeleteF_Click_1(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIDf.Text);
            Fruit fruitDelete = db.Fruits.Find(id);
            if (fruitDelete != null)
            {
                db.Fruits.Remove(fruitDelete);
                db.SaveChanges();
                MessageBox.Show("Fruit deleted successfully.");
                LoadDataFruit();
            }
            else
            {
                MessageBox.Show("Fruit not found.");
            }
        }

        private void btnUpdateF_Click_1(object sender, EventArgs e)
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

        private void btnAddF_Click_1(object sender, EventArgs e)
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

        private void frmManagementForEmployee_Load(object sender, EventArgs e)
        {
            LoadDataFruit();
        }
    }
}
