namespace Prova.CRM.Educacional.Domain.Interfaces.Services
{
    using Entities;
    using System.Collections.Generic;

    public interface IEnsalamentoService
    {
        List<Sala> DistribuirCandidatos(string fileName);
    }
}
