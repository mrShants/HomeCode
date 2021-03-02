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
    public partial class UpdateTechForm : Form
    {
        public UpdateTechForm()
        {
            InitializeComponent();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblTechID.Text);
            string name = txtTechName.Text;
            string surname = txtTechSurname.Text;
            string specialization = cmbSpecialization.Text;
            string deployed = txtTechDeployed.Text;
            string deploymentDate = dtpDeployDate.Value.ToString("dd/MM/yyyy");

            TechnicalStaff ts = new TechnicalStaff();
            ts.UpdateBLTechnical(id, name, surname, specialization, deployed, deploymentDate);

            MessageBox.Show(deploymentDate);
            FormManagement fm = new FormManagement();
            fm.RefreshPage();

            UpdateTechForm utf = new UpdateTechForm();
            utf.Close();

        }
        public void SelectedTechValuess(string id,string name, string surname, string specialization, string deployed,string deployementDate)
        {
            lblTechID.Text = id;
            txtTechName.Text = name;
            txtTechSurname.Text = surname;
            cmbSpecialization.Text = specialization;
            txtTechDeployed.Text = deployed;
            dtpDeployDate.Text = deployementDate;
            

        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
