using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Objetos
{
    public interface IComparable
    {
        bool SosIgual(IComparable i);

        bool SosMenor(IComparable i);

        bool SosMayor(IComparable i);
    }
}
