using CU_23.Datos;
using PPA_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU23.Negocio.Servicio
{
    public class TipoRecursoService
    {
        private BaseDatosSimulada baseDatos = new BaseDatosSimulada();
        public IList<TipoRecurso> GetAll()
        {
            return baseDatos.GetAll();   
            
        }
    }
}
