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
    public partial class AddTechnicalForm : Form
    {
        public AddTechnicalForm()
        {
            InitializeComponent();
        }

        private void btnInsertTech_Click(object sender, EventArgs e)
        {
            string name = txtTechName.Text;
            string surname = txtTechSurname.Text;
            string deployed = txtTechDeployed.Text;
            string deployeDate = txtTechDeployDate.Text;
            string specialization = cmbSpecialization.Text;

            TechnicalStaff ts = new TechnicalStaff();
            ts.InsertTechnical(name, surname, specialization);

            FormManagement fm = new FormManagement();
            fm.RefreshPage();

            this.Close();
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
