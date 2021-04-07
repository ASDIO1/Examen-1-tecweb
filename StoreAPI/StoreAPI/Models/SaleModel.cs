using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class SaleModel
    {
        public long Id { get; set; }
        public IEnumerable<ItemModel> Items { get; set; }
        public int Quantity { get; set; }
        public string ClientName { get; set; }
        public long ItemId { get; set; }//
    }
}
