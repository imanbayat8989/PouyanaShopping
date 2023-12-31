﻿using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IUnitOWork
    {
        DbContext Context { get; }
        Task<int> Save(CancellationToken cancellationToken);
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
    }
}
