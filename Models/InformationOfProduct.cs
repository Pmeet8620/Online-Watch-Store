using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWatchStore.Models
{
    public class InformationOfPurchase
    {
        public int InformationOfPurchaseId { get; set; } //pk
        public int ProductId { get; set; }  //fk
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public Decimal DiscountedPrice { get; set; }

        public Product Product { get; set; }

    }
}
