using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_commerceProject_Electro.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}