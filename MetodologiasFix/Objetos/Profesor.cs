using MetodologiasFix.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Objetos
{
    public class Profesor : Persona, IObservado
    {
        private int antiguedad;
        private List<IObservador> observadores = new List<IObservador>();
        private bool estaHablando;
        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
        }

        public bool getEstado()
        {
            return this.estaHablando;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public void hablarALaClase()
        {
            estaHablando = true;
            Console.WriteLine("Hablando de algun tema...");
            notificar();
        }

        public void escribirEnElPizarron()
        {
            estaHablando = false;
            Console.WriteLine("Escribiendo en el pizarrón...");
            notificar();
        }

        public void agregarObservador(IObservador o)
        {
            this.observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            this.observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (var o in observadores)
            {
                o.Actualizar(this);
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}, antiguedad: {antiguedad}";
        }

        public override bool SosIgual(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad == comparado.getAntiguedad();
        }

        public override bool SosMayor(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad > comparado.getAntiguedad();
        }

        public override bool SosMenor(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad < comparado.getAntiguedad();
        }

        
    }
}
