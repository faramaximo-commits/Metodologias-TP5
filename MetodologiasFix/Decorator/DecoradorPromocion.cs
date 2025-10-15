using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public class DecoradorPromocion : DecoradorAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase Decorador de promoción
    {
        public DecoradorPromocion(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            string estado;
            if (alumno.getCalificacion() >= 7)
            {
                estado = "(PROMOCIONADO)";
            }
            else if (alumno.getCalificacion() >= 4)
            {
                estado = "(APROBADO)";
            }
            else
            {
                estado = "(DESAPROBADO)";
            }

            return $"{alumno.mostrarCalificacion()} {estado}";
        }
    }
}
