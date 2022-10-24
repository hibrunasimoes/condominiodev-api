using System;
using condominiodev_api.Model;

namespace condominiodev_api.DTOs
{
    public class HabitanteDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Renda { get; set; }

        public string CPF { get; set; }

        public HabitanteDTO()
        {

        }

        public HabitanteDTO (Habitante habitante)
        {
            Id = habitante.Id;
            Nome = habitante.Nome;
            Sobrenome = habitante.Sobrenome;
            DataNascimento = habitante.DataNascimento;
            Renda = habitante.Renda;
            CPF = habitante.CPF;
        }
    }
}

