using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMenagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Barnat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MedicineForm Medform = new MedicineForm();
        Employees employeeform = new Employees();
        Company companyform = new Company();
        BillingForm billingform = new BillingForm();
        private void Barnatbtn_Click(object sender, EventArgs e)
        {
            Medform.Show();
            this.Hide();
        }

        private void Puntoretbtn_Click(object sender, EventArgs e)
        {
            employeeform.Show();
            this.Hide();
        }

        private void Kompaniabtn_Click(object sender, EventArgs e)
        {
            companyform.Show();
            this.Hide();
        }

        private void Faturabtn_Click(object sender, EventArgs e)
        {
            billingform.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
