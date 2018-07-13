namespace Prova.CRM.Educacional.Domain.Interfaces.Services
{
    using Entities.Integracao;

    public interface IIntegracaoService
    {
        bool Enviar(Aluno aluno);
    }
}
