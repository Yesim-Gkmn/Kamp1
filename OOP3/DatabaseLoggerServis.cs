using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatebaseLoggerServis:ILoggerService
    {
        public void Log() 
        {
            Console.WriteLine("Veritabanıuna bağlandı");

        }
    }
}
