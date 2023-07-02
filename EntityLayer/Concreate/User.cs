﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class User
    {
        public int UserID { get; set; }     //Kullanıcı ID
        public string UserName { get; set; }     //Kullanıcı Adı
        public string UserSurname { get; set; }     //Kullanıcı Soyadı
        public string UserImage { get; set; }     //Kullanıcı Resmi
        public string UserMail { get; set; }     //Kullanıcı Mail Adresi
        public string UserPassword { get; set; }     //Kullanıcı Parolası
        public string UserPhoneNumber { get; set; }     //Kullanıcı Telefon Numarası
        public string UserCity { get; set; }     //Kullanıcının Yaşadığı Şehir
        public string UserDistrict { get; set; }     //Kullanıcının Yaşadığı ilçe
        public string UserAddress { get; set; }     //Kullanıcının açık adresi
        public bool UserStatus { get; set; }     //Kullanıcı Durumu (Websitesine erişimi olacak mı engellenecek mi)

        public ICollection<Order> Orders { get; set; }    //Sipariş Tablosu ile ilişkilendirme
    }
}
