﻿using Entities.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Applicant : User
    {
        public string About { get; set; }
    }
}
