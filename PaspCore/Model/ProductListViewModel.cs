﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class ProductListViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Product> Products { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrentCategory { get; set; }
    }
}
