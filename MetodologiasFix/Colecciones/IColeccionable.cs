using MetodologiasFix.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = MetodologiasFix.Objetos.IComparable;

namespace MetodologiasFix.Colecciones
{
    public interface IColeccionable
    {
        int cuantos();

        MiComparable minimo();

        MiComparable maximo();

        void agregar(MiComparable i);

        bool contiene(MiComparable i);
    }
}
