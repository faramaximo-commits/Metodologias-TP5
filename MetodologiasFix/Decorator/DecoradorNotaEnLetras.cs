using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public class DecoradorNotaEnLetras : DecoradorAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase Decorador de nota en letras
    {
        public DecoradorNotaEnLetras(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            return $"{alumno.mostrarCalificacion()} ({ConvertirANotas(alumno.getCalificacion())})";
        }

        string ConvertirANotas(int calificacion)
        {
            switch (calificacion)
            {
                case 0: return "Cero";
                case 1: return "Uno";
                case 2: return "Dos";
                case 3: return "Tres";
                case 4: return "Cuatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Siete";
                case 8: return "Ocho";
                case 9: return "Nueve";
                case 10: return "Diez";
                default: return "Calificación inválida";
            }
        }
    }
}
