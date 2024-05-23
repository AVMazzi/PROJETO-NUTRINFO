using NutrInfo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Persistence.Interfaces
{
    public interface IDepartamentoPersistence
    {
        Task<List<Departamento>> GetAllDepartamentosAsync();
        Task<List<Departamento>> GetAllDepartamentoByNomeAsync(string departamentoNome);
        Task<Departamento> GetDepartamentoByIdAsync(int departamentoId);
    }
}