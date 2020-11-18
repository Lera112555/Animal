using System;
using System.Collections.Generic;
using System.Text;

namespace интерфейсы
{
    interface IFlying
    {
        public void Walk()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}
