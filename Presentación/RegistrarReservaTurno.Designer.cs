
namespace CU_23
{
    partial class RegistrarReservaTurno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_reservarTurno = new System.Windows.Forms.Button();
            this.dgv_TiposRecursos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTipoRecurso = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiposRecursos)).BeginInit();
            this.panelTipoRecurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reservarTurno
            // 
            this.btn_reservarTurno.Location = new System.Drawing.Point(766, 45);
            this.btn_reservarTurno.Name = "btn_reservarTurno";
            this.btn_reservarTurno.Size = new System.Drawing.Size(222, 85);
            this.btn_reservarTurno.TabIndex = 0;
            this.btn_reservarTurno.Text = "Reservar Turno";
            this.btn_reservarTurno.UseVisualStyleBackColor = true;
            this.btn_reservarTurno.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_TiposRecursos
            // 
            this.dgv_TiposRecursos.AllowUserToAddRows = false;
            this.dgv_TiposRecursos.AllowUserToDeleteRows = false;
            this.dgv_TiposRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TiposRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion});
            this.dgv_TiposRecursos.Location = new System.Drawing.Point(75, 45);
            this.dgv_TiposRecursos.Name = "dgv_TiposRecursos";
            this.dgv_TiposRecursos.ReadOnly = true;
            this.dgv_TiposRecursos.RowHeadersWidth = 62;
            this.dgv_TiposRecursos.RowTemplate.Height = 33;
            this.dgv_TiposRecursos.Size = new System.Drawing.Size(465, 324);
            this.dgv_TiposRecursos.TabIndex = 1;
            this.dgv_TiposRecursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // panelTipoRecurso
            // 
            this.panelTipoRecurso.Controls.Add(this.btn_reservarTurno);
            this.panelTipoRecurso.Controls.Add(this.dgv_TiposRecursos);
            this.panelTipoRecurso.Location = new System.Drawing.Point(325, 102);
            this.panelTipoRecurso.Name = "panelTipoRecurso";
            this.panelTipoRecurso.Size = new System.Drawing.Size(1233, 399);
            this.panelTipoRecurso.TabIndex = 2;
            // 
            // RegistrarReservaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1179);
            this.Controls.Add(this.panelTipoRecurso);
            this.Name = "RegistrarReservaTurno";
            this.Text = "RegistraReservaTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiposRecursos)).EndInit();
            this.panelTipoRecurso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_reservarTurno;
        private DataGridView dgv_TiposRecursos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private Panel panelTipoRecurso;
    }
}

