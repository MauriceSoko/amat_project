using System.Collections.Generic;
using System.Linq;
using amat_project.Data;

namespace amat_project.Models
{
    public static class AmatExtention
    {
        public static void EnsureSeedData(this ApplicationDbContext context)
        {
            if (context.AllMigrationsApplied())
            {
                if (!context.Module.Any())
                {

                    context.Module.AddRange(
                        // module that compose Admin formation
                        new Module { ModuleId = "NFA0703", Name = "NFAO703", Description = "Administration poste Linux" },
                        new Module { ModuleId = "NFA074", Name = "NFA074", Description = "Réseaux et Télécommunication" },
                        new Module { ModuleId = "NSY104", Name = "NFY104", Description = "Architecture des Systèmes Informatique" },
                        new Module { ModuleId = "RSX112", Name = "RSX112", Description = "Sécurité  et Réseaux" },

                        //this module will be in Admin formation and Developer formation
                        new Module { ModuleId = "NFP107", Name = "NFP107", Description = "Système de Gestion de Base de Données" },

                       // module that compose compose Developer formation
                       new Module { ModuleId = "NFA031", Name = "NFA031", Description = "Programmation avec C#" },
                       new Module { ModuleId = "RCP105", Name = "RCP105", Description = "Modelisation et Algorithme" },
                       new Module { ModuleId = "GLG105", Name = "GLG105", Description = "Génie Logiciel" },
                       new Module { ModuleId = "NFE114", Name = "NFE114", Description = "Système Information Web" },

                       // module that compose Technicien Support Informatique
                       new Module { ModuleId = "NY115", Name = "NY115", Description = "Assurer le support sur les Réseaux" },
                       new Module { ModuleId = "SMB117", Name = "SMB117", Description = "Assurer le support sur les Systeme Informatique" },
                       new Module { ModuleId = "SMB104", Name = "SMB104", Description = "Assurer le support sur Serveur d'Appilcation" }

                    );
                    context.SaveChanges();

                }

                if (!context.Formation.Any())
                {

                    context.Formation.AddRange(
                        new Formation { FormationId = "Admin", Name = "Admin", Description = "Roi des serveur" },
                        new Formation { FormationId = "Developpeur", Name = "Developpeur", Description = "Génie des claviers" },
                        new Formation { FormationId = "Technicien", Name = "Technicien Support", Description = "Agence Tous Risque" }
                    );
                    context.SaveChanges();

                }

                if (!context.FormationModule.Any())
                {
                    var adminLinux = context.FormationModule.Add(new FormationModule { ModuleId = "NFA0703", FormationId = "Admin" });
                    var adminResaux = context.FormationModule.Add(new FormationModule { ModuleId = "NFA074", FormationId = "Admin" });
                    var adminSecurite = context.FormationModule.Add(new FormationModule { ModuleId = "NSY104", FormationId = "Admin" });
                    var adminSys = context.FormationModule.Add(new FormationModule { ModuleId = "RSX112", FormationId = "Admin" });
                    Formation adminFormation = context.Formation.First(p => p.FormationId == "Admin");
                    adminFormation.FormationModules.Add(adminLinux.Entity);
                    adminFormation.FormationModules.Add(adminSys.Entity);
                    adminFormation.FormationModules.Add(adminSecurite.Entity);
                    adminFormation.FormationModules.Add(adminResaux.Entity);

                    context.SaveChanges();



                }
            }
        }
    }
}

