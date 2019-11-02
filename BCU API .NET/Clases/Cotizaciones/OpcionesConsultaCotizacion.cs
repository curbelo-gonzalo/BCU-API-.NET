using BcuApiDotNet.uy.gub.bcu.cotizaciones;
using System;
using System.Linq;

namespace BcuApiDotNet.Cotizaciones {
    public class OpcionesConsultaCotizacion {
        private readonly wsbcucotizacionesin _wsbcu_in = new wsbcucotizacionesin();


        public OpcionesConsultaCotizacion() { }
        public OpcionesConsultaCotizacion(CodigoMoneda[] monedas, DateTime fechaDesde, DateTime fechaHasta, GrupoMoneda grupo) {
            this.Monedas = monedas;
            this.FechaDesde = fechaDesde;
            this.FechaHasta = fechaHasta;
            this.Grupo = grupo;
        }


        public DateTime? FechaDesde {
            get {
                return _wsbcu_in.FechaDesde;
            }
            set {
                _wsbcu_in.FechaDesde = value;
            }
        }
        public DateTime? FechaHasta {
            get {
                return _wsbcu_in.FechaHasta;
            }
            set {
                _wsbcu_in.FechaHasta = value;
            }
        }
        public GrupoMoneda Grupo {
            get {
                return (GrupoMoneda)_wsbcu_in.Grupo;
            }
            set {
                _wsbcu_in.Grupo = (sbyte)value;
            }
        }
        public CodigoMoneda[] Monedas {
            get {
                return _wsbcu_in.Moneda.Cast<CodigoMoneda>().ToArray();
            }
            set {
                _wsbcu_in.Moneda = value.Cast<short>().ToArray();
            }
        }
    }
}
