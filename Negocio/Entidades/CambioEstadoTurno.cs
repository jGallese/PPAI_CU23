namespace PPA_Integrador.Entidades
{
    public class CambioEstadoTurno
    {
        public DateTime fechaHoraDesde{ get; set; }
        public DateTime fechaHoraHasta { get; set; }
        public Estado estado{ get; set; }
    }
}