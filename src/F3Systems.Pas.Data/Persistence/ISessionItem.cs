﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Persistence
{
    internal interface ISessionItem
    {
        void SubmitChanges();
    }
}
