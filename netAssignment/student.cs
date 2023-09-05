using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace netAssignment
{
    class student
    {
        private string name;
        private int id;
        private string nrc;
        private string email;
        private string status;
        private string phone;
        private string address;
        private string usertype;
        private string batchNo;
        private System.Windows.Forms.Label language1;

        public student(int id, string name, string nrc, string batchNo, string email, string status, string phone, string address, string usertype)
        {
           Name = name;
            Id = id;
            Nrc = nrc;
            Batchno = batchNo;
            Email = email;
            Status = status;
            Phone = phone;
            Address = address;
            Usertype = usertype;
        }

      
        public string Name {
            get {return name ;}
            set { name=value;} 
        }

        public int Id {
            get { return id;}

            set {id=value ;}
        }

        public string Nrc {
            get { 
                return nrc;
            }
            set {
                if (value.Length==14 || value.Length==15)
                {
                nrc=value;
            }
                else
                {
                    throw new NRCException("Enter valid NRC only");
                }
            } 
        }

        public string Batchno {
            get {
                return batchNo ;
            }
            set {
                batchNo =value ;
            }
        }

        public string Email {
            get {
                return email;
            }
            set {
                Regex r = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
              bool ans = r.IsMatch(value);
                if (ans)
                {
                    email = value;
               }
                else
                {
                  throw new emailException("your format must be .......@gmail.com");
              }    
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string Phone { 
            get{
                return phone;
            }
            set {

                Regex a = new Regex(@"^09\d{9}$");
                Regex b = new Regex(@"^09\d{7}$");
                Regex c = new Regex(@"^09\d{6}$");

                bool aa = a.IsMatch(value);
                bool bb = a.IsMatch(value);
                bool cc = a.IsMatch(value);

                if (aa || bb || cc)
                {
                    phone = value;
                }
                else
                {
                    throw new PhoneException("Enter Valid PhoneNumber Only");
                }
            }
        }

        public string Address {
            get {
                return address ;
            }
            set {
                address = value;
            }
        }

        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }

       

       
    }
}
