using BcuApiDotNet.uy.gub.bcu.ultimocierre;
using System;

namespace BcuApiDotNet.UltimoCierre {
    public class ResultadoConsultaUltimoCierre {
        private readonly wsultimocierreout _wsbcu_out;


        internal ResultadoConsultaUltimoCierre(wsultimocierreout wsbcu_out) {
            _wsbcu_out = wsbcu_out;
        }


        public DateTime? Fecha {
            get {
                return _wsbcu_out.Fecha;
            }
        }
    }
}
