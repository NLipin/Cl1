﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Class1
    {
        public static double[] Mathing(int a, int b, int c, out string error)
        {

            error = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        error = "R";
                        return new double[0];
                    }
                    else
                    {
                        error = "Нет корней";
                        return new double[0];
                    }
                }
                else
                {
                    return new double[] {/*(double)*/-b / c };  
                }
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D > 0) return new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
                else if (Math.Abs(D) < 0.0000000001) return new double[] { -b / (2 * a) };
                else
                {
                    error = "Нет корней";
                    return new double[0];
                
                  }
            }
        }
    }
}
