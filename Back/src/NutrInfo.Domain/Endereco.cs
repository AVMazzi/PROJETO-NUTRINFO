using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Endereco
    {
            public int ID { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set;}
    public Collection<Estado> Estados { get; set; }
    }
}