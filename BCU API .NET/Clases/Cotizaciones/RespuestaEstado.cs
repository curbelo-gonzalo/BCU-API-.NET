using BcuApiDotNet.uy.gub.bcu.cotizaciones;

namespace BcuApiDotNet {
    public class RespuestaEstado {
        private readonly respuestastatus _wsbcu_rs;


        internal RespuestaEstado(respuestastatus rs) {
            _wsbcu_rs = rs;
        }


        public CodigoError Codigo {
            get {
                return (CodigoError)_wsbcu_rs.codigoerror;
            }
        }
        public string Mensaje {
            get {
                return _wsbcu_rs.mensaje;
            }
        }
        public EstadoRespuesta Status {
            get {
                return (EstadoRespuesta)_wsbcu_rs.status;
            }
        }
    }
}
