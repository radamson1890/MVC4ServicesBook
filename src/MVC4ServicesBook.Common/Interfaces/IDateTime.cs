﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC4ServicesBook.Common.Interfaces
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
    
}
