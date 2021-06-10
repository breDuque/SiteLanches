using SiteLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteLanches.Repositories.RepositoriesInterfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }

    }
}
