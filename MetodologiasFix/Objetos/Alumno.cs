using MetodologiasFix.Estrategias;
using MetodologiasFix.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MetodologiasFix.Objetos
{
    public abstract class Alumno : Persona, IObservador, IAlumno

    {
        protected int legajo, promedio, calificacion;
        //Atributo agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
        protected IEstrategiaComparacion estrategia;


        public Alumno(string n, int d, int l, int p, int c, IEstrategiaComparacion e) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = e;
            this.calificacion = c;
        }

        public int getLegajo() { return this.legajo; }

        public int getPromedio() { return this.promedio; }

        public int getCalificacion() { return this.calificacion; } //Método agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
        public void setCalificacion(int calif)
        {
            this.calificacion = calif;
        }

        public IEstrategiaComparacion getEstrategia() { return this.estrategia; }

        public void setEstrategia(IEstrategiaComparacion e)
        {
            this.estrategia = e;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}, DNI: {this.dni}, Legajo: {this.legajo}, Promedio: {this.promedio} Estrategia empleada: {this.estrategia}";
        }



        public override bool SosIgual(IComparable i)
        {
            return this.estrategia.sonIguales(this, (IAlumno)i);
        }

        public override bool SosMenor(IComparable i)
        {
            return this.estrategia.esMasPequeño(this, (IAlumno)i);

        }

        public override bool SosMayor(IComparable i)
        {
            return this.estrategia.esMasGrande(this, (IAlumno)i);
        }


        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención...");
        }

        public void distraerse()
        {
            Console.WriteLine("Tirando aviones de papel...");
        }

        public void Actualizar(IObservado o)
        {
            Profesor profesor = (Profesor)o;
            if (profesor.getEstado())
            {
                prestarAtencion();
            }
            else
            {
                distraerse();
            }
        }

        public abstract int responderPregunta(int pregunta); //Método agregado para el Ejercicio 1 (Práctica 4) int responderPregunta(int pregunta)
        //Además hice que sea abstracto ya que la forma en que responden los alumnos normales y los muy estudiosos es diferente

        public string mostrarCalificacion() //Método agregado para el Ejercicio 1 (Práctica 4) string mostrarCalificacion()
        {
            return $"{nombre}                 {calificacion}";
        }


    }
}
