using MetodologiasFix.Adapter;
using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherMDPI = MetodologiasFix.MDPI.CodigoCatedra.Teacher;
using StudentMDPI = MetodologiasFix.MDPI.CodigoCatedra.Student;
using MetodologiasFix.Otros;

namespace MetodologiasFix.ClasesAula
{
    public class Aula //Ejercicio 3 (Práctica 5) Implementar la clase Aula 
    {
        private TeacherMDPI teacher;

        public void comenzar()
        {
            this.teacher = new TeacherMDPI();
            Console.WriteLine("¡Comienza la clase!");
        }

        public void nuevoAlumno(IAlumno a)
        {
            if (teacher == null)
            {
                Console.WriteLine("La clase no ha comenzado aún.");
                return;
            }
            AlumnoAdapter adaptado = new AlumnoAdapter(a);
            Funciones funciones = new Funciones();
                

            teacher.goToClass(adaptado);
        }

        public void claseLista()
        {
            if (teacher == null)
            {
                Console.WriteLine("La clase no ha comenzado aún.");
                return;
            }
            Console.WriteLine("La clase está llena. Mostrando resultados....");
            teacher.teachingAClass();
        }
    }
}

