﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface
{
    interface BasicCalculator
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Multiplication(int x, int y);
        double Division(int x, int y);
    }
}
