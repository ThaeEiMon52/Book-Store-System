using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace netAssignment
{
    class Book
    {
        private string bid;
      
        private string title;
        private string author;
        private string publisher;
        private string copy;
        private string editionNo;
        private int nameofpage;
        private int isbm;
        private int numbercopy;
        private string language;
        private string type;
        private string category;
       
       

        public Book(string bid, string titel, string author, string publisher, string copy, string editionNo, int nameofpage, int isbm, int numbercopy,string language,string type,string category)
        {
            Bid = bid;
          
            Title = titel;
            Author = author;
            Publisher = publisher;
            Copy = copy;
            EditionNo = editionNo;
            Nameofpage = nameofpage;
            Isbm = isbm;
            Numbercopy = numbercopy;
            Language=language;
            Type = type;
            Category = category;

        }

      
        public String Bid
        {
            get
            {
                return bid;
            }
            set
            {
                bid = value;
            }
        }


      

        public String Author
        {
            get
            {
                return author;
            }
            set
            {

                Regex a = new Regex(@"^[a-zA-Z]+$");
                bool ans = a.IsMatch(value);
                if (ans)
                {
                    author = value;
                }
                else
                {
                    throw new AuthorException("Invalid Authorname");
                }
            }
        }
          
        public String Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                Regex a = new Regex(@"^[a-zA-Z]+$");
                bool ans = a.IsMatch(value);
                if(ans)
                {
                    publisher = value;
                }
                else
                {
                    throw new publisherException("Invalid publisher");
                }
            }
        }

        public String Copy
        {
            get
            {
                return copy;
            }
            set
            {
                Regex a = new Regex(@"^\w.*@ All right reserved$");
                bool ans = a.IsMatch(value);
                if (ans)
                {
                    copy = value;
                }
                else
                {
                    throw new copyrightException("Invalid Copyright");
                }
            }
        }

        public string  EditionNo {
            get{
                return editionNo;
            }
              set{
                  Regex a = new Regex(@"^\d.*\w{2}$");
                  bool ans = a.IsMatch(value);
                  if(ans)
                  {

                      editionNo = value;
                  }

                  else
                  {
                      throw new editionNoException("Invalid Edition Number");
                  }
              }
                   }

        public int Nameofpage {

            get { return nameofpage; }

            set { nameofpage=value;} 
        
        }

        public int Isbm {

            get { return isbm;}
            set {isbm=value ;} 
       
        }

        public int Numbercopy
        {

            get { return numbercopy; }
            set { numbercopy = value; }
        }

       

        public string Language { get; set; }
        public  string Title { get; set; }


        public string Type
        {

            get { return type; }
            set { type = value; }
        }
        public string Category
        {

            get { return category; }
            set { category = value; }
        }




     
    }
}
