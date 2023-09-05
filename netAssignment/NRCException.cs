using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netAssignment
{
    class NRCException:ApplicationException
    {
          public NRCException(string message):base(message)
         {

        }
    }
}
