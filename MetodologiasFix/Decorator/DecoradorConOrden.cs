using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public class DecoradorConOrden : DecoradorAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase Decorador con orden 
    {
        private int orden;

        public DecoradorConOrden(IAlumno a, int o) : base(a)
        {
            this.orden = o;
        }

        public override string mostrarCalificacion()
        {
            return $"{this.orden}) {this.alumno.mostrarCalificacion()}";
        }
    }
}
