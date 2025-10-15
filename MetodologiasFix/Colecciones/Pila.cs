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
    public class Pila : IColeccionable, IIterable, IOrdenable //Ejercicio 9 (Práctica 5) Modifique las clases Pila y Cola para que implementen la interfaz IOrdenable
    {
        List<MiComparable> pila;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;
        public Pila()
        {
            pila = new List<MiComparable>();
        }

        public int cuantos()
        {
            return pila.Count;
        }

        public MiComparable minimo()
        {
            MiComparable devolver = pila[0];
            for (int i = 0; i < cuantos(); i++)
            {
                if (pila[i].SosMenor(devolver))
                {
                    devolver = pila[i];
                }
            }
            return devolver;
        }

        public MiComparable maximo()
        {
            MiComparable devolver = pila[0];
            for (int c = 0; c < cuantos(); c++)
            {
                if (pila[c].SosMayor(devolver))
                {
                    devolver = pila[c];
                }
            }
            return devolver;
        }

        public void agregar(MiComparable i)
        {
            pila.Add(i);
            if (pila.Count == 1 && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(i);
            }
            if (pila.Count == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public bool contiene(MiComparable i)
        {
            bool cont = false;
            for (int c = 1; c < cuantos(); c++)
            {
                if (pila[c].SosIgual(i))
                {
                    cont = true;
                }
            }
            return cont;
        }
        //Metodos de pila
        public void Apilar(MiComparable i)
        {
            pila.Add(i);
        }

        public MiComparable Desapilar()
        {
            if (cuantos() == 0) return null;
            MiComparable elem = pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return elem;
        }

        public MiComparable Tope()
        {
            if (cuantos() == 0) return null;
            return pila[pila.Count - 1];
        }

        public IIterador crearIterador()
        {
            IIterador i = new IteradorPila(pila);
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
