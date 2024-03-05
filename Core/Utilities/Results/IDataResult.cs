using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>: IResult //evrensel olması için T tipi yaptık zaten bu yüzden de Core içinde
                                             //T ye diğerleri gibi where ile kısaltma yapmadık her şey gelebilir
                                             //çünkü ve everensel olmasını istiyoruz.
    {
        T Data { get; }
    }
}
//Bu DataResult sayesinde Data değerleri döndürecek listeler için de bir işlem değeri (t/f), mesaj ve aynı zamanda
// data döndürebileceğiz böylece klasik list elemanı değil projemizin gereksinimlerini karşılayacak bir list kendimiz
//oluşturmuş olacağız. IResul mesaj ve değer döndürüyordu o yüzden IDataResult ondan miras aldı.
