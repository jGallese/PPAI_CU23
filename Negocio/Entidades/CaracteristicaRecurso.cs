namespace PPA_Integrador.Entidades
{
    public class CaracteristicaRecurso
    {
        public string valor { get; set; }
        public Caracteristica caracteristica { get; set; }

        public string mostrarCaracteristicaRecurso()
        {
            return this.caracteristica.ToString() + " " + this.valor;

        }
    }
}