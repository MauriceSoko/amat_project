namespace amat_project.Models
{
    public class ModuleEnseignant
    {
        public string ModuleId {get; set;}
        public Module Module {get; set;}

        public string EnseignantId {get; set;}
        public Enseignant Enseignant {get; set;}
    }
}