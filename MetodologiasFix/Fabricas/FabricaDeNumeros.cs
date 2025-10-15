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
    internal class FabricaDeNumeros : FabricaDeComparables //Ejercicio 5 (Práctica 3) Implemente las fábricas concretas FabricaDeNumeros y FabricaDeAlumnos
    {
        public override MiComparable crearAleatorio()
        {
            int valor = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10000000);
            MiComparable c = new Numero(valor);
            return c;

        }

        public override MiComparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            int valor = lector.numeroPorTeclado();
            MiComparable c = new Numero(valor);
            return c;
        }


    }
}
