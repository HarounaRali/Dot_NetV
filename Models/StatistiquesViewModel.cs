using System.Collections.Generic;

namespace SuiviLivraison.Models
{
    public class StatistiquesViewModel
    {
        public int TotalColis { get; set; }
        public int ColisEnAttente { get; set; }
        public int ColisEnCours { get; set; }
        public int ColisLivres { get; set; }
        public int ColisAnnules { get; set; }
        public int TotalClients { get; set; }
        public int TotalLivreurs { get; set; }
        public decimal TauxLivraison { get; set; }
        public List<Colis> ColisRecents { get; set; } = new List<Colis>();
        public Dictionary<string, int> ColisParMois { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> ColisParStatut { get; set; } = new Dictionary<string, int>();
        public List<TopLivreurViewModel> TopLivreurs { get; set; } = new List<TopLivreurViewModel>();
    }

    public class TopLivreurViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public int ColisLivres { get; set; }
        public decimal Performance { get; set; }
    }
} 