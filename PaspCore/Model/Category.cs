﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class Category
    {
        /// <summary>
        /// 
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CategoryDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
