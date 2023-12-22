using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.ENTITIES.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImagePath { get; set; }

        public int ProductID { get; set; }
        //Relation Property
        public virtual ICollection<Product> Products { get; set; }
    }
}
