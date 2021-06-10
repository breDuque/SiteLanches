﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteLanches.Context;
using SiteLanches.Models;
using SiteLanches.Repositories.RepositoriesInterfaces;

namespace SiteLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(i => i.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(i => i.IsLanchePreferido).Include(i => i.Categoria);

        public Lanche GerLancheById(int lancheId) => _context.Lanches.FirstOrDefault(i => i.LancheId == lancheId);
    }
}
