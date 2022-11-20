using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_VIII_TESTE.Models
{
    [Table("PessoasTeste")]
    public class Pessoas
    {
        
        [Display(Name="Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public string CPF { get; set; }


        [Display(Name = "Endereco")]
        [Column("Endereco")]
        public Endereco Endereco { get; set; }

  
        

    }
}
