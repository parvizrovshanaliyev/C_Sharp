using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        private double _fuelCapacity;
        private double _currentFuel;
        private double _fuelUsage;
        private double _globalKM;
        private double _localKM;
        private double _maxDistance;

        public Car(double fuelCapacity, double fuelUsage)
        {
            _fuelCapacity = fuelCapacity;
            _fuelUsage = fuelUsage;
            _currentFuel = _fuelCapacity * 0.2;

            CalcMaxDistance();
        }

        public double FuelCapacity => _fuelCapacity;
        public double CurrentFuel => _currentFuel;
        public double FuelUsage => _fuelUsage;
        public double GlobalKM => _globalKM;
        public double LocalKM => _localKM;
        public double MaxDistance => _maxDistance;


        /// <summary>
        /// cari benzinle nece km yol qet edile biler
        /// </summary>
        private void CalcMaxDistance()
        {
            _maxDistance = (_currentFuel / _fuelUsage) * 100;
        }

        private double FindFuelUsageForKm(double km)
        {
            return (_fuelUsage * km) / 100;
        }

        public bool Drive(double km)
        {
            if (km > _maxDistance)
            {
                return false;
            }

            _globalKM += km;
            _localKM += km;
            _currentFuel -= FindFuelUsageForKm(km);
            CalcMaxDistance();
            return true;
        }
    }
}
