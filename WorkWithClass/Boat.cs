using System;
using System.Collections.Generic;
using System.Text;

namespace WorkWithClass
{
    internal class Boat: Transport  //Добавьте производный класс описывающий лодку. 
    {
       
           public override void Move()   //Переопределите метод Move() чтобы его поведение было актуально. 
        {
                Console.WriteLine("Use boat ");
            }

    }
}
