using System;
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
    }
}
