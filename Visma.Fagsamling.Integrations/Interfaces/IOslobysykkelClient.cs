﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Visma.Fagsamling.Domain.Models;

namespace Visma.Fagsamling.External.Interfaces
{
    public interface IOslobysykkelClient
    {
        Task<List<BikeStation>> GetBikeStations();
    }
}