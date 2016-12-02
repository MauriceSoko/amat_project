namespace amat_project.Models
{
    public class FormationModule
    {
       public string FormationId {get; set;}
       public Formation Formation {get; set;} 

       public string ModuleId {get; set;}
       public Module Module {get; set;}
    }
}