using BcuApiDotNet.uy.gub.bcu.monedas;
using System.Collections.Generic;
using System.Linq;

namespace BcuApiDotNet.Monedas {
    public class ResultadoConsultaMoneda {
        private readonly wsmonedasoutLinea[] _wsbcu_out;


        internal ResultadoConsultaMoneda(wsmonedasoutLinea[] wsbcu_out) {
            _wsbcu_out = wsbcu_out;
        }


        public List<DatoMoneda> Monedas {
            get {
                return _wsbcu_out
                    .Select(item => new DatoMoneda(item))
                    .ToList();
            }
        }
    }
}
