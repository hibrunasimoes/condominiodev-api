using System;
using condominiodev_api.DTOs;

namespace condominiodev_api.Interfaces.Service
{
    public interface IHabitanteService
    {
        void Insert(HabitanteDTO habitante);
        void Update(HabitanteDTO habitante);
        void Delete(int id);
        IList<HabitanteGetDTO> ListAll(string nome, int id);
        HabitanteGetDTO GetById(int id);
        //int GetTotal();
    }
}

