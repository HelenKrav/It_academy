﻿using System;

namespace WorkWithClass
{
    /* Создайте метод выводящий информацию о том, как Человек передвигается. 
    * Смена типа транспорта возможна исключитеьно через свойство либо метод. */


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Boat boat = new Boat();
            person.ChangeTransport(boat);
            person.Move();
            

            Car car = new Car();
            person.ChangeTransport(car);
            person.Move();
        }
    }
}


/*
 *  Создайте базовый класс описывающий транспорт с произвольными полями и методом Move() возвращающим способ передвижения в виде строки. 
 *  Добавьте производный класс описывающий лодку. 
 * Переопределите метод Move() чтобы его поведение было актуально. 
 * Добавьте производный класс описывающий автомобиль. 
 * Переопределите метод Move() чтобы его поведение было актуально. 
 * Добавьте произвольный класс описывающий Человека. 
 * Добавьте скрытое поле типа Транспорт. 
   Создайте метод выводящий информацию о том, как Человек передвигается. Смена типа транспорта возможна исключитеьно через свойство либо метод. 
  В методе Main() класса Program объявите переменнуtого производного класса. 
  Проверьте поведение вашего кода для различных экземпляров производных классов.
 */