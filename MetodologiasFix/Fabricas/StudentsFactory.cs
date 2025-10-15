using MetodologiasFix.Adapter;
using MetodologiasFix.Decorator;
using MetodologiasFix.Estrategias;
using MetodologiasFix.Objetos;
using MetodologiasFix.Otros;
using MetodologiasFix.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Fabricas
{
    public class StudentsFactory : FabricaDeComparables //Ejercicio 7 (Práctica 4) Implemente la fábrica concreta StudentsFactory que cree alumnos normales y muy estudiosos decorados y adaptados
    {
        private static int contador = 1;
        private bool esEstudioso; //flag para alternar entre alumnos normales y muy estudiosos

        public void setCrearEstudiosos(bool flag)
        {
            this.esEstudioso = flag;
        }

        public override MiComparable crearAleatorio()
        {
            
            bool esMuyEstudioso = esEstudioso;
            IAlumno proxy = new ProxyAlumno(
                GeneradorDeDatos.ObtenerNombreAleatorio(),
                GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000), //DNI
                GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10000), //Legajo
                GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10), //Promedio
                GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10), //Calificacion
                new CompararAlumnoCalificacion(), //Estrategia
                esMuyEstudioso
                );

            IAlumno decorado = new DecoradorConRecuadro(
            new DecoradorPromocion(
                new DecoradorConLegajo(
                    new DecoradorNotaEnLetras(
                        new DecoradorConOrden(proxy, contador++)))));

            return (MiComparable)new AlumnoAdapter(decorado);
        }

        



        public override MiComparable crearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
