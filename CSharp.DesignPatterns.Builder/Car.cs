using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns.Builder
{
    // Product Class
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Gear { get; set; } // oturucu // skorus
        public override string ToString()
        {
            return $"{Brand} brand car is produced in {Model} model with {Gear} gears in {KM} kilometers.";
        }
    }

    //Builder
    abstract class ICarBuilder
    {
        protected Car car;
        public Car Car
        {
            get { return car; }
        }

        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetGear();
    }

    //ConcreteBuilder Class
    class OpelConcreteBuilder : ICarBuilder
    {
        public OpelConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 100;
        public override void SetBrand() => car.Brand = "Opel";
        public override void SetModel() => car.Model = "Astra";
        public override void SetGear() => car.Gear = true;
    }
    //ConcreteBuilder Class
    class ToyotaConcreteBuilder : ICarBuilder
    {
        public ToyotaConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 150;
        public override void SetBrand() => car.Brand = "Toyota";
        public override void SetModel() => car.Model = "Corolla";
        public override void SetGear() => car.Gear = true;
    }
    //ConcreteBuilder Class
    class BMWConcreteBuilder : ICarBuilder
    {
        public BMWConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 25;
        public override void SetBrand() => car.Brand = "BMW";
        public override void SetModel() => car.Model = "X Bilmem Kaç";
        public override void SetGear() => car.Gear = true;
    }

    //Director Class
    class ProduceCars
    {
        public void Produce(ICarBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetBrand();
            Araba.SetModel();
            Araba.SetGear();
        }
    }
}
