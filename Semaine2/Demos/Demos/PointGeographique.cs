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

        public double Latitude { get { return _latitude; } }
        public double Longitude { get => _longitude; } //Fait avec Lambda

        //Valeur d'égalité
        public override bool Equals(object? obj)
        {
            try
            {
                PointGeographique p = obj as PointGeographique;
                return(_latitude == p.Latitude && _longitude == p.Longitude);
            }
            catch
            {
                return false;
            }
        }

        //Surcharge du + 
        public static PointGeographique operator +(PointGeographique p1, PointGeographique p2)
        {
            return new PointGeographique(p1._latitude + p2.Latitude, p1._longitude + p2.Longitude);
        }


        //To String
        public override string ToString()
        {
            return $"La latitude est {_latitude} et la longitude est {_longitude}";
        }

    }
}
