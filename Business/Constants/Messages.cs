using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CategoryAdded="Kategori eklendi.";
        public static string CategoryNameInvalid="Kategori ismi geçersiz.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string CategoryUpdated ="Kategori güncellendi.";
        public static string CategoryDeleted="Kategori silindi.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductListed="Ürün Listelendi.";
        public static string ProductAdded="Ürün eklendi.";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string UnitPriceInvalid="Ücret yetersiz";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürürn olabilir.";
        public static string ProductNameAlreadyExist=" Bu isimde bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemior.";
        public static string? AuthorizationDenied="Yetkiniz Yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
