using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer20__Colas_FIFO
{
    class Procesador
    {
        MiFifo miFifo = new MiFifo();
        static Random aleatorio = new Random(DateTime.Now.Millisecond);

        private int _procesosPendientes;
        public int procesosPendientes { get { return _procesosPendientes; } }

        private int _sumaCiclosPendientes;
        public int sumaCiclosPendientes { get { return _sumaCiclosPendientes; } }

        private int _colaVacía;
        public int colaVacía { get { return _colaVacía; } }

        public Procesador() {
            _procesosPendientes = 0;
            _sumaCiclosPendientes = 0;
            _colaVacía = 0;
        }

        private int generadorDeProbabilidad()
        {
            return aleatorio.Next(1, 5); //1=proceso nuevo. 2,3,4=Ningún proceso.
        }

        public void atencion() {
            for (int i = 0; i < 200; i++)
            {
                if (generadorDeProbabilidad() == 1){
                    Proceso nuevo = new Proceso();
                    miFifo.meterProceso(nuevo);
                    _procesosPendientes++;
                }
                else {
                    if (miFifo._inicio == null)
                        _colaVacía++;
                    miFifo.primerProceso = false;
                }

                if (miFifo._inicio != null) {
                    if (miFifo.primerProceso == false)
                        atenderProceso();
                }  
            }
            obtenerSumaDeCiclosPendientes();
        }

        private void atenderProceso() {
            if (miFifo._inicio != null) {
                if (miFifo._inicio.cicloAleatorio != 0)
                    miFifo._inicio.cicloAleatorio--;

                if (miFifo._inicio.cicloAleatorio == 0) {
                    _procesosPendientes--;
                    miFifo._inicio = miFifo._inicio.procesoSiguiente;
                }
            }
        }

        private void obtenerSumaDeCiclosPendientes() {
            if (procesosPendientes != 0) {
                Proceso actual = miFifo._inicio;
                while (actual != null) {
                    _sumaCiclosPendientes += actual.cicloAleatorio;
                    actual = actual.procesoSiguiente;
                }
            }
        }

    }
}
