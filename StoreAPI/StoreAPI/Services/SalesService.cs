using StoreAPI.Data.Repositories;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Services
{
    public class SalesService : ISalesService
    {
        private IStoreRepository _storeRepository;
        public SalesService(IStoreRepository repository)
        {
            _storeRepository = repository;
        }

        public SaleModel CreateSale(SaleModel newSale)
        {
            throw new NotImplementedException();
        }
    }
}
