namespace Prova.CRM.Educacional.Web.Models
{
    using Domain.Enum;

    public class MensagemViewModel
    {
        public TipoMensagem TipoMensagem { get; set; }
        public string Mensagem { get; set; }
    }
}