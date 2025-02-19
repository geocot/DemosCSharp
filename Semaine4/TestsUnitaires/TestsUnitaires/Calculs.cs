using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitaires
{
    internal class Calculs
    {
        public double AireRectangle(double largeur, double longueur)
        {
            return largeur + longueur;
        }

        public double AireCercle(double rayon)
        {
            return Math.PI * Math.Pow(rayon, 2);
        }

       
    }
}
