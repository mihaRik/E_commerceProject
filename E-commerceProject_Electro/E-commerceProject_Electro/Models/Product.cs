using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerceProject_Electro.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductDiscountValueInPercents { get; set; }

        public int ProductSellCount { get; set; }

        public DateTime ProductAddDate { get; set; }

        public Product()
        {
            ProductAddDate = DateTime.Now.Date;
        }

        public int CategoryId  { get; set; }

        public string ImagePath { get; set; }
    }
}