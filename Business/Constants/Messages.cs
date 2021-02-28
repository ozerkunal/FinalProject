using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım çalışması var";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "10 dan fazla ürün olamaz";
        public static string ProductNameExistsError="Bu isim zaten var";
        public static string CategoryLimitExceededError="Kategori Limiti Aşıldı";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered="Kullanıcı Başarıyla Kaydedildi";
        public static string UserNotFound="Kullanıcı  Bulunamadı";
        public static string PasswordError="Hatalı Şifre";
        public static string SuccessfulLogin="Sisteme Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated="Access Token Başarıyla Oluşturuldu";
    }
}
