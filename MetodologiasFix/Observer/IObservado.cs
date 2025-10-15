using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Observer
{
    public interface IObservado
    {
        public void agregarObservador(IObservador obs);
        public void quitarObservador(IObservador obs);
        public void notificar();
    }
}
