using System;
using System.Collections.Generic;
using System.Text;

namespace WorkWithClass
{
    internal  class Transport   //Создайте базовый класс описывающий транспорт с произвольными полями 

    {
        public virtual void Move()    //и методом Move() возвращающим способ передвижения в виде строки. 
        {
            Console.WriteLine("Use transport ");
        }
    }


}
