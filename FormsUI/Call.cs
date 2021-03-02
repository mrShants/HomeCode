using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace FormsUI
{
    public partial class Call : Form
    {
        public Call()
        {
            InitializeComponent();
        }
        public string customerName;
        public string customerSurname;
        public string customerContact;
        public string callDuration;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        bool isActive;

        private void Call_Load(object sender, EventArgs e)
        {
            lblName.Text = customerName;
            lblSurname.Text = customerSurname;
            lblContact.Text = customerContact;
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            isActive = true;
            callTimer.Start();
        }

        public void GetCustomerDetails(string name, string surname, string contact)
        {
            customerName = name;
            customerSurname = surname;
            customerContact = contact;
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void callTimer_Tick(object sender, EventArgs e)
        {
            

            seconds++;

            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
                if(minutes > 59)
                {
                    hours++;
                    minutes = 0;
                }
            }

            lblseconds.Text = seconds.ToString();
            lblMinutes.Text = minutes.ToString();
            lblhours.Text = hours.ToString();

            callDuration = lblhours.Text +":"+ lblMinutes.Text +":"+ lblseconds.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CallLogs calllog = new CallLogs();
            calllog.InsertBLCall(customerName, customerSurname, callDuration);

            callTimer.Stop();


            this.Close();
        }
    }
}
