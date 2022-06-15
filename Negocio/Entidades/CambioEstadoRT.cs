using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_Integrador.Entidades
{
    internal class CambioEstadoRT
    {
        public DateTime fechaHoraDesde { get; set; }
        public DateTime fechaHoraHasta { get; set; }
        public Estado estado { get; set; }
    }
}
