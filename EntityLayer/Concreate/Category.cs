﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Category
    {
        public int CategoryID { get; set; }     //Kategori ID
        public string CategoryName { get; set; }     //Kategori Adı
        public int CategoryUst { get; set; }     //Kategorinin Üst Kategorisi        {0 En üst Kategori }
        public bool CategoryStatus { get; set; }         //Kategorinin Dueumu

        public ICollection<Product> Products { get; set; }  //Ürün tablosu ile ilişkilendirme
    }
}
