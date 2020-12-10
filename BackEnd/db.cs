using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace BackEnd
{
    public class db : DbContext
    { 
        public db(DbContextOptions<db> options): base(options)
        {

        }
        public DbSet<TargetaCredito> TargetaCredito { get; set; }
    }
}