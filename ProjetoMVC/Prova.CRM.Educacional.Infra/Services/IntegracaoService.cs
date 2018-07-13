namespace Prova.CRM.Educacional.Infra.Services
{
    using Domain.Entities.Integracao;
    using Domain.Interfaces.Services;
    using RestSharp;
    using System;
    using System.Configuration;
    using System.Net;

    public class IntegracaoService : IIntegracaoService
    {
        public bool Enviar(Aluno aluno)
        {
            var client = new RestClient(ConfigurationManager.AppSettings["URLAPI"].ToString());
            var request = new RestRequest(Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddBody(aluno);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NoContent)
                return true;
            else
                throw new Exception("Erro acessar webservice. StatusCode: " + response.StatusCode);

        }
    }
}
