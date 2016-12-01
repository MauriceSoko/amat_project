using System.Collections.Generic;
using System;

namespace amat_project.Models
{
    public class Session
    {
        public string SessionId {get; set;}
        public DateTime DebutSession{get; set;}
        public DateTime FinSession{ get; set;}
        public string FormationId {get; set;}

        public Formation Formation {get; set;}

        public List<Etudiant> Etudiants {get; set;}

        public List<Enseignant> Enseignants {get; set;}
        
    }
}