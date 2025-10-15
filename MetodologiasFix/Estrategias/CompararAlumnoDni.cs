using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Estrategias
{
    internal class CompararAlumnoDni : IEstrategiaComparacion
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getDni() == ((IAlumno)b).getDni();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getDni() > ((IAlumno)b).getDni();
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getDni() < ((IAlumno)b).getDni();
        }

        public override string ToString()
        {
            return "Comparacion por DNI ";
        }
    }
}
