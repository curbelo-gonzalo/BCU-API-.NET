using BcuApiDotNet.uy.gub.bcu.cotizaciones;

namespace BcuApiDotNet {
    public class RespuestaEstado {
        public readonly CodigoError Codigo;
        public readonly EstadoRespuesta Status;
        public readonly string Mensaje;

        internal RespuestaEstado(respuestastatus rs)
            : this((EstadoRespuesta)rs.status, (CodigoError)rs.codigoerror, rs.mensaje) { }
        public RespuestaEstado(EstadoRespuesta status, CodigoError codigo, string mensaje) {
            this.Status = status;
            this.Codigo = codigo;
            this.Mensaje = mensaje;
        }
    }
}
