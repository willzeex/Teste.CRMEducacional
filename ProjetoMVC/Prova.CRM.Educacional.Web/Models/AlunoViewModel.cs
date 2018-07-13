namespace Prova.CRM.Educacional.Web.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class AlunoViewModel
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo é de 50 caracteres.")]
        public string firstname { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "O tamanho máximo é de 20 caracteres.")]
        public string cad_cpf { get; set; }

        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime cad_datanascimento { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um endereço de email válido.")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string emailaddress1 { get; set; }
    }
}