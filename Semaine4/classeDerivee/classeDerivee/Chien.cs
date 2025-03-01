using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeDerivee
{
    internal class Chien: Animal
    {
        new public  string Crie()
        {
            return "Le chien jappe";
        }
    }
}
