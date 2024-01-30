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
using System.Data.Common;

namespace PharmacyMenagementSystem
{
    public partial class MedicineForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\LocalDb;Integrated Security=True");
        public void Mbushe()
        {
            con.Open();
            string Myquery = "SELECT * FROM [Medicine_tbl]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery,con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = ds.Tables[0];
         
              con.Close(); 
            
        }
        public void ShikoSasin()
        {
            con.Open();
            string myquery = "SELECT Sasia FROM [Medicine_tbl]";
            SqlCommand cmd = new SqlCommand(myquery,con);
            int sasia = Convert.ToInt32(cmd.ExecuteScalar());
            if (sasia <= 10)
            {
                MessageBox.Show("Notifikim: Sasia e barnave eshte nen 10. Kontrolloni nivelet e stokut!");
            } 
            con.Close();
        }
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ebarnes.Text == "" || Qblerjes.Text == "" || Qshitjes.Text == "" || sasia.Text == "" || combo.SelectedItem == null)
            {
                MessageBox.Show("Mungojne te dhena!\nJu lutem jepni gjitha te dhenat.");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Medicine_tbl] VALUES('" + Ebarnes.Text + "'," + Qblerjes.Text + "," + Qshitjes.Text + "," + sasia.Text + ",'" + dataskadimit.Text + "','" + combo.SelectedItem.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barna u shtua me sukses");
                con.Close();
                Mbushe();
            }
        }
        public void fillcombobox()
        {
            string sql = "select EmriKompanis from Company_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmriKompanis", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                combo.ValueMember = "EmriKompanis";
                combo.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            Mbushe();
            fillcombobox();
            ShikoSasin();
        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MedicineGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = MedicineGridView.Rows[e.RowIndex];

                Ebarnes.Text = selectedRow.Cells[0].Value.ToString();
                Qblerjes.Text = selectedRow.Cells[1].Value.ToString();
                Qshitjes.Text = selectedRow.Cells[2].Value.ToString();
                sasia.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "UPDATE [Medicine_tbl] SET qmimiblerjes=@qmimiblerjes, qmimishitjes=@qmimishitjes, Sasia=@Sasia, [Data Skadimit]=@DataSkadimit, Kompania=@Kompania WHERE EmriBarnes=@EmriBarnes";

            SqlCommand cmd = new SqlCommand(Myquery, con);

            cmd.Parameters.AddWithValue("@qmimiblerjes", Qblerjes.Text);
            cmd.Parameters.AddWithValue("@qmimishitjes", Qshitjes.Text);
            cmd.Parameters.AddWithValue("@Sasia", sasia.Text);
            cmd.Parameters.AddWithValue("@DataSkadimit", dataskadimit.Text);
            cmd.Parameters.AddWithValue("@Kompania", combo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@EmriBarnes", Ebarnes.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Barnat u benen Update");
            con.Close();
            Mbushe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Ebarnes.Text == "")
            {
                MessageBox.Show("Gabim!Nese deshiron te fshish shtyp butonin \'DELETE\' ");
            }
            else
            {
                con.Open();
                string query = "delete from Medicine_tbl where EmriBarnes ='" + Ebarnes.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barna u fshi!");
                con.Close();
                Mbushe();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
