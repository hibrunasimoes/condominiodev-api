using System;
using condominiodev_api.DTOs;
using condominiodev_api.Model;

namespace condominiodev_api.Interfaces.Service
{
    public interface IHabitanteService
    {
        void Insert(HabitanteDTO habitante);
        void Update(HabitanteDTO habitante);
        void Delete(int id);
        IList<HabitanteGetDTO> ListAll(string nome, int id);
        HabitanteDTO GetById(int id);
        //int GetTotal();
        HabitanteDTO GetByMonth(int mes);
        HabitanteDTO GetByName(string nome);
        HabitanteGetDTO GetMaiorCusto();
        public int GetTotalSpend();
        public int TotalBudget();

    }
}

