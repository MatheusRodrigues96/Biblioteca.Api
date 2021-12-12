using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Models;

namespace Biblioteca.Api.Data
{
    public class BibliotecaApiContext : DbContext
    {
        public BibliotecaApiContext (DbContextOptions<BibliotecaApiContext> options)
            : base(options)
        {
        }

        public DbSet<Biblioteca.Api.Models.Produto> Produto { get; set; }
    }
}
