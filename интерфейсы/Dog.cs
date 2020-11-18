using System;
using System.Collections.Generic;
using System.Text;

namespace интерфейсы
{
    class Dog : Animal, IWalking
    {
        
        public string Name
        { get; set; }
        public Dog(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public override string ToString() => Name;
    }
}
       