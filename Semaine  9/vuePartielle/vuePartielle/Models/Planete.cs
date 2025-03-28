
namespace vuePartielle.Models
{
    public class Planete
    {
        private string _pathImage;
        private int _rang;
        private string _nom;
        private double _orbiteJours;
        private double _UA;
        private double _rayonEquatorialKm;
        private double _rotationJourTerre;

        public Planete(string pathImage, int rang, string nom, double orbiteJour, double uA, double rayonEquatorialKm, double rotationJourTerre)
        {
            _pathImage = pathImage;
            _rang = rang;
            _nom = nom;
            _orbiteJours = orbiteJour;
            _UA = uA;
            _rayonEquatorialKm = rayonEquatorialKm;
            _rotationJourTerre = rotationJourTerre;
        }

        public string PathImage { get => _pathImage; }
        public int Rang { get => _rang; }
        public string Nom { get => _nom; }
        public double OrbiteJours { get => _orbiteJours; }
        public double UA { get => _UA; }
        public double RayonEquatorialKm { get => _rayonEquatorialKm; }
        public double RotationJourTerre { get => _rotationJourTerre; }



    }
}
