using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LogManager'ın örneğini alıyoruz
            LogManager logger = LogManager.GetInstance();

            // Log işlemi
            logger.Log("Program başladı.");
            logger.Log("İlk kayıt atıldı.");

            // Aynı singleton instance ile farklı bir log işlemi
            LogManager anotherLogger = LogManager.GetInstance();
            anotherLogger.Log("İkinci kayıt atıldı.");

            // İki referansın aynı olup olmadığının kontrolü
            Console.WriteLine(Object.ReferenceEquals(logger, anotherLogger)); 
        }
    }
}
