using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class NewsLetter
    {
        public  int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  DateTime DateCreated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  bool Disabled { get; set; }
      

    }
}
