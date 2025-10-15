using MetodologiasFix.ClasesAula;
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
    public class Cola : IColeccionable, IIterable, IOrdenable //Ejercicio 9 (Práctica 5) Modifique las clases Pila y Cola para que implementen la interfaz IOrdenable
    {
        List<MiComparable> cola;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;
        public Cola()
        {
            cola = new List<MiComparable>();
        }

        public int cuantos()
        {
            return cola.Count;
        }

        public MiComparable minimo()
        {
            MiComparable devolver = cola[0];
            for (int i = 0; i < cuantos(); i++)
            {
                if (cola[i].SosMenor(devolver))
                {
                    devolver = cola[i];
                }
            }
            return devolver;
        }

        public MiComparable maximo()
        {
            MiComparable devolver = cola[0];
            for (int c = 0; c < cuantos(); c++)
            {
                if (cola[c].SosMayor(devolver))
                {
                    devolver = cola[c];
                }
            }
            return devolver;
        }

        public void agregar(MiComparable i)
        {
            cola.Add(i);
            
        }

        public bool contiene(MiComparable i)
        {
            bool cont = false;
            for (int c = 1; c < cuantos(); c++)
            {
                if (cola[c].SosIgual(i))
                {
                    cont = true;
                }
            }
            return cont;
        }
        //Metodos de Cola
        public void encolar(MiComparable i)
        {
            cola.Add(i);
        }

        public MiComparable desencolar()
        {
            if (cuantos() == 0) return null;
            MiComparable elem = cola[0];
            cola.RemoveAt(0);
            return elem;
        }

        public MiComparable primero()
        {
            if (cuantos() == 0) return null;
            return cola[0];
        }

        public IIterador crearIterador()
        {
            IIterador i = new IteradorCola(cola);
            return i;
        }

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
