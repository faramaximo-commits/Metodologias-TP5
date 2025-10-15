using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.ClasesAula
{
    public interface IOrdenable //Ejercicio 8 (Práctica 5) Crear la interfaz IOrdenable que permita setear las órdenes en el aula
    {
        void setOrdenInicio(IOrdenEnAula1 orden);

        void setOrdenLlegaAlumno(IOrdenEnAula2 orden);

        void setOrdenAulaLlena(IOrdenEnAula1 orden);
    }
}
