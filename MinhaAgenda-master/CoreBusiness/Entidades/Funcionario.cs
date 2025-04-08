using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entidades
{
    public class Funcionario
    {
        public Funcionario()
        {

        }

        public Funcionario(string nome, int idade, string sexo, string cargo, String observacao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Cargo = cargo;
            Observacao = observacao;
        }


        [Required]
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public int? Idade { get; set; }
        public string? Sexo { get; set; }
        public string? Cargo { get; set; }

        public string? Observacao { get; set; }


    }   
}

