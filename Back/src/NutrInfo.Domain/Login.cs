using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Login
    {
                public int ID { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Collection<Funcionario> Funcionarios { get; set; }
    }
}