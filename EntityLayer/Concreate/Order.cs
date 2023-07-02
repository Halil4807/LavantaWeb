﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Order  //Sipariş
    {
        public int OrderID { get; set; } //Sipariş ID
        public DateTime OrderDateTime { get; set; } //Sipariş Tarihi
        public string OrderState { get; set; } //Sipariş Güncel Durumu
        public string OrderPayType { get; set; }
        public float OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderCargoPrice { get; set; }

        public int UserID { get; set; }  //Kullanıcı ID
        public virtual User User { get; set; }    //Kullanıcı Tablosu ile ilişkilendirme


        public ICollection<OrderDetail> OrderDetails { get; set; }    //Sipariş Detay Tablosu ile ilişkilendirme
    }
}
