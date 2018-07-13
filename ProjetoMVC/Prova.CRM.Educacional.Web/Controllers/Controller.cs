namespace Prova.CRM.Educacional.Web.Controllers
{
    using Domain.Enum;
    using Models;

    public class Controller : System.Web.Mvc.Controller
    {
        public void CriarMensagemSucesso(string mensagem)
        {
            TempData["message"] = new MensagemViewModel { TipoMensagem = TipoMensagem.Sucesso, Mensagem = mensagem };
        }

        public void CriarMensagemErro(string mensagem)
        {
            TempData["message"] = new MensagemViewModel { TipoMensagem = TipoMensagem.Erro, Mensagem = mensagem };
        }
    }
}