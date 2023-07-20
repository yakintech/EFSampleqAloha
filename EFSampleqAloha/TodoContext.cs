using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFSampleqAloha.Models;

namespace EFSampleqAloha
{
    public class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=ToDoDb; trusted_connection=true");
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Client> Clients { get; set; }

    }
}
