using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Data.Repositories
{
    public interface IStoreRepository
    {
        //ITEM
        public ItemModel CreateItem(ItemModel newItem);
        //SALE
       // public SaleModel CreateFood(SaleModel newSale);
    }
}
