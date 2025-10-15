using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Iteradores
{
    public class IteradorConjunto : IIterador
    {
        private List<MiComparable> elementos;
        private int puntero;

        public IteradorConjunto(List<MiComparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }
        public MiComparable actual()
        {
            return elementos[puntero];
        }

        public bool fin()
        {
            return puntero >= elementos.Count;
        }

        public void primero()
        {
            puntero = 0;
        }

        public void siguiente()
        {
            puntero++;
        }
    }
}
