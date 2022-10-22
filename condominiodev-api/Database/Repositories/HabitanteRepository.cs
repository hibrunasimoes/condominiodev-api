﻿using System;
using System.Runtime.ConstrainedExecution;
using condominiodev_api.Interfaces.Repository;
using condominiodev_api.Model;

namespace condominiodev_api.Database.Repositories
{
    public class HabitanteRepository : BaseRepository<Habitante, int>, IHabitanteRepository
    {
        public HabitanteRepository(CondominioDevDbContext context) : base(context)
        {
        }
    }
}
