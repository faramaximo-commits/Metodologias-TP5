using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.ClasesAula
{
    public class OrdenAulaLlena : IOrdenEnAula1 //Ejercicio 5 (Práctica 5) Usar el patron Command que implemente 2 ordenes con la interfaz IOrdenEnAula1 (inicio y llena)
    {
        private Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}
