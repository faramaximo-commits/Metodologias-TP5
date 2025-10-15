using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Objetos
{
    public interface IAlumno : MiComparable
    {
        string getNombre();
        int getDni();
        int getLegajo();
        int getPromedio();
        int getCalificacion();
        void setCalificacion(int calif);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();



    }
}
