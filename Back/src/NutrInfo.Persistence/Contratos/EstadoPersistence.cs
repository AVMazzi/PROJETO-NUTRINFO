using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NutrInfo.Domain;
using NutrInfo.Persistence.Contextos;
using NutrInfo.Persistence.Interfaces;

namespace NutrInfo.Persistence.Contratos
{
    public class EstadoPersistence : IEstadoPersistence
    {
        private readonly NutrInfoContext _context;
        public EstadoPersistence(NutrInfoContext context)
        {
            _context = context;

        }

        public async Task<List<Estado>> GetAllEstadosAsync()
        {
            IQueryable<Estado> query = _context.Estados;
            query.OrderBy(e => e.ID);
            return await query.ToListAsync();
        }

        public async Task<List<Estado>> GetAllEstadosByNomeAsync(string estadoNome)
        {
            IQueryable<Estado> query = _context.Estados;
            query.OrderBy(e => e.Nome)
                  .Where(e => e.Nome.ToLower().Contains(estadoNome.ToLower()));
            return await query.ToListAsync();
        }

        public async Task<Estado> GetEstadoByIdAsync(int estadoId)
        {
            IQueryable<Estado> query = _context.Estados;
            query.OrderBy(e => e.Nome)
                 .Where(e => e.ID.Equals(estadoId));
            return await query.FirstOrDefaultAsync();
        }
    }
}