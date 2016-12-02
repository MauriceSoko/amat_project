using System.Linq;
using amat_project.Data;

namespace amat_project.Models
{
    public static class AmatExtention
    {
        public static  void EnsureSeedData(this ApplicationDbContext context)
        {
            if (context.AllMigrationsApplied())
            {
                if (!context.Module.Any())
                {
                      context.Module.Add(
                          new Module{ ModuleId = "NFA0703", Name = "NFAO703", Description = "Administration poste Linux" }

                      );
                 context.SaveChanges();

                }
            }
        }
    }
}