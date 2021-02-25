using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWatchStore.Models
{
    public class Product
    {
        public int ProductId { get; set; } //PK
        public String NameOfProduct { get; set; }
        public String Brand { get; set; }
        public String Gender { get; set; }
        public int Specification { get; set; }
        public int Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<InformationOfPurchase> InformationOfPurchases { get; set; }


    }
}
