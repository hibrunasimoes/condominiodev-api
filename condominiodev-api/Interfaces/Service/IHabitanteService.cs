using System;
using condominiodev_api.DTOs;

namespace condominiodev_api.Interfaces.Service
{
    public interface IHabitanteService
    {
        void Insert(HabitanteDTO habitante);
        void Update();
        void Delete();
        //IList<> ListAll();
        //GetById(int id);
        //int GetTotal();
    }
}

