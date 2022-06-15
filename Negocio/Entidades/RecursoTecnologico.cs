using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_Integrador.Entidades
{
    internal class RecursoTecnologico
    {
        //Propiedades
        public int numeroRT { get; set; }
        public DateTime fechaAlta { get; set; }
        public Image imagenes { get; set; }
        public DateTime periodicidadMantenimientoPrev { get; set; }
        public DateTime duracionMantPrev { get; set; }
        public TimeOnly fraccionHorariaTurno { get; set; }

        public TipoRecurso tipoRecurso { get; set; }

        public Modelo modeloRT { get; set; }
        public List<Mantenimiento> mantenimientos { get; set; }

        public List<Turno> turnos { get; set; }
        public List<CambioEstadoRT> cambioEstadosRT { get; set; }

        //Constructor

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, Image imagenes, DateTime periodicidadMantenimientoPrev, DateTime duracionMantPrev, TimeOnly fraccionHorariaTurno, TipoRecurso tipoRecurso, Modelo modeloRT)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantPrev = duracionMantPrev;
            this.fraccionHorariaTurno = fraccionHorariaTurno;
            this.tipoRecurso = tipoRecurso;
            this.modeloRT = modeloRT;
            this.mantenimientos = new List<Mantenimiento>();
            this.turnos = new List<Turno>();
            this.cambioEstadosRT = new List<CambioEstadoRT>();

        }

        //Metodos


    }

    
}
