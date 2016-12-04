using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace amat_project.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit contenir au moins {2} et au plus {1} caractere.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer mot de passe")]
        [Compare("NewPassword", ErrorMessage = "Les mots de passe entres ne correspondent.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
