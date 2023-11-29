﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
