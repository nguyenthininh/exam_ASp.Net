﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public interface IStoreRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
