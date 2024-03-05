using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>: DataResult<T> 
    {
        public SuccessDataResult(T data, string message): base(data, true, message)
        {

        }

        public SuccessDataResult(T data): base(data, true)
        {

        }

        public SuccessDataResult(string message): base(default, true, message)
        {

        }

        public SuccessDataResult(): base(default, true)
        {

        }

        //İhtiyaca göre elimizin altında bulunması açısından Result seçenekleri oluşturduk.
        //Kimisinde data var kimisi boş kimisi ikili kombinasyonlar vb.
    }
}
