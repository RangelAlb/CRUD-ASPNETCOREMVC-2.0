﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
