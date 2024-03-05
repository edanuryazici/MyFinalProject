using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static yaptık ki new lenmesin diye çünkü bu class içerisinde düzenlemesi kolay
                                 //olsun diye sistem mesajlarının stringlerini tutacağız
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz"; // değişken olmasına rağmen büyük harfle
                                                                        //publicler büyük harfle isimlendirilir.
        public static string ProductList = "Ürünler Listelendi";                                                                // isimlendirdik çünkü public bir değişken 
        internal static string MaintenanceTime="Sistem Bakımda";
        
    }
}
