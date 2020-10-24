using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Imageurl { get; set; }
        public decimal Discount { get; set; }
        public string ImageThubnail { get; set; }
        public int CategoryId { get; set; }
        public bool HotObject { get; set; }
        public Category Category { get; set; }
    }
}
