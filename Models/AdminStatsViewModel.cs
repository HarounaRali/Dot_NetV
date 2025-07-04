using System.Collections.Generic;

namespace SuiviLivraison.Models
{
    public class AdminStatsViewModel
    {
        public int TotalColis { get; set; }
        public int ColisEnAttente { get; set; }
        public int ColisEnCours { get; set; }
        public int ColisLivres { get; set; }
        public int TotalClients { get; set; }
        public int TotalLivreurs { get; set; }
        public decimal TauxLivraison { get; set; }
        public int ColisAnnules { get; set; }
        public List<StatutCount> ColisParStatut { get; set; } = new List<StatutCount>();
    }

    public class StatutCount
    {
        public string Statut { get; set; } = string.Empty;
        public int Count { get; set; }
    }
} 