using System;
using System.Collections.Generic;
using System.Text;

namespace интерфейсы
{
    interface ISwimming
    {
        public void Walk()
        {
            Console.WriteLine(this + " плывёт в новую точку");
        }
    }
}
