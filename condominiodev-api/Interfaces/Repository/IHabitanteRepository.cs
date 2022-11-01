using System;
using condominiodev_api.DTOs;
using condominiodev_api.Model;

namespace condominiodev_api.Interfaces.Repository
{
    public interface IHabitanteRepository : IBaseRepository<Habitante, int>
    {
        Habitante GetByMonth(int mes);
        Habitante GetByName(string nome);
        Habitante GetMaiorCusto();
        IList<int> GetTotalSpend();
    }
}

