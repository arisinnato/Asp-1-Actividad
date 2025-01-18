using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Repositorio;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositorio
{
    public class BaseRepositorio<TEntity> : BaseRepositorio<TEntity> where TEntity : class
 {
    internal AppDbContext Context;
    internal DbSet<TEntity> dbSet;
    public BaseRepositorio(AppDbContext context)
    {
        this.Context = context;
        this.dbSet = context.Set<TEntity>();
    }
    }
}