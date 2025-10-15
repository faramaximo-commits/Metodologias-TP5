using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public class DecoradorConLegajo : DecoradorAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase Decorador de legajo
    {
        public DecoradorConLegajo(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            return $"{alumno.mostrarCalificacion()} ({alumno.getLegajo()})";
        }
    }
}
