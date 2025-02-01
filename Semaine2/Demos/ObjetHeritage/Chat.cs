using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetHeritage
{
    internal class Chat : Animal
    {
        public Chat(string nom) : base(nom)
        {
        }

        public override string Crier()
        {
            return "Miaou!";
        }
    }
}
