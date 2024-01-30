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

namespace PharmacyMenagementSystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\LocalDb;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(); 
           /* if(Username.Text == "Admin" && Password.Text == "password")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwordi ose UserID jane dhene gabim!\nJu lutem provoni perseri.");
            }*/
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee_tbl where IDpunetorit='"+Username.Text+"' and Passwordipunetorit='"+Password.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwordi ose UserID jane dhene gabim!\nJu lutem provoni perseri.");
            }

            con.Close();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
