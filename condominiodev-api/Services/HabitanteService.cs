using System;
using condominiodev_api.DTOs;
using condominiodev_api.Interfaces.Repository;
using condominiodev_api.Interfaces.Service;
using condominiodev_api.Model;

namespace condominiodev_api.Services
{
    public class HabitanteService : IHabitanteService
    {
        private readonly IHabitanteRepository _habitanteRepositoy;

        public HabitanteService (IHabitanteRepository habitanteRepository)
        {
            _habitanteRepositoy = habitanteRepository;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert(HabitanteDTO habitante)
        {
            _habitanteRepositoy.Insert(new Habitante(habitante));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

