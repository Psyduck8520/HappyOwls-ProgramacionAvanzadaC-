﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Randoms
    {

        private double _number;
        public  double Number
        {
            get => _number;
        }
        public Randoms()
        {
            _number = new Random().NextDouble(); // inicializamos la fecha y hora actual
        }

        

    }
}
