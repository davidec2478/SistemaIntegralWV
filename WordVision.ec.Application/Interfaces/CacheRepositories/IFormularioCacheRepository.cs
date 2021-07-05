﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordVision.ec.Domain.Entities.Registro;

namespace WordVision.ec.Application.Interfaces.CacheRepositories
{
    public interface IFormularioCacheRepository
    {
        Task<List<Formulario>> GetCachedListAsync();

        Task<Formulario> GetByIdAsync(int formularioId);
    }
}
