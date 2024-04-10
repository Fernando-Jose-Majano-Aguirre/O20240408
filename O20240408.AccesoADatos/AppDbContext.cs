﻿using Microsoft.EntityFrameworkCore;
using O20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O20240408.AccesoADatos
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<PersonaO> Personas { get; set; }
    }
}
