using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeDerivee
{
    internal abstract class Animal
    {
        public virtual string Crie()
        {
            return "Son générique";
        }
    }
}
