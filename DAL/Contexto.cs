using System;
using Microsoft.EntityFrameworkCore;
using RegistroUsuariosyLogin.Entidades;

namespace RegistroUsuariosyLogin.DAL
{
    public class Contexto:DbContext
{
    public DbSet <Usuarios> Usuarios {get; set;}
    
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=Usuarios.db");
        }
                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Crismeyri",
                Apellidos = "Gutierrez Gil",
                FechaCreacion = new DateTime(2020, 11, 20),
                NombreUsuario = "admin",
                Contrasena = "1234"
            });

        }
    }
}