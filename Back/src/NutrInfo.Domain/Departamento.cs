using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Departamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Collection<Funcionario> Funcionarios { get; set; }
    }
}