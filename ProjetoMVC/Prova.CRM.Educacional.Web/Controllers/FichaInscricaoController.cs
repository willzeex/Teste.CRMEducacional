namespace Prova.CRM.Educacional.Web.Controllers
{
    using AutoMapper;
    using Domain.Entities.Integracao;
    using Domain.Interfaces.Services;
    using Models;
    using System;
    using System.Web.Mvc;

    public class FichaInscricaoController : Controller
    {
        private readonly IIntegracaoService _integracaoService;

        public FichaInscricaoController(IIntegracaoService integracaoService)
        {
            _integracaoService = integracaoService;
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(AlunoViewModel aluno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_integracaoService.Enviar(Mapper.Map<Aluno>(aluno)))
                        CriarMensagemSucesso("Formulário enviado com sucesso.");
                    else
                        CriarMensagemErro("Erro ao enviar formulário.");
                }
                catch (Exception ex)
                {
                    CriarMensagemErro(ex.Message);
                }
            }

            return View(aluno);
        }
    }
}