using System;
using System.Collections.Generic;
using System.Text;

namespace WorkWithClass
{

   

    internal class Person  //Добавьте произвольный класс описывающий Человека. 
    {
        private Transport _transport; //Добавьте скрытое поле типа Транспорт. 

        public void Move()   //Создайте метод выводящий информацию о том, как Человек передвигается.
        {
                _transport.Move();
            
        }

        public void ChangeTransport(Transport transport)
        {

            _transport = transport ?? throw new ArgumentNullException(); 
        }
    }
}
