﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }  //Ürün ID
        [StringLength(50)]
        public string ProductName { get; set; } //Ürün Adı
        [StringLength(250)]
        public string ProductDescription { get; set; }  //Ürün Açıklaması
        public int ProductStock { get; set; }  //Ürün Stok Sayısı
        public float ProductPrice { get; set; }  //Ürün Fiyatı
        [StringLength(250)]
        public string ProductNote { get; set; }  //Ürün Notu
        public float ProductDiscount { get; set; } //Ürün indirim Miktarı
        public bool ProductDiscountStatus { get; set; }  //Ürün İndirim Durumu
        public bool ProductStatus { get; set; }  //Ürün Durumu
        public int ProductDetailObserveCount { get; set; }  //Ürün Detay görüntülenme sayısı
        public int ProductBasketInsertCount { get; set; }  //Ürün Sepete Ekleme Sayısı
        public int ProductBasketDeleteCount { get; set; }  //Ürün Sepetten Silinme Sayısı
        public int ProductSellCount { get; set; }  //Ürün Satın alınma sayısı
        public int ProductReturnCount { get; set; }  //Ürün Iade sayısı


        public int CategoryID { get; set; }     //Ürün Kategori ID
        public virtual Category Category { get; set; }  //Kategori tablosu ile ilişkilendirme

        public ICollection<ProductImage> ProductImages { get; set; }    //Ürün Resim Tablosu ile ilişkilendirme

        public ICollection<OrderDetail> OrderDetails { get; set; }    //Sipariş Detay Tablosu ile ilişkilendirme

        public ICollection<Comment> Comments{ get; set; }    //Yorum Tablosu ile ilişkilendirme

        public ICollection<Basket> Baskets { get; set; }  //Sepet tablosu ile ilişkilendirme
    }
}
