﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class Perfume
    {

        private string brand;
        private double price;

        public Perfume(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }
        public double Price
        {
            get { return price; }
            set { price = value; }

        }
        public override string ToString()
        {
            return "Brand: " + brand + ", price: " + price;
        }
    }
}