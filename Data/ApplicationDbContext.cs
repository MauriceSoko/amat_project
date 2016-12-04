using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using amat_project.Models;

namespace amat_project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            
            // make Formation and Session a many To many relationship
          builder.Entity<FormationModule>()
            .HasKey(t => new {t.ModuleId, t.FormationId});

         builder.Entity<FormationModule>()
            .HasOne(fm => fm.Module)
            .WithMany(f => f.FormationModules)
            .HasForeignKey(fm => fm.ModuleId); 


         builder.Entity<FormationModule>()
            .HasOne(pm => pm.Formation)
            .WithMany(p => p.FormationModules)
            .HasForeignKey(pm => pm.FormationId); 

            //make Enseignant and Module a many To many relationship
            builder.Entity<ModuleEnseignant>()
                .HasKey(t => new {t.EnseignantId, t.ModuleId});
             
            builder.Entity<ModuleEnseignant>()
                .HasOne(fm => fm.Enseignant)
                .WithMany(f => f.ModuleEnseignants)
                .HasForeignKey(fm => fm.EnseignantId);


            builder.Entity<ModuleEnseignant>()
                .HasOne(pm => pm.Module)
                .WithMany(p => p.ModuleEnseignants)
                .HasForeignKey(pm => pm.ModuleId);
        }

        public DbSet<Formation> Formation {get; set;}

        public DbSet<FormationModule> FormationModule {get; set;}
        public DbSet<Module> Module { get; set;}
        public DbSet<Session> Session {get; set;}

        public DbSet<Etudiant> Etudiant {get; set;}
        public DbSet<Enseignant> Enseignant {get; set;}

        public DbSet<Evaluation> Evaluation {get; set;}
    }
}
