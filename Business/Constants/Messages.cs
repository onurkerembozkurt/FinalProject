using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string CategoryCountError = "Category sayısı aşıldı";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string SerializationInfoAuthorizationDenied="SerializationInfoAuthourizationDenied";
    }
}
