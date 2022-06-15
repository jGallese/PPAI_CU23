using PPA_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CU_23.Datos
{
    public class BaseDatosSimulada
    {
        private IList<TipoRecurso> listTipoRecursos = new List<TipoRecurso>();


        public BaseDatosSimulada()
        {
            listTipoRecursos.Add(new("microscopio", "esto es un microscopio"));
            listTipoRecursos.Add(new("balanza", "esto es una balanza"));

        }
         
            
        public IList<TipoRecurso> GetAll()
        {
            return listTipoRecursos;
        }
    }
}
