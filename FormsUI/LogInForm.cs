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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
      
        SingInForm sf = new SingInForm();

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();

            IconUser.IconColor = Color.FromArgb(18, 185, 248);
            pnlUser.BackColor = Color.FromArgb(18, 185, 248);

            iconPass.IconColor = Color.White;
            pnlPass.BackColor = Color.White; 

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();

            txtPassword.PasswordChar = '*';

            iconPass.IconColor = Color.FromArgb(18, 185, 248);
            pnlPass.BackColor = Color.FromArgb(18, 185, 248);

            IconUser.IconColor = Color.White;
            pnlUser.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sf.Show();
            sf.Left += 10;
            if(sf.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;
                sf.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            sf.Left -= 10;
            if(sf.Left <= 790)
            {
                timer2.Stop();
                
            }

          
        }

        public void AssignUsername(string userName)
        {
            txtUsername.Text = userName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
