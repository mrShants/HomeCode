using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
        }

        



        private void Username_Click(object sender, EventArgs e)
        {
            ResetIconPanel();
            Username.Text = null; 

            IconUser.IconColor = Color.FromArgb(18, 185, 248);
            pnlUser.BackColor = Color.FromArgb(18, 185, 248);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            ResetIconPanel();

            txtPassword.Text = null;
            txtPassword.PasswordChar = '*';

            iconPass.IconColor = Color.FromArgb(18, 185, 248);
            pnlPass.BackColor = Color.FromArgb(18, 185, 248);

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

            ResetIconPanel();

            txtEmail.Text = null;

            IconEmail.IconColor = Color.FromArgb(18, 185, 248);
            pnlEmail.BackColor = Color.FromArgb(18, 185, 248);

            
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtName_Click(object sender, EventArgs e)
        {

            ResetIconPanel();

            txtName.Text = null;

            iconName.IconColor = Color.FromArgb(18, 185, 248);
            pnlName.BackColor = Color.FromArgb(18, 185, 248);


        }

        private void ResetIconPanel()
        {
            IconEmail.IconColor = Color.White;
            pnlEmail.BackColor = Color.White;

            iconPass.IconColor = Color.White;
            pnlPass.BackColor = Color.White;

            IconUser.IconColor = Color.White;
            pnlUser.BackColor = Color.White;

            iconName.IconColor = Color.White;
            pnlName.BackColor = Color.White;

            iconSurname.IconColor = Color.White;
            pnlSurname.BackColor = Color.White;

            iconConfirmPassword.IconColor = Color.White;
            pnlConfirmPass.BackColor = Color.White;
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            ResetIconPanel();
            txtSurname.Clear();

            iconSurname.IconColor = Color.FromArgb(18, 185, 248);
            pnlSurname.BackColor = Color.FromArgb(18, 185, 248);
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            ResetIconPanel();
            txtConfirm.Clear();

            txtConfirm.Text = null;
            txtConfirm.PasswordChar = '*';

            iconConfirmPassword.IconColor = Color.FromArgb(18, 185, 248);
            pnlConfirmPass.BackColor = Color.FromArgb(18, 185, 248);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string userName = Username.Text;

            if(Username.Text == "Username" || string.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show("Please fill in all fields!");
            }
            
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords Dont match!");
                }
                
            }

            

        
        }

        

        
      
    }
}
