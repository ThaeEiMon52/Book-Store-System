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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void displaylist_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                string bID = bidtxt.Text;

                string title = btitletxt.Text;
                string author = nauthortxt.Text;
                string publisher = npublishtxt.Text;
                string copy = cbooktxt.Text;
                string editionNo = enumbertxt.Text;
                string category = cate.Text;
                int nameofpage = int.Parse(npagetxt.Text);
                int isbm = int.Parse(isbmtxt.Text);
                int Numbercopy = int.Parse(ncopytxt.Text);



                string language = "";
                if (eng.Checked)
                {
                    language = eng.Text;
                }
                else
                {
                    language = myan.Text;
                }


                string type = "";
                if (cd.Checked)
                {
                    type = cd.Text;
                }
                else
                {
                    type = book.Text;
                }
               // MessageBox.Show(copy);

                Book bo = new Book(bID, title, author, publisher, copy, editionNo, nameofpage, isbm, Numbercopy, language, type,category);
                dataAccess da = new dataAccess();
                bool ans = da.save(bo);
                if (ans)
                {

                    MessageBox.Show("Saving sucessful", "answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saving fail", "answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //catch
            //{
            //    MessageBox.Show("Data Missing");
            //}
        //}
   

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bdsave_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bcancle_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.DialogResult = DialogResult.OK;
        }

        private void Sbcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = namtxt.Text;
                int id = int.Parse(idtxt.Text);
                string nrc = nrctxt.Text;
                string batchNo = batchtxt.Text;
                string email = emailtxt.Text;

                string status = sta.Text;

                if (status.Equals("Faculty Member"))
                {
                    MessageBox.Show("No of book:5, Myanmar Book : 2week and English Book : 4weeks", "Maximum loan period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (status.Equals("PhD candidates"))
                {
                    MessageBox.Show("No of book:5, Myanmar Book : 2week and English Book : 4weeks", "Maximum loan period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (status.Equals("Studnets"))
                {
                    MessageBox.Show("No of book:5, Myanmar Book : 2week and English Book : 4weeks", "Maximum loan period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No of book:3,Myanmar Book : One Month and English Book : One Month", "Maximum loan period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                string ut = mt.Text;
                if (memt.SelectedItem.Equals("Simple User"))
                {
                    ut = "Simple User";
                }
                else if (memt.SelectedItem.Equals("Member"))
                {
                    ut = "Member";
                }


                string phone = phonetxt.Text;
                string address = addresstxt.Text;
               

                

                student s = new student(id, name, nrc, batchNo, email,status, phone, address,ut);

                dataAccess da = new dataAccess();
                bool ans = da.save(s);

                if (ans)
                {
                    MessageBox.Show("Sucessful............", "answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fail....", "answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (emailException obj)
            {
                MessageBox.Show(obj.Message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Scancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sdcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsearch_Click(object sender, EventArgs e)
        {

            dataAccess db = new dataAccess();
            string tool = si.Text;
            if (tool == "ISBM")
            {

                string isbm = textBox1.Text;

                DataTable dt = db.Searchbyisbm(isbm);
                dgv.DataSource = dt;
            }
            else if (tool=="Author name")
            {

                string author = textBox1.Text;
                DataTable dt = db.Searchbyauthorn(author);
                dgv.DataSource = dt;

            }
            else if (tool=="Title")
            {

                string isbn = textBox1.Text;
                DataTable dt = db.Searchbytitle(title);
                dgv.DataSource = dt;

            }
        }
            
            

          
        

        private void bdisplay_Click(object sender, EventArgs e)
        {

        }

        private void fcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        string categories = cbox.Text;
        //        int qty = int.Parse(qtytxt.Text);

        //        int price = 0;
        //        if (categories.Equals("Magazine"))
        //        ,Journals, Business,History,Travel,Health,Romance,Science fiction, Sports-General"))
        //        {
        //            price = qty * 1000;
        //        }
        //        else
        //        {
        //            price = qty * 500;
        //        }
        //        String ans = "Book fees.." + categories + "....price..." + price;
        //        "Book Fee......." + categories + "price" + qty;
        //        MessageBox.Show(ans, "ans", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Data Missing");
        //    }


        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int studentdata = int.Parse(sidtxt.Text);
                dataAccess da = new dataAccess();
                DataTable dt = da.Studentsearch(studentdata);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Data Missing");
            }
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
           
            


        }

        private void searchsd_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }




        public string FacultyMember { get; set; }

        private void button2_Click_2(object sender, EventArgs e)
        {

            try
            {
                //member id checking
                int cid = int.Parse(cardid.Text);
                dataAccess ds = new dataAccess();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(*) from MemberCard where ID='" + cid + "'";
                // cmd.Parameters.AddWithValue("@id", cid);
                cmd.Connection = con;
                int result = (int)cmd.ExecuteScalar();
                // if(result==cid)

                if (result > 0)
                {
                    //book id checking 
                    string btitle = booktitle.Text;
                    SqlConnection conk = new SqlConnection();
                    conk.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                    conk.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "select count(*) from bookdata where BookTitle=@bt";
                    cmd2.Parameters.AddWithValue("@bt", btitle);
                    cmd2.Connection = conk;
                    int book = (int)cmd2.ExecuteScalar();
                    conk.Close();

                    // string sta = "";

                    if (book > 0 )
                    {
                        //Myanmar current book normal user
                        string booklanguage = "";
                        if (myanma.Checked)
                        {
                            booklanguage = myanma.Text;

                            if (curent.Checked)
                            {
                                if (norm.Checked)
                                {
                                    int price = 1000;
                                    MessageBox.Show("Book price" + price);
                                }
                                else{
                                    int price = 700;
                                    MessageBox.Show("Book Price"+price);
                                }
                            }
                            else
                            {
                                if (cdd.Checked)
                                {
                                    if (norm.Checked)
                                    {
                                        int price = 500;
                                        MessageBox.Show("Book price " + price);
                                    }
                                    else
                                    {
                                        int price = 350;
                                        MessageBox.Show("Book Price " + price);
                                    }
                                }
                            }
                        }
                        //English books
                        if (engli.Checked)
                        {
                            booklanguage = engli.Text;

                            if (curent.Checked)
                            {
                                if (norm.Checked)
                                {
                                    int price = 1000;
                                    MessageBox.Show("Book price" + price);
                                }
                                else
                                {
                                    int price = 700;
                                    MessageBox.Show("Book Price" + price);
                                }
                            }
                            else
                            {
                                if (cdd.Checked)
                                {
                                    if (norm.Checked)
                                    {
                                        int price = 500;
                                        MessageBox.Show("Book price" + price);
                                    }
                                    else
                                    {
                                        int price = 350;
                                        MessageBox.Show("Book Price" + price);
                                    }
                                }
                            }
                        }
                        
                        SqlConnection connect = new SqlConnection();
                        connect.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                        connect.Open();
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.CommandText = "select Thenumberofthecopy from bookdata where BookTitle='"+btitle+"'";
                       // cmd3.Parameters.AddWithValue("@status", btitle);
                        cmd3.Connection = connect;
                        int result2 = (int)cmd3.ExecuteScalar(); //2
                        connect.Close();
                        result2 = result2 - 1;

                        

                        string status = "";
                        if (sta.Equals("Simple user"))
                        {
                            status = "Simple User";
                        }
                        else if (status.Equals("Member"))
                        {
                            status = "Member";
                        }

                       
                        SqlConnection connec = new SqlConnection();
                        connec.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                        connec.Open();
                        SqlCommand cmd0 = new SqlCommand();
                        cmd0.CommandText = "select type from bookdata where BookTitle=@title";
                        cmd0.Parameters.AddWithValue("@title", btitle);
                        cmd0.Connection = connec;
                        string type = (string)cmd0.ExecuteScalar();
                        connect.Close();

                        if (status == "Simple user" && type == "CD")
                        {
                            MessageBox.Show("You are not a member and thus you can't rent a CD");
                        }
                        else
                        {
                            if (result2 > 0)
                            {
                                result2 = result2 - 1;
                               
                                SqlConnection conne = new SqlConnection();
                                conne.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                conne.Open();
                                SqlCommand cmd5 = new SqlCommand();
                                cmd5.CommandText = "update bookdata SET Thenumberofthecopy=@a where BookTitle=@title";
                                cmd5.Parameters.AddWithValue("@a", result2);
                                cmd5.Parameters.AddWithValue("@title", btitle);

                                cmd5.Connection = conne;
                               // cmd5.ExecuteNonQuery();
                                conne.Close();
                                string lang = "";
                                string language = "";


                                SqlConnection connt = new SqlConnection();
                                connt.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";

                                SqlCommand cmd6 = new SqlCommand();
                                cmd6.CommandText = "select language from bookdata where BookTitle=@title";
                                cmd6.Parameters.AddWithValue("@title", btitle);
                                cmd6.Connection = connt;
                                connt.Open();
                                lang = (string)cmd6.ExecuteScalar();
                                connt.Close();

                                if (lang == "English")
                                {
                                    language = "English";
                                }

                                else if (lang == "Myanmar")
                                {
                                    language = "Myanmar";
                                }

                                string usertype = "";
                                //SqlConnection connectt = new SqlConnection();
                                //connectt.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                //connectt.Open();
                                //SqlCommand cmd7 = new SqlCommand();
                                //cmd7.CommandText = "select UserType from MemberCard where ID=@idd";
                                //cmd7.Parameters.AddWithValue("@idd", cid);
                                //cmd7.Connection = connectt;
                                //usertype = (string)cmd7.ExecuteScalar();
                                //connectt.Close();

                                string com = comboBox1.Text;
                                if (com=="Faculty Member")
                                {
                                    usertype = "Faculty Member";
                                }
                                else if (com == "Phd candidates")
                                {
                                    usertype = "Phd Candidates";
                                }

                                else if (com == "Student")
                                {
                                    usertype = "Student";
                                }

                                if (com=="Office Staff")
                                {
                                    usertype = "office Staff";
                                }

                                DateTime dt = DateTime.Today;
                                String mydate = dt.Month + "." + dt.Day + "." + dt.Year;
                                dataAccess da = new dataAccess();
                                string redate = "";

                                if (language == "English" && usertype == "Office Staff" || language == "Myanmar" && usertype == "office staff")
                                {
                                    redate = da.AddMonths(1);
                                }
                                else if (language == "English")
                                {
                                    redate = dt.AddDays(28).ToString();
                                }
                                else if (language == "Myanmar")
                                {
                                    redate = dt.AddDays(14).ToString();
                                }
                                bool ba = true;
                                int rentcount;
                                SqlConnection conno = new SqlConnection();
                                conno.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                conno.Open();
                                SqlCommand cmd8 = new SqlCommand();
                                cmd8.CommandText = "select count(cid) from Rent where cid=@idd";
                                cmd8.Parameters.AddWithValue("@idd", cid);
                                cmd8.Connection = conno;

                                rentcount = (int)cmd8.ExecuteScalar();
                                conno.Close();
                                bool b = false;
                                int cost = 0;
                                if (status == "Member" && type == "Book")
                                {
                                    cost = 1000 - 300;
                                }
                                else if (status == "Member" && type == "CD")
                                {
                                    cost = 500 - 150;
                                }
                                else
                                {
                                    if (type == "Book")
                                    {
                                        cost = 1000;

                                    }
                                    else if (type == "CD")
                                    {
                                        cost = 500;
                                    }
                                }
                                if (usertype == "Office staff")
                                {
                                    if (rentcount > 2)
                                    {
                                        int copy = result2 + 1;
                                        SqlConnection conont = new SqlConnection();
                                        conont.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                        conont.Open();
                                        SqlCommand cmd9 = new SqlCommand();
                                        cmd9.CommandText = "UPDATE bookdata Set Thenumberofthecopy=@copy where Title=@title";
                                        cmd9.Parameters.AddWithValue("@copy", copy);
                                        cmd9.Parameters.AddWithValue("@title", btitle);

                                        cmd9.Connection = conont;
                                        cmd9.ExecuteNonQuery();
                                         
                                        conont.Close();
                                        MessageBox.Show("you can't rent book since office staff can just borrow");

                                    }
                                    else
                                    {
                                        b = da.Date(cid, title, status, usertype, language, type, cost, mydate, redate);
                                    }
                                }
                                else
                                {
                                    if (rentcount > 4)
                                    {
                                        int acopy = result2 + 1;

                                        SqlConnection conneo = new SqlConnection();
                                        conneo.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                        conneo.Open();
                                        SqlCommand cmd10 = new SqlCommand();
                                        cmd10.CommandText = "UPDATE bookdata Set  Thenumberofthecopy=@copy where Title=@title";
                                        cmd10.Parameters.AddWithValue("@copy", acopy);
                                        cmd10.Parameters.AddWithValue("@title", btitle);

                                        cmd10.Connection = conneo;
                                        cmd10.ExecuteNonQuery();

                                        conneo.Close();

                                        MessageBox.Show("you can obtain greatest 5 book so you can't rent anymore ");
                                        //		int cid,string title,string status, string usertype,
                                        //--	string language, string type,int cost, string start, string redate)

                                    }
                                    else
                                    {
                                         ba = da.Date(cid, title, status, usertype, language, type, cost, mydate, redate);
                                    }
                                }
                                if (ba)
                                {
                                    MessageBox.Show("Renting Complete" + Environment.NewLine + "Your return date is" + redate);
                                }
                                else
                                {
                                    MessageBox.Show("Rent incomplete");
                                }
                            }
                            else if (result2 == 0)
                            {
                                string re = "";
                                SqlConnection conni = new SqlConnection();
                                conni.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
                                conni.Open();
                                SqlCommand cmd11 = new SqlCommand();
                                cmd11.CommandText = "select redate from Rent where Title=@t";
                                cmd11.Parameters.AddWithValue("@t", btitle);

                                cmd11.Connection = conni;
                                re = (string)cmd11.ExecuteScalar().ToString();

                                conni.Close();

                                DialogResult dia = MessageBox.Show("The book is rented .It will return" + "" + re + Environment.NewLine + "You want to make a reservation for this book? ", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (dia == DialogResult.Yes)
                                {
                                    reservation R = new reservation();
                                    R.Show();
                                }
                            }

                        }
                    

                    }

                    else
                    {
                        MessageBox.Show("Inavailable Book");
                    }
                   conk.Close();
                }
                else
               {
                   MessageBox.Show("You need to register first!");
                }
                con.Close();

            }
            catch (FormatException T)
            {
                MessageBox.Show(T.Message);
            }
       }
     
       





        

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void rent_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rstatxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ridtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

         }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mem_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void au_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void titletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void si_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string title { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sbook_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
             dataAccess db = new dataAccess();
             string sos = so.Text;  //category
             string iddd = so1.Text;
             DataTable dt = db.Searchbyd(sos, iddd);
             so3.DataSource = dt;
            //if (sos == "ID")
            //{
            //    DataTable dt = db.Searchbyd(so.Text);
            //    so3.DataSource = dt;
            //}
            //else if (so.Text=="Category")
            //{

            //    string cate = so1.Text;
            //    MessageBox.Show("Book not Fond");
            //    DataTable dt = db.Searchbycate(cate);
            //    dgv.DataSource = dt;

            //}
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        

       
    }
}
