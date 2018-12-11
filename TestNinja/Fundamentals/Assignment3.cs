using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        /// <summary>
        /// Скачивание файла. Если загрузка завершена выводит,
        /// что файл загружен , иначе сообщение о старте загрузки
        /// </summary>
        /// <param name="procent">Процент загрузки файла</param>
        /// <returns></returns>
        public BaseImplementation DownloadFile(double procent)
        {
            if (procent < 1)
            {
                return new Start();
            }
            else if ( procent>1)
            {
                return new Error();
            }
            return new Complete();
        }
        public class Error : BaseImplementation
        {
            public string Display()
            {
                return "Error Download is File!";
            }
            public Error()
            {
                Display();
            }
        }
        public class Start : BaseImplementation
        {
            public string Display()
            {
                return "File Download started!";
            }
            public Start()
            {
                Display();
            }
        }
        public class Complete : BaseImplementation
        {
            public string Display()
            {
                return "File Download is Complete!";
            }
            public Complete()
            {
                Display();
            }
        }
        public class BaseImplementation
        {
        }
    }
}
