using MetodologiasFix.Iteradores;
using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Colecciones
{
    public class Conjunto : IColeccionable, IIterable
    {
        private List<MiComparable> elems;

        public Conjunto()
        {
            elems = new List<MiComparable>();
        }

        public int cuantos()
        {
            return elems.Count;
        }

        public void agregar(MiComparable elem)
        {
            elems.Add(elem);
        }

        public bool contiene(MiComparable elem)
        {
            return elems.Contains(elem);

        }

        public MiComparable minimo()
        {
            throw new NotImplementedException();
        }

        public MiComparable maximo()
        {
            throw new NotImplementedException();
        }

        public IIterador crearIterador()
        {
            IteradorConjunto i = new IteradorConjunto(elems);
            return i;
        }
    }
}
