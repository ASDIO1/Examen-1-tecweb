using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Services
{
    public interface IItemsService
    {
        public ItemModel CreateItem(ItemModel newItem);
    }
}
