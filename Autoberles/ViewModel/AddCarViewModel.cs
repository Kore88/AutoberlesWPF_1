using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoberles.ViewModel
{
    internal class AddCarViewModel
    {
        int id;
        string brand;
        string type;
        int year;
        int price;

        public AddCarViewModel()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }
        public int Price { get => price; set => price = value; }

        public AddCarViewModel(int id, string brand, string type, int year, int price)
        {
            this.id = id;
            this.brand = brand;
            this.type = type;
            this.year = year;
            this.price = price;
        }

    }
}
