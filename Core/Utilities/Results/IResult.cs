using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get;  } // sadece get kullanırsak sadece okunabilir demek. İşlemin başarı durumunu gösterecek
        string Message { get; } // Buda işlemin başarı durumunu ve neden başarılı/başarısız olduğunu anlatacak mesaj
    }
}
