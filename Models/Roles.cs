using System.Collections.Generic;

namespace amat_project.Models
{
    public static class Roles
    {
        public static readonly string[] roles = { "Admin", "Etudiant", "Enseignant"};

        public static string Admin { get{return roles[0];}}

        public static string Etudiant { get {return roles[1];}}

        public static string Enseignant { get { return roles[2];}}

        public static IEnumerable<string> All {get {return roles;}}
        
    }
}