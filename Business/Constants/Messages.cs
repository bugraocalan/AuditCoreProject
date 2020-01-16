using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuditMasterSaveError = "Kayıt oluşturulamadı.";
        public static string AuditMasterSaveSuccess = "Master Kayıt oluşturuldu";
        public static string AuditMasterNotFound = "Master Kaydı bulunamadı.";

        public static string AuditEndSuccessful = "Denetim sonlandırıldı.";

        public static string AuditMasterAlreadyExist = "Kayıt edilmek istenen denetim zaten var.";

        public static string AuditDetailsNotFound = "Kayıt edilmek istenen denetimin detayları bulunamadı.";

        public static string AuditAdded = "Denetim oluşturuldu";
    }
}
