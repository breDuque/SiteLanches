using SiteLanches.Models;
using System.Collections.Generic;

namespace SiteLanches.Repositories.RepositoriesInterfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GerLancheById(int lancheId);

    }
}
