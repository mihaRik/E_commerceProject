
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerceProject_Electro.Models
{
    public class ProductToImages
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductDiscountValueInPercents { get; set; }
        public DateTime ProductAddDate { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
    }
}