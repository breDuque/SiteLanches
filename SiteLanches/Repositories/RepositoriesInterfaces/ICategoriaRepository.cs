using SiteLanches.Models;
using System.Collections.Generic;

namespace SiteLanches.Repositories.RepositoriesInterfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}