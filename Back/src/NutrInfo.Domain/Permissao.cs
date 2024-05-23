using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Domain
{
    public class Permissao
    {
        public int ID { get; set; }
        public string TipoPermissao { get; set; }
        public Collection<Departamento> Departamentos { get; set; }
    }
}