using PPA_Integrador.Entidades;
using PPAI_CU23.Negocio.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_23
{
    public partial class RegistrarReservaTurno : Form
    {
        private TipoRecursoService service;
       
        public RegistrarReservaTurno()
        {
            InitializeComponent();
            service = new TipoRecursoService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_TiposRecursos.Rows.Clear();
            IList<TipoRecurso> listaTiposRecursos = service.GetAll();
            foreach (TipoRecurso tro in listaTiposRecursos)
            {
                dgv_TiposRecursos.Rows.Add(new string[] { tro.Nombre, tro.Descripcion });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TipoRecurso trSeleccionado = dgv_TiposRecursos.Rows;
        }
    }
}
