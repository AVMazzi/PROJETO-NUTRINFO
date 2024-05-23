using NutrInfo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutrInfo.Persistence.Interfaces
{
    public interface IEstadoPersistence
    {
        Task<List<Estado>> GetAllEstadosAsync();
        Task<List<Estado>> GetAllEstadosByNomeAsync(string estadoNome);
        Task<Estado> GetEstadoByIdAsync(int estadoId);
    }
}