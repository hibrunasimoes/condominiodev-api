using System;
using System.Runtime.ConstrainedExecution;
using condominiodev_api.DTOs;
using condominiodev_api.Interfaces.Repository;
using condominiodev_api.Model;

namespace condominiodev_api.Database.Repositories
{
    public class HabitanteRepository : BaseRepository<Habitante, int>, IHabitanteRepository
    {
        public HabitanteRepository(CondominioDevDbContext context) : base(context)
        {
        }

        public Habitante GetByMonth(int mes)
         {
            return _context.Habitantes.FirstOrDefault(h => h.DataNascimento.Month == mes);
        }

        public Habitante GetByName(string nome)
        {
            return _context.Habitantes.FirstOrDefault(h => h.Nome == nome);
        }

        public Habitante GetMaiorCusto()
        {
            return _context.Habitantes.Where(where => where.Renda > 0).OrderByDescending(r => r.Renda).FirstOrDefault();

        }

        public IList<int> GetTotalSpend()
        {
            return _context.Habitantes.Select(select => select.Renda).ToList();
        }

        public int TotalBudget()
        {
            return 800;
        }
    }
}

