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
using System.Xml.Serialization;

namespace PharmacyMenagementSystem
{
    public partial class BillingForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\LocalDb;Integrated Security=True");
        
        public void MbusheCombobox()
        {
            string sql = "select * from Medicine_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmriBarnes", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                combobill.ValueMember = "EmriBarnes";
                combobill.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

         int x, Qmiminjesi;
         public void merrSasin()
         {
             con.Open();
             string mysql = "SELECT * FROM [Medicine_tbl] WHERE EmriBarnes = @EmriBarnes";
             SqlCommand cmd = new SqlCommand(mysql, con);
             cmd.Parameters.AddWithValue("@EmriBarnes", combobill.SelectedValue.ToString());

             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);

             foreach (DataRow dr in dt.Rows)
             {
                 x = Convert.ToInt32(dr["Sasia"].ToString());
                 Qmiminjesi = Convert.ToInt32(dr["qmimishitjes"].ToString());
                 stokDisp.Text ="Stoku i disponueshem: "+ dr["Sasia"].ToString();
                 stokDisp.Visible = true;
             }

             con.Close();

         }
        public void updateMedicine()
        {
            try
            {
                con.Open();

                int newsasia = x - Convert.ToInt32(sasia.Text);

           
                string Myquery = "UPDATE [Medicine_tbl] SET Sasia=@Sasia WHERE EmriBarnes=@EmriBarnes";

                SqlCommand cmd = new SqlCommand(Myquery, con);

                cmd.Parameters.AddWithValue("@Sasia", newsasia);
                cmd.Parameters.AddWithValue("@EmriBarnes", combobill.SelectedValue.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Stoku i barnave u perditesua me sukses.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            
        }
         public BillingForm()
         {
             InitializeComponent();
         }

         private void BillingForm_Load(object sender, EventArgs e)
         {
             MbusheCombobox();
         }

         private void combobill_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void combobill_SelectionChangeCommitted(object sender, EventArgs e)
         {
             merrSasin();
         }
         int grdtotal = 0;
        //Bitmap bitmap;
        private void printbutton_Click(object sender, EventArgs e)
        {
           /* Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           */
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bitmap, 0, 0);
        }
        
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void billbackbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void sasia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbill_Click(object sender, EventArgs e)
        {
            int n = 0; 
            if (sasia.Text == "" || Convert.ToInt32(sasia.Text) > x)
            {
                MessageBox.Show("Nuk ka mjaftueshem stok!Ju lutem kontrolloni stokun e disponueshem.");
            }
            else
            {
              int total = Convert.ToInt32(sasia.Text) * Qmiminjesi;
               DataGridViewRow newRow = new DataGridViewRow();
               newRow.CreateCells(BilldataGridView);
               newRow.Cells[0].Value = n + 1;
               newRow.Cells[1].Value = combobill.SelectedValue.ToString();
               newRow.Cells[2].Value = sasia.Text;
               newRow.Cells[3].Value = Qmiminjesi;
               newRow.Cells[4].Value = Qmiminjesi * Convert.ToInt32(sasia.Text);
               BilldataGridView.Rows.Add(newRow);
               grdtotal = grdtotal + total;
               totalishumes.Text = grdtotal + "$";
                updateMedicine();
            }
        }
    }
}
