using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C_.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; } 
        public string? NomeRepresentanteLegalPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é \n{Nome}, e tenho {Idade}");
        }
    }
}

//PascalCase em Classes, propriedades e métodos
//Não abreviar nomes de propriedades
//Nome do arquivo deve ser o nome da classe
