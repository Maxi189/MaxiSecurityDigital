using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class PrestadorServicos
    {
        [Key]
        [DisplayName("Código do Prestador de Serviços")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(45, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        //[Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "CNPJ Inválido!")]
        [MaxLength(18, ErrorMessage = "CNPJ Inválido!")]
        public string CNPJ { get; set; }
        //[Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "CPF Inválido!")]
        [MaxLength(14, ErrorMessage = "CPF Inválido!")]
        public string CPF { get; set; }
        public DateTime DataChegada { get; set; }
        public DateTime DataSaida { get; set; }
        public TimeSpan HoraChegada { get; set; }
        public TimeSpan HoraSaida { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
