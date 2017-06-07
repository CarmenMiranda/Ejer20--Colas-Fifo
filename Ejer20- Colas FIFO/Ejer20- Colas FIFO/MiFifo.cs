using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer20__Colas_FIFO
{
    class MiFifo
    {
        public Proceso _inicio;
        public Proceso _fin;
        public bool primerProceso = false;

        public MiFifo()
        {
            _inicio = null;
            _fin = null;
        }

        public void meterProceso(Proceso nuevo)
        {
            if (_inicio == null){
                _inicio = nuevo;
                primerProceso = true;
            }
            else{
                _fin.procesoSiguiente = nuevo;
                primerProceso = false;
            }
            _fin = nuevo;
        }

        public void sacarProceso() {
                _inicio = _inicio.procesoSiguiente;
        }

        public Proceso verProceso() {
            return _inicio;
        }


    }
}
