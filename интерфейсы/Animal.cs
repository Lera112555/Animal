using System;
using System.Collections.Generic;
using System.Text;

namespace интерфейсы
{
    class Animal
    {  

        public DateTime BirthDay { get; set; }
        public int Age()
        {
            return (int)DateTime.Now.Subtract(BirthDay).TotalDays / 365;
        }


    } 
}
