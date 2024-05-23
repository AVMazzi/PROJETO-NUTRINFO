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
    public class DepartamentoPersistence : IDepartamentoPersistence
    {
        private readonly NutrInfoContext _context;
        public DepartamentoPersistence(NutrInfoContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> GetAllDepartamentoByNomeAsync(string departamentoNome)
        {
            IQueryable<Departamento> query = _context.Departamentos;

            query = query
                    .Include(perm => perm.Permissoes);

            query.OrderBy(d => d.Nome)
                 .Where(d => d.Nome.ToLower().Contains(departamentoNome.ToLower()));
            return await query.ToListAsync();
        }

        public async Task<List<Departamento>> GetAllDepartamentosAsync()
        {
            IQueryable<Departamento> query = _context.Departamentos;

            query = query.Include(perm => perm.Permissoes);
            query.OrderBy(dpto => dpto.ID);
            return await query.ToListAsync();
        }

        public async Task<Departamento> GetDepartamentoByIdAsync(int departamentoId)
        {
            IQueryable<Departamento> query = _context.Departamentos;

            query.Include(perm => perm.Permissoes); ;

            query.OrderBy(d => d.Nome)
                 .Where(dpto => dpto.ID.Equals(departamentoId));
            return await query.FirstOrDefaultAsync();
        }
    }
}