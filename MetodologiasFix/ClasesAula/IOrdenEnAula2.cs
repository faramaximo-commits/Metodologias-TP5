using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.ClasesAula
{
    public interface IOrdenEnAula2 // Ejercicio 6 (Práctica 5) Implementar la interfaz OrdenEnAula2 con método ejecutar(comparable) 
    {
        void ejecutar(MiComparable comparable);
    }
}
