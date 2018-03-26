using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using nullwines.Interfaces;
using nullwines.Models;

namespace nullwines.Data
{
    public class WineManager
    {
        IRestService restService;

        public WineManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Wine>> GetWines()
        {
            return restService.GetWines();
        }
    }
}
