using MetodologiasFix.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Objetos
{
    public class AlumnoMuyEstudioso : Alumno //Ejercicio 2 (Práctica 4) Crear la clase AlumnoMuyEstudioso que herede de Alumno y que implemente el método responderPregunta devolviendo siempre la respuesta correcta (el módulo de la pregunta por 3)
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p, int c, IEstrategiaComparacion e) : base(n, d, l, p, c, e)
        {
        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
