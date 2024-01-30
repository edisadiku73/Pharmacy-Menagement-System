using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyMenagementSystem
{
    public partial class Company : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\LocalDb;Integrated Security=True");
        public void Mbushe()
        {
            con.Open();
            string Myquery = "SELECT * FROM [Company_tbl]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanydataGridView.ReadOnly = true;
            CompanydataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public Company()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (IDkompanis.Text == "" || Nrkompanis.Text == "" || Emrikompanis.Text == "" || Adresakompanis.Text == "")
            {
                MessageBox.Show("Mungojne te dhena!\nJu lutem jepni gjitha te dhenat.");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Company_tbl] VALUES('" + IDkompanis.Text + "','" + Emrikompanis.Text + "','" + Nrkompanis.Text + "','" + Adresakompanis.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kompania u shtua me sukses");
                con.Close();
                Mbushe();
            }
        }

        private void CompanydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CompanydataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = CompanydataGridView.Rows[e.RowIndex];

                IDkompanis.Text = selectedRow.Cells[0].Value.ToString();
                Emrikompanis.Text = selectedRow.Cells[1].Value.ToString();
                Nrkompanis.Text = selectedRow.Cells[2].Value.ToString();
                Adresakompanis.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            Mbushe();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "UPDATE [Company_tbl] SET EmriKompanis=@EmriKompanis, NrTelefonit=@NrTelefonit, Adresa=@Adresa WHERE IDKompanis=@IDKompanis";

            SqlCommand cmd = new SqlCommand(Myquery, con);

            cmd.Parameters.AddWithValue("@IDKompanis", IDkompanis.Text);
            cmd.Parameters.AddWithValue("@EmriKompanis", Emrikompanis.Text);
            cmd.Parameters.AddWithValue("@NrTelefonit", Nrkompanis.Text);
            cmd.Parameters.AddWithValue("@Adresa", Adresakompanis.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kompania u be Update");
            con.Close();
            Mbushe();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (IDkompanis.Text == "")
            {
                MessageBox.Show("Gabim!Nese deshiron te fshish shtyp butonin \'DELETE\' ");
            }
            else
            {
                con.Open();
                string query = "delete from Company_tbl where IDKompanis ='" + IDkompanis.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kompania u fshi!");
                con.Close();
                Mbushe();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }
    }
}

