using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace netAssignment
{
    class reserve
    {
         private int id;
        private string name;
        private string btitle;
        private string phone;
        private string email;
        public reserve(int id,string name,string btitle,string phone,string email)
        {
            ID = id;
            Name = name;
            Btitle = btitle;
            Phone = phone;
            Email = email;
        }
        public int ID
        {
            get { return id; }
            set
            {
                value = id;
            }
        }
         public string Name
        {
            get { return name; }
            set { name=value; }
        }
        public string Btitle
        {
            get { return btitle; }
            set { btitle = value; }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                Regex r = new Regex(@"^09\d{9}$");
                Regex a = new Regex(@"^09\d{7}$");
                Regex i = new Regex(@"^01\d{6}$");
                bool rr = r.IsMatch(value);
                bool aa = a.IsMatch(value);
                bool ii = i.IsMatch(value);
                if (rr || aa | ii)
                {
                    phone = value;
                }
                else
                {
                    throw new PhoneException("Enter Valid PhoneNumber!");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                Regex r = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
                bool ans = r.IsMatch(value);
                if (ans)
                {
                    email = value;
                }
                else
                {
                    throw new emailException("Incorrect Email!Please enter email with correct format");
                }
            }
        }
    }
}
