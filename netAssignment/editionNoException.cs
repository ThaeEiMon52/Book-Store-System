﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netAssignment
{
    class editionNoException:ApplicationException
    {
         public editionNoException(string message):base(message)
         {

        }
    }
}
