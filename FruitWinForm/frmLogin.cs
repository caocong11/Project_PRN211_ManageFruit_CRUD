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
    public partial class frmLogin : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; 
            string pass = txtPass.Text;
            var user = userRepository.GetUser(username, pass);

            if(user != null && user.Id.Equals(1))
            {
                frmManagementGeneral frm = new frmManagementGeneral();
                frm.ShowDialog();
                this.Hide();
            }else if(user != null)
            {
                frmManagementForEmployee frm = new frmManagementForEmployee();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
