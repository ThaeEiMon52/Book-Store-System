using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace netAssignment        ///
{
    class dataAccess
    {
        public bool save(Book b) 
        {
            bool ans = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert bookdata values('" + b.Bid + "','" + b.Title + "','" + b.Author + "','" + b.Publisher + "','" + b.Copy + "'," + b.EditionNo + "," + b.Nameofpage + "," + b.Isbm + "," + b.Numbercopy + ",'" + b.Language + "','" + b.Type + "','" + b.Category + "')";


            cmd.Connection = con;

            con.Open();     
            cmd.ExecuteNonQuery();
            con.Close();

            ans = true;
            return ans;
        }

      //*  public bool update(Book b)
      //   {
      //      bool ans = false;
      //      SqlConnection con = new SqlConnection();
      //      con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";


      //      SqlCommand cmd = new SqlCommand();
      //      cmd.CommandText = "UPDATE bookdata SET Thenumberofthecopy ('" + b.Bid + "','" + b.Subject + "','" + b.Title + "','" + b.Author + "','" + b.Publisher + "','" + b.Copy + "'," + b.EditionNo + "," + b.Nameofpage + "," + b.Isbm + "," + b.Numbercopy + ",'" + b.Language + "')";


      //      cmd.Connection = con;

      //      con.Open();     
      //      cmd.ExecuteNonQuery();
      //      con.Close();

      //      ans = true;
      //      return ans;
      //  }
    //


        public bool save(student s)
        {
            bool ans = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert INTO MemberCard values(" + s.Id + ",'" + s.Name + "','" + s.Nrc + "','" + s.Batchno + "','" + s.Email + "','" + s.Status + "','" + s.Phone + "','" + s.Address + "','" + s.Usertype + "')";


            cmd.Connection = con;  
            cmd.ExecuteNonQuery();
            con.Close();

            ans = true;
            return ans;
        }

        public DataTable RetrieveAllDataFromTable()
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";



            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "select * from bookdata";

            DataSet ds = new DataSet();
            sda.Fill(ds, "bookdata");

            DataTable dt = ds.Tables["bookdata"];
            return dt;
        }

     public bool Date(int cid,string title,string status, string usertype, string language, string type,int cost, string start, string redate)
     {
         bool a=false;
          SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";

          SqlCommand cmd = new SqlCommand();
          cmd.CommandText = "insert Rentbook values(" + cid + ",'" + title + "','" + status + "','" + usertype + "','" + language + "','" + type + "','" + cost + "','" + start + "','" + redate + "')";


            cmd.Connection = con; 
         //   cmd.ExecuteNonQuery();
            con.Close();

            a = true;
            return a;


     }

        public DataTable Searchbyauthorn(string a)
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            
            sda.SelectCommand.CommandText = "select * from bookdata where NameoftheAuthor='" + a + "'";

            DataSet ds = new DataSet();
            sda.Fill(ds, "bookdata");

            DataTable dt = ds.Tables["bookdata"];
            return dt;

        }


        public DataTable Searchbyisbm(string isbm)
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;

            sda.SelectCommand.CommandText = "select * from bookdata where ISBMforthebook='" + isbm + "'";

            DataSet ds = new DataSet();
            sda.Fill(ds, "bookdata");

            DataTable dt = ds.Tables["bookdata"];
            return dt;

        }
        public DataTable Searchbytitle(string tit)
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;

            sda.SelectCommand.CommandText = "select * from bookdata where BookTitle='" + tit + "'";

            DataSet ds = new DataSet();
            sda.Fill(ds, "bookdata");

            DataTable dt = ds.Tables["bookdata"];
            return dt;

        }
        public DataTable Searchbyd(string tit,string idd)
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;

            sda.SelectCommand.CommandText = "select * from bookdata where Category='"+tit+"' and BookID='"+ idd +"'";
           
            DataSet ds = new DataSet();
            sda.Fill(ds, "bookdata");

            DataTable dt = ds.Tables["bookdata"];
            return dt;

        }
        public DataTable Studentsearch(int ID)
        {
            //connection,commend ,select
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-D11TUQ1;Initial Catalog=DBassi;Integrated Security=true";


            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "select * from MemberCard  where ID=" + ID;
           

            DataSet ds = new DataSet();
            sda.Fill(ds, "MemberCard");

            DataTable dt = ds.Tables["MemberCard"];
            return dt;
        }

        public bool SaveReservation(int id, string name, string title, string phone, string email)
        { 


            bool ans = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SoeSandyWai-PC;Initial Catalog=C#Assignment;Integrated Security=true";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT Reservation VALUES('" + id + "','" + name + "','" + title + "','" + phone + "','" + email + "')";

            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();

            ans = true;
            return ans;
        }

      
        internal System.Data.DataTable form(System.Windows.Forms.Label name) 
        {
            throw new NotImplementedException();
        }

        internal DataTable from(string title)
        {
            throw new NotImplementedException();
        }


        internal string AddMonths(int p)
        {
            throw new NotImplementedException();
        }

        internal object Date(int cid, System.Windows.Forms.CheckBox book, string status, string usertype, string language, string type, int cost, string mydate, string redate)
        {
            throw new NotImplementedException();
        }
    }
}
