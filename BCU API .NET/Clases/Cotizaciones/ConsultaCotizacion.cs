using BcuApiDotNet.uy.gub.bcu.cotizaciones;
using System;

namespace BcuApiDotNet.Cotizaciones {
    public class ConsultaCotizacion: IDisposable {
        private readonly wsbcucotizaciones _wsbcu_cotiza = new wsbcucotizaciones();


        public string URL {
            get {
                return _wsbcu_cotiza.Url;
            }
            set {
                _wsbcu_cotiza.Url = value;
            }
        }
        public bool UseDefaultCredentials {
            get {
                return _wsbcu_cotiza.UseDefaultCredentials;
            }
            set {
                _wsbcu_cotiza.UseDefaultCredentials = value;
            }
        }


        public void Dispose() {
            _wsbcu_cotiza.Dispose();
        }


        public ResultadoConsultaCotizacion Execute(OpcionesConsultaCotizacion entrada) {
            if(entrada is null) {
                throw new ArgumentNullException(nameof(entrada));
            }
            return new ResultadoConsultaCotizacion(_wsbcu_cotiza.Execute(entrada._wsbcu_in));
        }

        //public void ExecuteAsync(OpcionesConsultaCotizacion entrada) {
        //    if(entrada is null) {
        //        throw new ArgumentNullException(nameof(entrada));
        //    }
        //    _wsbcu_cotiza.ExecuteAsync(entrada._wsbcu_in);
        //}
        //public void ExecuteAsync(OpcionesConsultaCotizacion entrada, object userState) {
        //    if(entrada is null) {
        //        throw new ArgumentNullException(nameof(entrada));
        //    }
        //    _wsbcu_cotiza.ExecuteAsync(entrada._wsbcu_in, userState);
        //}
    }
}
