using MetodologiasFix.Adapter;
using MetodologiasFix.ClasesAula;
using MetodologiasFix.Colecciones;
using MetodologiasFix.Fabricas;
using MetodologiasFix.Iteradores;
using MetodologiasFix.Objetos;
using MetodologiasFix.Otros;
using System;
using StudentMDPI = MetodologiasFix.MDPI.CodigoCatedra.Student;
using TeacherMDPI = MetodologiasFix.MDPI.CodigoCatedra.Teacher;
using MiComparable = MetodologiasFix.Objetos.IComparable;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 2 (Práctica 5) Ejectuar el main del ejercicio 8 de la práctica 4 para compromobar el correcto funcionamiento, de hecho funciona bien el mismo código, solamente que si hago el mismo codigo solamente trae Alumnos Normales, porque modifiqué la fábrica de Students para que reciba un flag = true/false y así crear alumnos normales o muy estudiosos

        //TeacherMDPI teacher = new TeacherMDPI();
        //StudentsFactory factory = new StudentsFactory();
        //for (int i = 0; i < 20; i++)
        //{
        //    if (i < 10)
        //    {
        //        factory.setCrearEstudiosos(false); // va a crear alumnos normales
        //        AlumnoAdapter alumno = (AlumnoAdapter)factory.crearAleatorio();
        //        teacher.goToClass(alumno);
        //    }
        //    else
        //    {
        //        factory.setCrearEstudiosos(true);
        //        AlumnoAdapter alumno = (AlumnoAdapter)factory.crearAleatorio();
        //        teacher.goToClass(alumno);
        //    }
        //}
        //teacher.teachingAClass();



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Ejercicio 10(Práctica 5) Implemente una funcino Main que instancie un AUla y una instancia de cada una de las 3 ordenes con el aula como receptor, luego instancie una Pila / Cola y seteele las 3 ordenes, luego llame a la funcion llenar() para agregar 20 Instancias de Alumno Noraml y 20 de Alumno Muy Estudioso.
        //Lo hice con los dos para probar que funcionan igual je, pero dejo el de Cola para que sea más claro

        Cola cola = new Cola();
        Funciones funciones = new Funciones();
        Aula aula = new Aula();
        OrdenInicio ordenInicio = new OrdenInicio(aula);
        OrdenLlegaAlumno ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
        OrdenAulaLlena ordenAulaLlena = new OrdenAulaLlena(aula);
        cola.setOrdenInicio(ordenInicio);
        cola.setOrdenLlegaAlumno(ordenLlegaAlumno);
        cola.setOrdenAulaLlena(ordenAulaLlena);


        funciones.llenar(cola, 2); // alumnos normales
        funciones.llenar(cola, 4); // alumnos muy estudiosos

        
        IIterador iter = cola.crearIterador();

        int index = 0;
        for (iter.primero(); !iter.fin(); iter.siguiente())
        {
            MiComparable alumno = iter.actual();
            index++;

            if (index == 1)
                ordenInicio.ejecutar();

            ordenLlegaAlumno.ejecutar(alumno);

            if (index == 40)
                ordenAulaLlena.ejecutar();
        }

        Console.WriteLine("Fin de la clase");

    }
}

