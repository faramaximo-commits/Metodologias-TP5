using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Estrategias
{
    internal class CompararAlumnoNombre : IEstrategiaComparacion
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getNombre() == ((IAlumno)b).getNombre();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getNombre().Length < ((IAlumno)b).getNombre().Length;
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getNombre().Length > ((IAlumno)b).getNombre().Length;
        }

        public override string ToString()
        {
            return "Comparacion por NOMBRE ";
        }
    }
}
