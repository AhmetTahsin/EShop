using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.DTOs.DTOClasesses
{
    public class ProductDTO:BaseDTO
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int? ProductImageID { get; set; }
        public int? CategoryID { get; set; }
    }
}
