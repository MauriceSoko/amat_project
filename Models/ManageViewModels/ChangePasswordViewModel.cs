using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace amat_project.Models.ManageViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit contenir au moins {2} et au plus {1} carateres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau mot de passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [Compare("Password", ErrorMessage = "Les nouveaux mot de passe ntres ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
}
