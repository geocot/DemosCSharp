using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class PointGeographique
    {
        private double _latitude;
        private double _longitude;
        public PointGeographique(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude; 
        }

        //Accesseurs
        public double Latitude { get { return _latitude; }
        }

        public double Longitude { get => _longitude;} //Fait en lambda

        //Valeur d'égalité
        public override bool Equals(object? o)
        {
            try
            {
               PointGeographique pointGeographique = o as PointGeographique;
                return (_latitude == pointGeographique.Latitude && _longitude == pointGeographique.Longitude);
            }
            catch
            {
                return false;
            }
 
        }

        //Surcharge de l'addition
        public static PointGeographique operator +(PointGeographique p1, PointGeographique p2)
        {
            return new PointGeographique(p1.Latitude + p2.Latitude, p1.Longitude + p2.Longitude);
        }


        //To String
        public override string ToString() 
        {
            return $"La latitude est {_latitude} et la longitude est {_longitude}";
        }


    
    }
}
