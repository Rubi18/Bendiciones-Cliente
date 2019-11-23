using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bendiciones
{
    public enum Estado
    {
        Inicial,Nuevo,Buscar,Modificar, Cliente,Clase,Docente,Pago
    }

    public class Margenes {

        int margenTituloForm = 40;
        int margenPequeño = 20;

        public int MargenTituloForm { get => margenTituloForm; set => margenTituloForm = value; }
        public int MargenPequeño { get => margenPequeño; set => margenPequeño = value; }
    }

    
}
