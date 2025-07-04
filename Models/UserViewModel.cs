using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SuiviLivraison.Models
{
    public class UserViewModel
    {
        public string Id { get; set; } = string.Empty;
        
        [Display(Name = "Nom")]
        public string Nom { get; set; } = string.Empty;
        
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
        
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; } = string.Empty;
        
        [Display(Name = "Rôle")]
        public string Role { get; set; } = string.Empty;
        
        [Display(Name = "Statut")]
        public string Statut { get; set; } = string.Empty;
        
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }
        
        public bool IsActive { get; set; }
        
        public List<string> Roles { get; set; } = new List<string>();
    }
} 