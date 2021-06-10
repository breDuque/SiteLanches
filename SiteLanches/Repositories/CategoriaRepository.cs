using SiteLanches.Context;
using SiteLanches.Models;
using SiteLanches.Repositories.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
