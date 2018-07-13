namespace Prova.CRM.Educacional.Web.Models
{
    using System.Collections.Generic;

    public class SalaViewModel
    {
        public string NomeSala { get; set; }
        public int TotalVagas { get; set; }
        public int VagasDisponiveis { get; set; }
        public List<CandidatoViewModel> Candidatos { get; set; } = new List<CandidatoViewModel>();
    }
}