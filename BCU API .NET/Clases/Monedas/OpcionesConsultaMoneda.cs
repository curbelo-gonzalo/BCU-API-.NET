namespace BcuApiDotNet.Monedas {
    public class OpcionesConsultaMoneda {
        public OpcionesConsultaMoneda() { }
        public OpcionesConsultaMoneda(GrupoMoneda grupo) {
            this.Grupo = grupo;
        }


        public GrupoMoneda Grupo { get; set; }
    }
}
