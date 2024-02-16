using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasico_ReservaJuego.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;

namespace MVCBasico_ReservaJuego.Context
{
    public class ReservaDatabaseContext : DbContext
    {
        public ReservaDatabaseContext(DbContextOptions<ReservaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Juego> Juegos { get; set; }
       
       

    }
}
   
