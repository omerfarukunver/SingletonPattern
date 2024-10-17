using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LogManager
    {
        private static LogManager _instance;

        // Private constructor, dışarıdan nesne oluşturulamaz. Ondan dolayı boş
        private LogManager() {}

        // Tek örneği almak için metod
        public static LogManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LogManager();
            }
            return _instance;
        }

        // Log işlemi, sadece Console'a yazdırıyor
        public void Log(string message)
        {
            Console.WriteLine($"Log atıldı: {message}");
        }
    }
}
