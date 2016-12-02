using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace amat_project.Models
{
    public class Etudiant
    {
        public string EtudiantId {get; set;}

        public string ApplicationUserID {get; set;}

        [ForeignKey("ApplicationUserID")]
        public ApplicationUser ApplicationUser {get; set;}

        public List<Evaluation> Evaluations {get; set;}
    }
}