﻿using Microsoft.EntityFrameworkCore;

namespace info_hub.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Noticia> Noticias { get; set; }
<<<<<<< HEAD

        public DbSet<Tema> Politica { get; set; }

        public DbSet<Tema> Mundo { get; set; }


        public DbSet<Tema> Economia { get; set; }


        public DbSet<Tema> Tecnologia { get; set; }


        public DbSet<Tema> Negócios { get; set; }


        public DbSet<Tema> Viagens { get; set; }

        public DbSet<Tema> Clima { get; set; }

        public DbSet<Tema> Moda { get; set; }


        public DbSet<Tema> Comida { get; set; }

        public DbSet<Tema> Esporte { get; set; }
        public object Temas { get; internal set; }
=======
        
        public DbSet<Fonte> Fontes { get; set; }
>>>>>>> 7030967da6cb5b4053d4f82e235a74d787f5cbb4
    }
}
