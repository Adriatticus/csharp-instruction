﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace net_bmdb_web_demo.Models;

public partial class BmdbContext : DbContext
{
    public BmdbContext()
    {
    }

    public BmdbContext(DbContextOptions<BmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }
}
