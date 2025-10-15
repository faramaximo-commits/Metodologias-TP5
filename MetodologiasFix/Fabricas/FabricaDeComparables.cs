using MetodologiasFix.Objetos;
using MetodologiasFix.Otros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Fabricas
{
    public abstract class FabricaDeComparables
    {
        //--Ejercicio 4 (Práctica 3)(Clase abstracta FabricaDeComparables, métodos estáticos crearAleatorio(opcion) y crearPorTeclado(opcion))
        public static MiComparable crearAleatorio(int opcion)
        {
            

            MiComparable c = null;

            switch (opcion)
            {
                case 1:
                    int valor = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10000000);
                    c = new Numero(valor);
                    break;
                case 2:
                    //Alumnos Normales

                    StudentsFactory factory = new StudentsFactory();
                    factory.setCrearEstudiosos(false);
                    c = factory.crearAleatorio();
                    break;
                case 3:
                    string nombreProfesor = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dniProfesor = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int antiguedad = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 100);
                    c = new Profesor(nombreProfesor, dniProfesor, antiguedad);
                    break;
                case 4:
                    //Alumnos Muy Estudiosos

                    StudentsFactory factory1 = new StudentsFactory();
                    factory1.setCrearEstudiosos(true);
                    c = factory1.crearAleatorio();
                    break;

                default:
                    break;
            }
            return c;
            
        }

        public static MiComparable crearPorTeclado(int opcion)
        {
            MiComparable c = null;
            switch (opcion)
            {
                case 1:
                    FabricaDeNumeros fNumero = new FabricaDeNumeros();
                    c = fNumero.crearPorTeclado();
                    break;
                case 2:
                    FabricaDeAlumnosNormales fAlumnos = new FabricaDeAlumnosNormales();
                    c = fAlumnos.crearPorTeclado();
                    break;
                case 3:
                    FabricaDeProfesores fProfesores = new FabricaDeProfesores();
                    c = fProfesores.crearPorTeclado();
                    break;
                default:
                    break;
            }
            return c;
        }

        public abstract MiComparable crearAleatorio();
        public abstract MiComparable crearPorTeclado();



    }
}
