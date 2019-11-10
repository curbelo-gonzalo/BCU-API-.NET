using BcuApiDotNet.uy.gub.bcu.ultimocierre;
using System;

namespace BcuApiDotNet.UltimoCierre {
    public class ConsultaUltimoCierre: IDisposable {
        private readonly wsultimocierre _wsbcu_ulci = new wsultimocierre();


        public string URL {
            get {
                return _wsbcu_ulci.Url;
            }
            set {
                _wsbcu_ulci.Url = value;
            }
        }
        public bool UseDefaultCredentials {
            get {
                return _wsbcu_ulci.UseDefaultCredentials;
            }
            set {
                _wsbcu_ulci.UseDefaultCredentials = value;
            }
        }


        public void Dispose() {
            _wsbcu_ulci.Dispose();
        }


        public ResultadoConsultaUltimoCierre Execute() {
            return new ResultadoConsultaUltimoCierre(_wsbcu_ulci.Execute());
        }
    }
}
