using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstraites
{
    abstract class Animal
    {
        public abstract string Crier();

        public string Dormir()
        {
            return "Zzzzzz";
        }

    }
}
