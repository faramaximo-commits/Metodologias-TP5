using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Iteradores
{
    public interface IIterador
    {
        void primero();
        void siguiente();
        bool fin();
        MiComparable actual();

    }
}
