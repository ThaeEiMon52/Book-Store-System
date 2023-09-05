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

namespace netAssignment
{
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string reservebook = textBox3.Text;
                string phone = textBox5.Text;
                string email = textBox4.Text;
                string name=textBox2.Text;
                int reserveid = int.Parse(textBox1.Text);

                reserve p = new reserve (reserveid, name, reservebook, phone, email);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from RentalCard where ID=@cid";
                cmd.Parameters.AddWithValue("@cid", reserveid);
                cmd.Connection = con;

                  try
                {
                int result = (int)cmd.ExecuteScalar();
                if (result == reserveid)
                {
                    string book = "";
                    SqlConnection connx = new SqlConnection();
                    connx.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                    connx.Open();
                    SqlCommand cmd2x = new SqlCommand();
                    cmd2x.CommandText = "select * from BookList where Title=@title";
                    cmd2x.Parameters.AddWithValue("@title", reservebook);
                    cmd2x.Connection = connx;
                    book = (string)cmd2x.ExecuteScalar();
                    connx.Close();

                     if (book == reservebook)
                    {
                        dataAccess db = new dataAccess();
                        bool w = db.SaveReservation(reserveid, name, reservebook, phone, email);
                        if (w)
                        {
                            MessageBox.Show("Reservation Complete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reservation Incomplete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no book with the name" + reservebook, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
               }

                catch(NullReferenceException n)
                {
                    MessageBox.Show("Invalid ID! You need to register first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
             catch (emailException a)
             {
                 MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (PhoneException a)
             {
                 MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (FormatException a)
             {
                 MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}
