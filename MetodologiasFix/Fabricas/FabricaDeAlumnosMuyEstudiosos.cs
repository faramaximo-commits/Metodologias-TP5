using MetodologiasFix.Estrategias;
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
    internal class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables //Ya que el ejercicio 1 pedía crear la clase AlumnoMuyEstudioso, creé esta nueva fábrica concreta para poder instanciar objetos de dicha clase
    {
        public override MiComparable crearAleatorio()
        {
            string n = GeneradorDeDatos.ObtenerNombreAleatorio();
            int d = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
            int l = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10000);
            int p = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10);
            int c = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10); //Método agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
            IEstrategiaComparacion e = new CompararAlumnoCalificacion(); //Ahora hago que solamente se creen Alumnos Muy Estudiosos con la estrategia de comparación por calificación
            MiComparable comparable = new AlumnoMuyEstudioso(n, d, l, p, c, e);
            return comparable;
        }

        public override MiComparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            string n = lector.stringPorTeclado();
            int d = lector.numeroPorTeclado();
            int l = lector.numeroPorTeclado();
            int p = lector.numeroPorTeclado();
            int c = lector.numeroPorTeclado(); //Método agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
            IEstrategiaComparacion e = lector.estrategiaPorTeclado();
            MiComparable comparable = new AlumnoMuyEstudioso(n, d, l, p, c, e);
            return comparable;
        }
    }
}
