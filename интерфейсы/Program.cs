using System;

namespace интерфейсы
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Чип", new DateTime(2009, 9, 9));
            Console.WriteLine($" Возраст собаки: {dog.Age()} лет");
            ((IWalking)dog).Walk();

            Fish fish = new Fish("Дори", new DateTime(2008, 8, 8));
            Console.WriteLine($" Возраст рыбы: {fish.Age()} лет");
            ((ISwimming)fish).Walk();

            Bird bird = new Bird("Кеша", new DateTime(2007, 7, 7));
            Console.WriteLine($" Возраст птицы: {bird.Age()} лет");
            ((IFlying)bird).Walk();
        }
           
    }
}
