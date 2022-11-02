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
        private readonly IHabitanteRepository _habitanteRepository;

        public HabitanteService (IHabitanteRepository habitanteRepository)
        {
            _habitanteRepository = habitanteRepository;
        }

        public void Delete(int id)
        {
            var habitante = _habitanteRepository.GetById(id);
            _habitanteRepository.Delete(habitante);

        }

        public HabitanteDTO GetById(int id)
        {
            //return new HabitanteDTO(_habitanteRepository.GetById(id));
            return new HabitanteDTO(_habitanteRepository.GetById(id));
        }

        public HabitanteDTO GetByMonth(int mes)
        {
            return new HabitanteDTO(_habitanteRepository.GetByMonth(mes));
        }

        public HabitanteDTO GetByName(string nome)
        {
            return new HabitanteDTO(_habitanteRepository.GetByName(nome));
        }

        public void Insert(HabitanteDTO habitante)
        {
            _habitanteRepository.Insert(new Habitante(habitante));
        }

        public IList<HabitanteGetDTO> ListAll(string nome, int id)
        {
            return _habitanteRepository.ListAll().Select(x => new HabitanteGetDTO(x)).ToList();
        }

        public HabitanteGetDTO GetMaiorCusto()
        {
            return new HabitanteGetDTO(_habitanteRepository.GetMaiorCusto());
        }

        public void Update(HabitanteDTO habitante)
        {
            var habitanteDb = _habitanteRepository.GetById(habitante.Id);
            habitanteDb.Update(habitante);

            _habitanteRepository.Update(habitanteDb);
        }

        public int GetTotalSpend()
        {
            int sum = 0;
            var spend = _habitanteRepository.GetTotalSpend();
            foreach (var renda in spend)
            {
                sum += renda;
            }
            return sum;
        }

        public int TotalBudget()
        {
            return _habitanteRepository.TotalBudget();
        }

        public string BetweenBudgetAndExpense()
        {
            int rendaTotal = 0;

            var listaRenda = _habitanteRepository.GetTotalSpend();
            var gastoPorHabitantes = listaRenda.Count;
            foreach (var renda in listaRenda)
            {
                rendaTotal += renda;
            }
            var valorTotalCondominio = _habitanteRepository.TotalBudget() * gastoPorHabitantes;
            var gastofinal = rendaTotal - valorTotalCondominio;

            return $"A renda total do condomínio é referente ao custo de todos os habitantes, que corresponde ao valor de R$ {rendaTotal}. E valor de renda final é de R$ {gastofinal} devido ao desconto do valor do Condomino de R$ 800 por apartamento";

        }
    }
}

