using BcuApiDotNet.uy.gub.bcu.cotizaciones;
using System;

namespace BcuApiDotNet.Cotizaciones {
    public class DatoCotizacion {
        private readonly datoscotizacionesdato _wsbcu_dato;


        internal DatoCotizacion(datoscotizacionesdato dato) {
            _wsbcu_dato = dato;
        }


        public double Arbitraje {
            get {
                return _wsbcu_dato.ArbAct;
            }
        }
        public string CodigoISO {
            get {
                return _wsbcu_dato.CodigoISO;
            }
        }
        public string Emisor {
            get {
                return _wsbcu_dato.Emisor;
            }
        }
        public DateTime? Fecha {
            get {
                return _wsbcu_dato.Fecha;
            }
        }
        public FormaArbitraje FormaArbitrar {
            get {
                return (FormaArbitraje)_wsbcu_dato.FormaArbitrar;
            }
        }
        public CodigoMoneda Moneda {
            get {
                return (CodigoMoneda)_wsbcu_dato.Moneda;
            }
        }
        public string Nombre {
            get {
                return _wsbcu_dato.Nombre;
            }
        }
        public double TipoCambioCompra {
            get {
                return _wsbcu_dato.TCC;
            }
        }
        public double TipoCambioVenta {
            get {
                return _wsbcu_dato.TCV;
            }
        }
    }
}
