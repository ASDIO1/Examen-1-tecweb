using StoreAPI.Data.Repositories;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Services
{
    public class ItemsService : IItemsService
    {
        private IStoreRepository _storeRepository;
        public ItemsService(IStoreRepository repository)
        {
            _storeRepository = repository;
        }
        public ItemModel CreateItem(ItemModel newItem)
        {
            var createdItem = _storeRepository.CreateItem(newItem);
            return createdItem;
        }
    }
}
