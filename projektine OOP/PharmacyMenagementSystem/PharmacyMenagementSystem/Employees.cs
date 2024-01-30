using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PharmacyMenagementSystem
{
    public partial class Employees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\LocalDb;Integrated Security=True");
        public void Mbushe()
        {
            con.Open();
            string Myquery = "SELECT * FROM [Employee_tbl]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            EmployeeDataGrid.ReadOnly = true;
            EmployeeDataGrid.DataSource = ds.Tables[0];

            con.Close();

        }
        public Employees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDpuntorit.Text == "" || Emripunetorit.Text == "" || Rrogapunetorit.Text == "" || Moshapunetorit.Text == "" || Nrtelefonit.Text == "" || Passwordipunetorit.Text == "" )
            {
                MessageBox.Show("Mungojne te dhena!\nJu lutem jepni gjitha te dhenat.");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Employee_tbl] VALUES('" + IDpuntorit.Text + "','" + Emripunetorit.Text + "'," + Rrogapunetorit.Text + "," + Moshapunetorit.Text + ",'" + Nrtelefonit.Text + "','"+Passwordipunetorit.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Punetori u shtua me sukses");
                con.Close();
                Mbushe();
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Mbushe();
        }

        private void EmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmployeeDataGrid.Rows.Count)
            {
                DataGridViewRow selectedRow = EmployeeDataGrid.Rows[e.RowIndex];

                IDpuntorit.Text = selectedRow.Cells[0].Value.ToString();
                Emripunetorit.Text = selectedRow.Cells[1].Value.ToString();
                Rrogapunetorit.Text = selectedRow.Cells[2].Value.ToString();
                Moshapunetorit.Text = selectedRow.Cells[3].Value.ToString();
                Nrtelefonit.Text = selectedRow.Cells[4].Value.ToString();
                Passwordipunetorit.Text = selectedRow.Cells[5].Value.ToString();

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "UPDATE [Employee_tbl] SET Emripunetorit=@Emripunetorit, Rrogapunetorit=@Rrogapunetorit, Moshapunetorit=@Moshapunetorit, Nrtelefonit=@Nrtelefonit WHERE IDpunetorit=@IDpunetorit";

            SqlCommand cmd = new SqlCommand(Myquery, con);

            cmd.Parameters.AddWithValue("@IDpunetorit", IDpuntorit.Text);
            cmd.Parameters.AddWithValue("@Emripunetorit", Emripunetorit.Text);
            cmd.Parameters.AddWithValue("@Rrogapunetorit", Rrogapunetorit.Text);
            cmd.Parameters.AddWithValue("@Moshapunetorit", Moshapunetorit.Text);
            cmd.Parameters.AddWithValue("@Nrtelefonit", Nrtelefonit.Text);
            cmd.Parameters.AddWithValue("@Passwordipunetorit", Passwordipunetorit.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Punetoret u ben Update");
            con.Close();
            Mbushe();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (IDpuntorit.Text == "")
            {
                MessageBox.Show("Gabim!Nese deshiron te fshish shtyp butonin \'DELETE\' ");
            }
            else
            {
                con.Open();
                string query = "delete from Employee_tbl where IDpunetorit ='" + IDpuntorit.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Punetori u fshi!");
                con.Close();
                Mbushe();
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }
    }
    
}

