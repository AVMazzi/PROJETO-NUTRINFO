using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Estado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Collection<Endereco> Enderecos { get; set; }
    }
}