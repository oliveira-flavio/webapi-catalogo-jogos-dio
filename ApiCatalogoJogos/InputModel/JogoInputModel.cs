using System;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo precisa ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da Produtora precisa ter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }
        [Range(1,2000, ErrorMessage = "O preço deve ser maior de R$1,00 e menor que R$2000,00")]
        public double Preco { get; set; }
    }
}
