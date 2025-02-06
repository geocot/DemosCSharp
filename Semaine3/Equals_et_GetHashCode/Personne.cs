using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_et_GetHashCode
{
    internal class Personne
    {
        private string _nom;
        private string _prenom;

        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        public override bool Equals(object? obj)
        {
            return obj is Personne personne &&
                   _nom == personne._nom &&
                   _prenom == personne._prenom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_nom, _prenom);
        }
    }
}
