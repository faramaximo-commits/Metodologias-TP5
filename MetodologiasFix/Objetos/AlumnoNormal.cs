using MetodologiasFix.Estrategias;
using MetodologiasFix.Otros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Objetos
{
    public class AlumnoNormal : Alumno //Cree la clase alumno normal porque ahora la clase Alumno es abstracta (ya que debe actuar de clase Padre)
    {
        public AlumnoNormal(string n, int d, int l, int p, int c, IEstrategiaComparacion e) : base(n, d, l, p, c, e)
        {
        }
        public override int responderPregunta(int pregunta)
        {
            return GeneradorDeDatos.ObtenerEnteroAleatorio(1, 3);
        }
    }
}
