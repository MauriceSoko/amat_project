using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace amat_project.Models
{
    public class Enseignant
    {
       public string EnseignantId {get; set;} 
       public List<Module> Modules {get; set;}

        public string ApplicationUserID {get; set;}

        [ForeignKey("ApplicationUserID")]
        public ApplicationUser ApplicationUser {get; set;}

        public List<ModuleEnseignant> ModuleEnseignants {get; set;}
   
    }
}