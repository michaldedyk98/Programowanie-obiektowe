using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Car
    {
        private static int carCount = 0;
        private string model;
        private string brand;
        private int doorCount, engineVolume;
        private double averageGasConsumption;

        public static int CarCount { get => carCount; set => carCount = value; }
        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public int DoorCount { get => doorCount; set => doorCount = value; }
        public int EngineVolume { get => engineVolume; set => engineVolume = value; }
        public double AverageGasConsumption { get => averageGasConsumption; set => averageGasConsumption = value; }

        public Car(string model, string brand, int doorCount, int engineVolume, double averageGasConsumption)
        {
            this.model = model;
            this.brand = brand;
            this.doorCount = doorCount;
            this.engineVolume = engineVolume;
            this.averageGasConsumption = averageGasConsumption;

            carCount++;
        }

        public Car()
        {
            model = brand = "None";
            doorCount = engineVolume = 0;
            averageGasConsumption = 0.0;

            carCount++;
        }

        ~Car() { carCount--; }

        private double calculateGasConsumption(double len) { return (len * averageGasConsumption) / 100.0; }
      
        public double calculateTripCost(double len, double gasPrice) { return calculateGasConsumption(len) * gasPrice; }

        public override string ToString()
        {
            return $"Car model: {model} brand: {brand} door count: {doorCount} engine volume: {engineVolume} average gas consumption: {averageGasConsumption}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public static void PrintCarCount() { Console.WriteLine($"Car count: {carCount}"); }

    }
}
