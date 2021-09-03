﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordVision.ec.Domain.Entities.Soporte;


namespace WordVision.ec.Application.Interfaces.Repositories.Soporte
{
    public interface IPonenteRepository
    {
        Task<List<Ponente>> GetListAsync();

        Task<int> InsertAsync(Ponente ponente);

        Task UpdateAsync(Ponente ponente);
        Task DeleteAsync(Ponente ponente);
        Task<Ponente> GetPonenteAsync(int idPonente);
      
    }
}
