using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleGenericite
{
    internal class Operations<T>
    {
        private T _valeur1;
        private T _valeur2;

        public Operations(T valeur1, T valeur2 )
        {
            _valeur1 = valeur1;
            _valeur2 = valeur2;
        }

        public T Valeur1
        {
            get { return _valeur1; }
            set { _valeur1 = value; }
        }

        public T Valeur2
        {
            get { return _valeur2; }
            set { _valeur2 = value; }
        }

        public T Somme()
        {
            dynamic v1 = _valeur1;
            dynamic v2 = _valeur2;
            return v1 + v2;
        }

        public override string ToString()
        {
            return $"Les valeurs sont: {_valeur1} et {_valeur2}";
        }
    }
}
