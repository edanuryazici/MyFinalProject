using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message): this(success)  //constructor aracılığı ile yapı ekledik otomatik
                                                                    //this(success) ile iki imzalı method çalıştığı zaman
                                                                    //hem mesaj hemde success çalışır ama mesaj yollamak istemezsek
                                                                    //success tek başınada çalışabilir.
        {
            Message = message; 
        }

        public Result(bool success) //Mesajı her seferinde vermek istemeyebiliriz
        {
            Success = success;  //read-only yapılar (aşağıdaki mesaj sadece get edilmiş o da readl only)
                                //constructor aracılığı ile set edilebilir.
        }

        // Sadece get kullanıldığı için yapıyı bu şekilde implement etmeliyiz
        public bool Success { get; }

        public string Message { get; }
    }
}
