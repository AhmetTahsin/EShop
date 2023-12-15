using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



        public int? ProductImageID { get; set; }
        public int? CategoryID { get; set; }

        //Relation Property
        public virtual Category Category { get; set; }
        public virtual ProductImage ProductImage { get; set; }
    }
}
