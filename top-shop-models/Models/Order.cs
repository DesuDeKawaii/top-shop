using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_shop_models.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public double TotalPrice { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get;set; }
    }
}
