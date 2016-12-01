using System.Collections.Generic;

namespace amat_project.Models
{
    public class Module
    {
        public string ModuleId {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}

        public List<FormationModule> FormationModules {get; set;}

        public List<ModuleEnseignant> ModuleEnseignants {get; set;}
    }
}