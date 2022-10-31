using System;
using condominiodev_api.Model;

namespace condominiodev_api.DTOs
{
    public class HabitanteGetDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Renda { get; set; }


        public HabitanteGetDTO()
        {

        }

        public HabitanteGetDTO(Habitante habitante)
        {
            Id = habitante.Id;
            Nome = habitante.Nome;
            Renda = habitante.Renda;
        }

    }
}

