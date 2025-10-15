using MetodologiasFix.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Otros
{
    public static class GeneradorDeDatos //--Ejercicio 2 (Práctica 3) (ya habia creado en clases anteriores esta clase, me parecía una buena idea)
    {
        private static Random random = new Random();


        public static IEstrategiaComparacion obtenerEstrategiaAleatoria()
        {
            int rand = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 5);
            switch (rand)
            {
                case 1:
                    {
                        IEstrategiaComparacion est = new CompararAlumnoDni();
                        return est;
                    }
                case 2:
                    {
                        IEstrategiaComparacion est = new CompararAlumnoNombre();
                        return est;
                    }
                case 3:
                    {
                        IEstrategiaComparacion est = new CompararAlumnoLegajo();
                        return est;
                    }
                case 4:
                    {
                        IEstrategiaComparacion est = new CompararAlumnoPromedio();
                        return est;
                    }
                default:
                    {
                        return null;
                    }

            }
        }
        public static int ObtenerEnteroAleatorio(int min, int max)
        {
            return random.Next(min, max);
        }

        public static bool ObtenerBooleanoAleatorio()
        {
            return random.Next(2) == 0;
        }

        public static string ObtenerNombreAleatorio()
        {
            List<string> nombres = new List<string>()
            {
                 "Juan", "Lucía", "Mia", "Maximo", "Valentina",
                "Mateo", "Sofía", "Tomás", "Emilia", "Benjamín", "Pedro", "Isabella", "Martina", "Luca", "Camila", "Santiago", "Victoria", "León", "Catalina", "Diego"
            };

            string nombre = nombres[random.Next(nombres.Count)];
            return nombre;

        }
    }
}
