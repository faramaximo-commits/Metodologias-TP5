using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Decorator
{
    public abstract class DecoradorAlumno : IAlumno //Ejercicio 6 (Práctica 4) Implemente el patrón Decorator creando la clase DecoradorAlumno
    {
        protected IAlumno alumno;
        public DecoradorAlumno(IAlumno a)
        {
            this.alumno = a;
        }
        public virtual int getCalificacion()
        {
            return this.alumno.getCalificacion();
        }

        public virtual int getDni()
        {
            return this.alumno.getDni();
        }

        public virtual int getLegajo()
        {
            return this.alumno.getLegajo();
        }

        public virtual string getNombre()
        {
            return this.alumno.getNombre();
        }

        public virtual int getPromedio()
        {
            return this.alumno.getPromedio();
        }

        public virtual string mostrarCalificacion()
        {
            return this.alumno.mostrarCalificacion();
        }

        public virtual int responderPregunta(int pregunta)
        {
            return this.alumno.responderPregunta(pregunta);
        }

        public virtual void setCalificacion(int calif)
        {
            this.alumno.setCalificacion(calif);
        }

        public bool SosIgual(Objetos.IComparable i)
        {
            return this.alumno.SosIgual(i);
        }

        public bool SosMayor(Objetos.IComparable i)
        {
            return this.alumno.SosMayor(i);
        }

        public bool SosMenor(Objetos.IComparable i)
        {
            return this.alumno.SosMenor(i);
        }
    }
}
