﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Add(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
