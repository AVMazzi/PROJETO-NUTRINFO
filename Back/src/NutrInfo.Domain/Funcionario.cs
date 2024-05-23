using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissão { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Foto { get; set; }
        public string EstadoCivil { get; set; }
        public bool Ativo { get; set; }

    }
}