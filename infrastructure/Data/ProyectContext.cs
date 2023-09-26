using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class ProyectContext : DbContext
    {
        public ProyectContext(DbContextOptions<ProyectContext> options) : base(options)
        {
        }
    }
