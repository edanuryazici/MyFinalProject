using System;

namespace Business.CCS
{
    public class DatabaseLoger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglama Yapıldı!");
        }
    }
}
