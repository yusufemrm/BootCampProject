﻿using Entities.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor : User
    {
        public string CompanyName { get; set; }
    }
}
