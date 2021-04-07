using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Data.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private List<SaleModel> _sales;
        private List<ItemModel> _items;

        public StoreRepository()
        {
            _sales = new List<SaleModel>();
            _items = new List<ItemModel>();
            //ITEMS data/states
            _items.Add(new ItemModel()
            {
                Id = 1,
                Name = "Nike Sweater",
                Type = "Clothing",
                PurchasePrice = 20,
                SalePrice = 25,
                Stock = 10
            });
            _items.Add(new ItemModel()
            {
                Id = 2,
                Name = "Polo Pants",
                Type = "Clothing",
                PurchasePrice = 25,
                SalePrice = 35,
                Stock = 5
            });
            _items.Add(new ItemModel()
            {
                Id = 3,
                Name = "Nintendo Switch",
                Type = "Gaming",
                PurchasePrice = 250,
                SalePrice = 300,
                Stock = 3
            });
            //SALES data/states
            _sales.Add(new SaleModel()
            {
                Id = 1,
                Quantity = 2,
                ClientName = "Pepe",
                ItemId = 1
            });
            _sales.Add(new SaleModel()
            {
                Id = 2,
                Quantity = 1,
                ClientName = "Juan",
                ItemId = 2
            });
            _sales.Add(new SaleModel()
            {
                Id = 3,
                Quantity = 3,
                ClientName = "Gabriel",
                ItemId = 3
            });
            
        }

        public ItemModel CreateItem(ItemModel newItem)
        {
            var next_Id = _items.OrderByDescending(f => f.Id).FirstOrDefault().Id + 1;
            newItem.Id = next_Id;
            _items.Add(newItem);
            return newItem;
        }

        public SaleModel CreateSale(long itemId, SaleModel newSale)
        {
            newSale.ItemId = itemId;//to avoid chainging the id
            var nextId = _sales.OrderByDescending(s => s.Id).FirstOrDefault().Id + 1;//gets las Id and adds 1 to it
            newSale.Id = nextId;
            _sales.Add(newSale);
            return newSale;
        }

        public IncomeModel GetIncome(long itemId, long saleId, string filterBy = "Type")
        {
            throw new NotImplementedException();
        }
    }
}
