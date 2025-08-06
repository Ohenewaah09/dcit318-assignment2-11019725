using System;

namespace InterfaceApplication
{
    public interface IMovable
    {
               void Move();
    }
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();
            myCar.Move();
            myBicycle.Move();
        }
    }
}
