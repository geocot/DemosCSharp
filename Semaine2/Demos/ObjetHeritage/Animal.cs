using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetHeritage
{
    internal class Animal
    {
        private string _nom;
        public Animal(string nom)
        {
            _nom = nom;
        }

        public string Nom { get => _nom; set => _nom = value; }

        public virtual string Crier()
        {
            return "Cri générique";
        }

    }
}
