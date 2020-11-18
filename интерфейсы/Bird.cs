using System;
using System.Collections.Generic;
using System.Text;

namespace интерфейсы
{
    class Bird : Animal, IFlying
    {
        public string Name
        { get; set; }
        public Bird(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public override string ToString() => Name;

       
    }
}
