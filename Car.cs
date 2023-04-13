using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class Budget_Car
    {
        private string _mark;
        private string _name;
        private int _price;
        private string _fuel;
        private double _engine_volume;
        
        
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public double EngineVolume
        {
            get { return _engine_volume; }
            set { _engine_volume = value; }
        }

        public Budget_Car()
        {
            _mark = "Deawo";
            _name = "Lanos";
            _price = 5000;
            _fuel = "gas";
            _engine_volume = 1.5;
        }

        public void Show()
        {
            Console.WriteLine($"Mark: {_mark}, Name: {_name}, Price: {_price}, Fuel: {_fuel}, Engine Volume: {_engine_volume}");
        }
    }

    internal class Medium_Car
    {
        private string _mark;
        private string _name;
        private int _price;
        private string _fuel;
        private double _engine_volume;


        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public double EngineVolume
        {
            get { return _engine_volume; }
            set { _engine_volume = value; }
        }

        public Medium_Car()
        {
            _mark = "Toyota";
            _name = "Camry";
            _price = 20000;
            _fuel = "Dizel";
            _engine_volume = 1.5;
        }

        public void Show()
        {
            Console.WriteLine($"Mark: {_mark}, Name: {_name}, Price: {_price}, Fuel: {_fuel}, Engine Volume: {_engine_volume}");
        }
    }
    internal class Luxury_Car
    {
        private string _mark;
        private string _name;
        private int _price;
        private string _fuel;
        private double _engine_volume;


        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public double EngineVolume
        {
            get { return _engine_volume; }
            set { _engine_volume = value; }
        }

        public Luxury_Car()
        {
            _mark = "Buggati";
            _name = "Chiron";
            _price = 2500000;
            _fuel = "Benzin";
            _engine_volume = 8;
        }

        public void Show()
        {
            Console.WriteLine($"Mark: {_mark}, Name: {_name}, Price: {_price}, Fuel: {_fuel}, Engine Volume: {_engine_volume}");
        }
    }

}
