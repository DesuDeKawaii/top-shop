using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_shop_models.Models
{
    public class Warehouse
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } 

        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } 
    }
}
