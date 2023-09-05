using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netAssignment
{
    class emailException:ApplicationException
    { 
         public emailException(string message):base(message)
         {

        }
    
    }
}
