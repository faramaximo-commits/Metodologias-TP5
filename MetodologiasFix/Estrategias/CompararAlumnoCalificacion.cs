using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Estrategias
{
    internal class CompararAlumnoCalificacion : IEstrategiaComparacion //Ejercicio 5 (Práctica 4) Implemente la estrategia CompararAlumnoCalificacion (opcional)
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getCalificacion() == ((IAlumno)b).getCalificacion();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getCalificacion() < ((IAlumno)b).getCalificacion();
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((IAlumno)a).getCalificacion() > ((IAlumno)b).getCalificacion();
        }

        public override string ToString()
        {
            return "Comparacion por Calificacion ";
        }
    }
}
