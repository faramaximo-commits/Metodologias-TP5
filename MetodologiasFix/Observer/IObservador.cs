using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasFix.Observer
{
    public interface IObservador 
    {
        void Actualizar(IObservado o);
    }
}
