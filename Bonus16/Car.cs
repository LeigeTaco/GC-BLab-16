﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{

    class Car
    {

        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {

            set { make = value;  }
            get { return make; }

        }

        public string Model
        {

            set { model = value; }
            get { return model; }

        }

        public int Year
        {

            set { year = value; }
            get { return year; }

        }

        public double Price
        {

            set { price = value; }
            get { return price; }

        }

        public Car(string make, string model, int year, double price)
        {

            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;

        }

        public Car()
        {

            make = "Dodge";
            model = "Challenger";
            year = 2018;
            price = 27295.00;

        }

    }

}
