using BcuApiDotNet.uy.gub.bcu.monedas;

namespace BcuApiDotNet.Monedas {
    public class DatoMoneda {
        private readonly wsmonedasoutLinea _wsbcu_dato;


        internal DatoMoneda(wsmonedasoutLinea dato) {
            _wsbcu_dato = dato;
        }


        public CodigoMoneda Moneda {
            get {
                return (CodigoMoneda)_wsbcu_dato.Codigo;
            }
        }
        public string Nombre {
            get {
                return _wsbcu_dato.Nombre;
            }
        }
    }
}
