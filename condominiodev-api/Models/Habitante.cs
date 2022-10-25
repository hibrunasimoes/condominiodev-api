using System;
using condominiodev_api.DTOs;

namespace condominiodev_api.Model
{
    public class Habitante
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Renda { get; set; }

        public string CPF { get; set; }

        public Habitante (HabitanteDTO habitante)
        {
            Id = habitante.Id;
            Nome = habitante.Nome;
            Sobrenome = habitante.Sobrenome;
            DataNascimento = habitante.DataNascimento;
            Renda = habitante.Renda;
            CPF = habitante.CPF;
        }

        public Habitante ()
        {

        }

        public Habitante (HabitanteGetDTO habitante)
        {
            Id = habitante.Id;
            Nome = habitante.Nome;
        }
    }
}
