using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszteles01
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        //Az adó mértéke 10 évnél fiatalabb autó esetén 20000 Ft, 10 és 30 év között 10000 Ft, 30 év fölött 0 Ft
        public int Tax { get {if (DateTime.Today.Year - Year < 10)
                                return 20000;
                            else if (DateTime.Today.Year - Year <= 30)
                                return 10000;
                            else
                                return 0;
                    } }
        public Car (string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Tax} Ft";
        }
    }
}
