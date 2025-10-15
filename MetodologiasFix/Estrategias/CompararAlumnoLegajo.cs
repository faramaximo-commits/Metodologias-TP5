using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Estrategias
{
    internal class CompararAlumnoLegajo : IEstrategiaComparacion
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getLegajo() == ((IAlumno)b).getLegajo();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getLegajo() < ((IAlumno)b).getLegajo();
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getLegajo() > ((IAlumno)b).getLegajo();
        }

        public override string ToString()
        {
            return "Comparacion por LEGAJO ";
        }
    }
}
