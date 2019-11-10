using BcuApiDotNet.uy.gub.bcu.monedas;
using System;

namespace BcuApiDotNet.Monedas {
    public class ConsultaMoneda: IDisposable {
        private readonly wsbcumonedas _wsbcu_mone = new wsbcumonedas();


        public string URL {
            get {
                return _wsbcu_mone.Url;
            }
            set {
                _wsbcu_mone.Url = value;
            }
        }
        public bool UseDefaultCredentials {
            get {
                return _wsbcu_mone.UseDefaultCredentials;
            }
            set {
                _wsbcu_mone.UseDefaultCredentials = value;
            }
        }


        public void Dispose() {
            _wsbcu_mone.Dispose();
        }


        public ResultadoConsultaMoneda Execute(OpcionesConsultaMoneda entrada) {
            if(entrada is null) {
                throw new ArgumentNullException(nameof(entrada));
            }
            return new ResultadoConsultaMoneda(_wsbcu_mone.Execute(entrada._wsbcu_in));
        }
    }
}
