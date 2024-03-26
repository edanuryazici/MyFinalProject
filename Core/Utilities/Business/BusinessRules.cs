using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)// verilen parametreden istediğin sayıdan geç demek params burada parametre IResult, lopgics de gönderilen iş kuralı metodu
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) // eğer iş kuralı başarılı değilse
                {
                    return logic; //hatalı olan kuralı gönder
                }
            }

            return null;
        }
    }
}
