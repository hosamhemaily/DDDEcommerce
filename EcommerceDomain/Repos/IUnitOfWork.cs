﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Repos
{
    public interface IUnitOfWork
    {
        int Save();
    }
}
