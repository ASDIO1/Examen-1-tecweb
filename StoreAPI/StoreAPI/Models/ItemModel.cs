using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class ItemModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float PurchasePrice { get; set; }
        public float SalePrice { get; set; }
        public int Stock { get; set; }
        //public long SaleId { get; set; }//May be unnecesary for 1-->1 relationship??
    }
}
