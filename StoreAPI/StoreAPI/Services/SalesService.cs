using StoreAPI.Data.Repositories;
using StoreAPI.Exceptions;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Services
{
    public class SalesService : ISalesService
    {
        private HashSet<string> _allowedFilterByValues = new HashSet<string>()
        {
            "name",
            "type"
        };
        private IStoreRepository _storeRepository;
        public SalesService(IStoreRepository repository)
        {
            _storeRepository = repository;
        }

        public SaleModel CreateSale(long itemId, SaleModel newSale)
        {
            //ValidateFood(foodId);
            var createdSale = _storeRepository.CreateSale(itemId, newSale);
            return createdSale;
        }

        public IEnumerable<IncomeModel> GetIncome(long itemId, long saleId, string filterBy = "Type")
        {
            if (!_allowedFilterByValues.Contains(filterBy.ToLower()))
                throw new InvalidOperationItemException($"The income filterBy value: {filterBy} is invalid, please use one of {String.Join(',', _allowedFilterByValues.ToArray())}");
            
            var saleIncome = _storeRepository.GetIncome(itemId, saleId, filterBy);
            return saleIncome;
        }
    }
}
