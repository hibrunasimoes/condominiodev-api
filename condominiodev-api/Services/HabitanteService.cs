using System;
using System.Linq;
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

        public HabitanteGetDTO GetById(int id)
        {
            return new HabitanteGetDTO(_habitanteRepositoy.GetById(id));
        }

        public void Insert(HabitanteDTO habitante)
        {
            _habitanteRepositoy.Insert(new Habitante(habitante));
        }

        public IList<HabitanteGetDTO> ListAll(string nome, int id)
        {
            return _habitanteRepositoy.ListAll().Select(x => new HabitanteGetDTO(x)).ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

