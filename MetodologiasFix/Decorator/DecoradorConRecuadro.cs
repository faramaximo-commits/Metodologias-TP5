using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public class DecoradorConRecuadro : DecoradorAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase Decorador con recuadro
    {
        public DecoradorConRecuadro(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            string calificacion = alumno.mostrarCalificacion();
            string borde = new string('*', calificacion.Length + 4);
            return $"{borde}\n* {calificacion} *\n{borde}";
        }
    }
}
