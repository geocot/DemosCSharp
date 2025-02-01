using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstraites
{
    internal class Chat : Animal
    {
        private string _nom;
        public Chat(string nom)
        {
            _nom = nom;
        }
        public override string Crier()
        {
            return "Miaou!";
        }
    }
}
