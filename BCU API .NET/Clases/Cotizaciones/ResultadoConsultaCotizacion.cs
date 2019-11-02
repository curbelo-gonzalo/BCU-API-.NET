using BcuApiDotNet.uy.gub.bcu.cotizaciones;
using System.Collections.Generic;
using System.Linq;

namespace BcuApiDotNet.Cotizaciones {
    public class ResultadoConsultaCotizacion {
        private readonly wsbcucotizacionesout _wsbcu_out;


        internal ResultadoConsultaCotizacion(wsbcucotizacionesout wsbcu_out) {
            _wsbcu_out = wsbcu_out;
        }


        public List<DatoCotizacion> Cotizaciones {
            get {
                return _wsbcu_out
                    .datoscotizaciones
                    .Select(item => new DatoCotizacion(item))
                    .ToList();
            }
        }
        public RespuestaEstado Status {
            get {
                return new RespuestaEstado(_wsbcu_out.respuestastatus);
            }
        }
    }
}
