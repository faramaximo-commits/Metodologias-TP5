using MetodologiasFix.Estrategias;
using MetodologiasFix.Fabricas;
using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Proxy
{
    public class ProxyAlumno : Alumno //Ejercicio 1 (Práctica 5) Implemente el patron Proxy para cualquier Alumno, el proxy debe crear al alumnoreal (Normal o Muy Estudioso) al momento de responder la pregunta (responderPregunta(pregunta))
    {
        private IAlumno alumnoReal;
        private bool esMuyEstudioso;

        public ProxyAlumno(string n, int d, int l, int p, int c, IEstrategiaComparacion e, bool es) : base(n, d, l, p, c, e)
        {
            this.esMuyEstudioso = es;
            

        }

        public override int responderPregunta(int pregunta)
        {
            if (esMuyEstudioso)
            {
                FabricaDeAlumnosMuyEstudiosos fabrica = new FabricaDeAlumnosMuyEstudiosos();
                alumnoReal = (AlumnoMuyEstudioso)fabrica.crearAleatorio();

            }
            else
            {
                FabricaDeAlumnosNormales fabric = new FabricaDeAlumnosNormales();
                alumnoReal = (AlumnoNormal)fabric.crearAleatorio();
            }

            if (alumnoReal != null)
            {
                return alumnoReal.responderPregunta(pregunta);
            }
            return 0;
        }
    }
}
