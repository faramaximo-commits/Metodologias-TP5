using MetodologiasFix.Adapter;
using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.ClasesAula
{
    public class OrdenLlegaAlumno : IOrdenEnAula2 //Ejercicio 5 (Práctica 5) Usar el patron Command que implemente 1 orden con la interfaz IOrdenEnAula2 (llegaAlumno)
    {
        private Aula aula;
        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }
        public void ejecutar(MiComparable comparable)
        {
            if (comparable is IAlumno alumno)
            {
                this.aula.nuevoAlumno(alumno);
            }
            else if(comparable is AlumnoAdapter adapter){
                this.aula.nuevoAlumno(adapter.getAlumno());
            }
            else { Console.WriteLine("El objeto recibido no es un alumno válido"); }
        }
    }
}
