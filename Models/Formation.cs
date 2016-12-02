using System.Collections.Generic;
namespace amat_project.Models
{
    public class Formation
    {
       public string FormationId {get; set;} 
       public string Name {get; set;}
       public string Description {get; set;}
       
       public List<FormationModule> FormationModules {get; set;}
    
       public List<Session> Sessions {get; set;}
    }
}