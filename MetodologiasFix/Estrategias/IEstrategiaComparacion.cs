using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Estrategias
{
    public interface IEstrategiaComparacion
    {
        bool sonIguales(MiComparable a, MiComparable b);

        bool esMasPequeño(MiComparable a, MiComparable b);

        bool esMasGrande(MiComparable a, MiComparable b);

    }
}
