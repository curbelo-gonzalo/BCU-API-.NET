using BcuApiDotNet.uy.gub.bcu.monedas;

namespace BcuApiDotNet.Monedas {
    public class OpcionesConsultaMoneda {
        internal readonly wsmonedasin _wsbcu_in = new wsmonedasin();


        public OpcionesConsultaMoneda() { }
        public OpcionesConsultaMoneda(GrupoMoneda grupo) {
            this.Grupo = grupo;
        }


        public GrupoMoneda Grupo {
            get {
                return (GrupoMoneda)_wsbcu_in.Grupo;
            }
            set {
                _wsbcu_in.Grupo = (sbyte)value;
            }
        }
    }
}
