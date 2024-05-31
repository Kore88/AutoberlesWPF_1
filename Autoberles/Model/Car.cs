using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoberles.Model
{
    internal class Car
    {
        [Key]
        int carID;
        string brand;
        string type;
        int year;
        int price;

        public Car(int carID, string brand, string type, int year, int price)
        {
            this.carID = carID;
            this.brand = brand;
            this.type = type;
            this.year = year;
            this.price = price;
        }

        public int CarID { get => carID; set => carID = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }
        public int Price { get => price; set => price = value; }


    }
}
