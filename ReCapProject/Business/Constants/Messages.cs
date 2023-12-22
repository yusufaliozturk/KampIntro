using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarModelInvalid = "Araç Modeli Daha Düşük";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi!";
        public static string DailyPriceInvalid = "Araçlar Listelendi!";
        public static string CarCountOfBrandError = "Bir Marka'da En Fazla 10 Ürün Olacaktır!";
        public static string CarNameAldreadyExists = "Bu isimde Araç zaten eklidir!";
        public static string BrandLimitExceded = "Marka Sınırına ulaşıldığı için eklenemiyor!";
        public static string CarImageAdded ="Resim eklendi";
        public static string CarImageDeleted = "Resim Silindi";
        public static string? CarImageListed = "Resimler Listelendi";
        public static string? CarImagesListedID = "Araba IDlerine Göre Resimler Listelendi";
        public static string CarImageUpdated = "Resimler Güncellendi" ;
        public static string CarImageLimitReached = "Bir araç için maksimum sayıda yükleme yaptınız.";
        public static string CarImageAlreadyHave = "Bu resim daha önce eklenmişti.";
        public static string? AuthorizationDenied = "Yetkiniz yok.";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        internal static string PasswordError = "Parola Hatası";
    }
}
