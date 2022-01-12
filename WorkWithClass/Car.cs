using System;
using System.Collections.Generic;
using System.Text;

namespace WorkWithClass
{
    internal class Car: Transport  //Добавьте производный класс описывающий автомобиль. 
    {
        public override void Move()   //Переопределите метод Move() чтобы его поведение было актуально. 
        {
            Console.WriteLine("Use car ");
        }
    }
}
