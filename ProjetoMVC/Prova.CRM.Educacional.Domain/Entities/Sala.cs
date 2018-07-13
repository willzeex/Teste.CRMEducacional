namespace Prova.CRM.Educacional.Domain.Entities
{
    using System.Collections.Generic;

    public class Sala
    {
        public string NomeSala { get; set; }
        public int TotalVagas { get; set; }
        public int VagasDisponiveis { get; set; }
        public List<Candidato> Candidatos { get; set; } = new List<Candidato>();

        public void AdicionaCandidato(Candidato candidato)
        {
            Candidatos.Add(candidato);
            VagasDisponiveis--;
        }
    }
}
