﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora.Domain
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, int year, DateTime dateAdded,  double kilometers)
            : base(brand, model, year, dateAdded, kilometers)
        {
        }


    }
}
