namespace amat_project.Models
{
    public class Evaluation
    {
        public string EvaluationId {get; set;}

        public string SessionId {get; set;}
        public Session Session {get; set;}
        public string EtudiantId {get; set;}
        public Etudiant Etudiant {get; set;}

        public string EnseignantId {get; set;}
        public Enseignant Enseignant {get; set;}

        public string ModuleId {get; set;}
        public Module Module {get; set;}
        public int Note {get; set;}
    }
}