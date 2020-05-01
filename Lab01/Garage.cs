using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Garage
    {
        private Car[] cars;
        private int carsInGarage = 0;
        private string address;
        private int capacity;

        public int CarsInGarage { get => carsInGarage; set => carsInGarage = value; }
        public string Address { get => address; set => address = value; }
        //public Car this[int i] { get => cars[i]; }
        public int Capacity {
            get { return capacity; }
            set { capacity = value; cars = new Car[capacity]; }
        }

        public Garage(string address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }

        public Garage()
        {
            Address = "None";
            CarsInGarage = Capacity = 0;
        }

        public void pushCar(Car car)
        {
            if (CarsInGarage >= Capacity)
            {
                Console.WriteLine($"There is no space in the garage {address}.");

                return;
            }

            cars[carsInGarage++] = car;
        }

        public Car popCar()
        {
            if (CarsInGarage <= 0)
            {
                Console.WriteLine($"There are no cars in the garage {address}.");
                return null;
            }

            cars[--carsInGarage] = null;

            return cars[CarsInGarage];
        }

        public override string ToString()
        {
            string str = $"Cars in garage: \r\n";

            foreach (Car car in cars)
            {
                if (car != null)
                    str += car + "\r\n";
            }

            return str;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
