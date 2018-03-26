using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using nullwines.Models;

namespace nullwines.Interfaces
{
    public interface IRestService
    {
        Task<List<Wine>> GetWines();
    }
}
