using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Services
{
    public interface ISalesService
    {
        public SaleModel CreateSale(long itemId, SaleModel newSale);
        public IEnumerable<IncomeModel> GetIncome(long itemId, long saleId, string filterBy = "Type");
    }
}
