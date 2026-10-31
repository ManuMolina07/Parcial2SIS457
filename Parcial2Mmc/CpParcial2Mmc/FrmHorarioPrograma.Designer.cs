namespace CpParcial2Mmc
{
    partial class FrmHorarioPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarioPrograma));
            this.dgvListaHorarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpCanal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrograma = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrincipal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraFin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHorarios)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaHorarios
            // 
            this.dgvListaHorarios.AllowUserToAddRows = false;
            this.dgvListaHorarios.AllowUserToDeleteRows = false;
            this.dgvListaHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaHorarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListaHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHorarios.Location = new System.Drawing.Point(18, 32);
            this.dgvListaHorarios.MultiSelect = false;
            this.dgvListaHorarios.Name = "dgvListaHorarios";
            this.dgvListaHorarios.ReadOnly = true;
            this.dgvListaHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaHorarios.Size = new System.Drawing.Size(776, 209);
            this.dgvListaHorarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(938, 43);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Programas TV";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParametro.Location = new System.Drawing.Point(41, 73);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(290, 20);
            this.lblParametro.TabIndex = 2;
            this.lblParametro.Text = "Buscar por programa, canal, día u hora: ";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(327, 71);
            this.txtParametro.MaxLength = 50;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(470, 24);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvListaHorarios);
            this.gbxLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxLista.Location = new System.Drawing.Point(12, 110);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(817, 252);
            this.gbxLista.TabIndex = 5;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Programas";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Location = new System.Drawing.Point(844, 119);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(106, 176);
            this.pnlAcciones.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpParcial2Mmc.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2Mmc.Properties.Resources.aplicacion;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 41);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpParcial2Mmc.Properties.Resources.lapiz;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(3, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 41);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtDiaSemana);
            this.gbxDatos.Controls.Add(this.lblDiaSemana);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.dtpHoraFin);
            this.gbxDatos.Controls.Add(this.dtpHoraInicio);
            this.gbxDatos.Controls.Add(this.txtPrincipal);
            this.gbxDatos.Controls.Add(this.txtPrograma);
            this.gbxDatos.Controls.Add(this.cbxCanal);
            this.gbxDatos.Controls.Add(this.lblPrincipal);
            this.gbxDatos.Controls.Add(this.lblFin);
            this.gbxDatos.Controls.Add(this.lblinicio);
            this.gbxDatos.Controls.Add(this.lblPrograma);
            this.gbxDatos.Controls.Add(this.lblCanal);
            this.gbxDatos.Location = new System.Drawing.Point(20, 369);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(809, 149);
            this.gbxDatos.TabIndex = 11;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            this.gbxDatos.UseCompatibleTextRendering = true;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(159, 114);
            this.txtDiaSemana.MaxLength = 100;
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(224, 24);
            this.txtDiaSemana.TabIndex = 20;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(10, 114);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(109, 18);
            this.lblDiaSemana.TabIndex = 19;
            this.lblDiaSemana.Text = "Día de Semana";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpParcial2Mmc.Properties.Resources.guardar_el_archivo;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(587, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 38);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CpParcial2Mmc.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(698, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 38);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(577, 51);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(200, 24);
            this.dtpHoraFin.TabIndex = 16;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(577, 15);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 24);
            this.dtpHoraInicio.TabIndex = 15;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(158, 81);
            this.txtPrincipal.MaxLength = 100;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(224, 24);
            this.txtPrincipal.TabIndex = 14;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(159, 48);
            this.txtPrograma.MaxLength = 100;
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(224, 24);
            this.txtPrograma.TabIndex = 13;
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.FormattingEnabled = true;
            this.cbxCanal.Location = new System.Drawing.Point(158, 12);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(225, 26);
            this.cbxCanal.TabIndex = 12;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(10, 84);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(142, 18);
            this.lblPrincipal.TabIndex = 4;
            this.lblPrincipal.Text = "Conductor Principal:";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(460, 57);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(64, 18);
            this.lblFin.TabIndex = 3;
            this.lblFin.Text = "Hora fin:";
            this.lblFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Location = new System.Drawing.Point(460, 20);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(83, 18);
            this.lblinicio.TabIndex = 2;
            this.lblinicio.Text = "Hora inicio:";
            this.lblinicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(10, 54);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(78, 18);
            this.lblPrograma.TabIndex = 1;
            this.lblPrograma.Text = "Programa:";
            this.lblPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(10, 20);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(50, 18);
            this.lblCanal.TabIndex = 0;
            this.lblCanal.Text = "Canal:";
            // 
            // button1
            // 
            this.button1.Image = global::CpParcial2Mmc.Properties.Resources.cerrar_sesion;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(879, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2Mmc.Properties.Resources.buscar__1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(812, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 41);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpCanal
            // 
            this.erpCanal.ContainerControl = this;
            // 
            // erpPrograma
            // 
            this.erpPrograma.ContainerControl = this;
            // 
            // erpPrincipal
            // 
            this.erpPrincipal.ContainerControl = this;
            // 
            // erpHoraInicio
            // 
            this.erpHoraInicio.ContainerControl = this;
            // 
            // erpHoraFin
            // 
            this.erpHoraFin.ContainerControl = this;
            // 
            // FrmHorarioPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(962, 530);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHorarioPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Gestión de Programas TV - Parcial2SIS457 :::";
            this.Load += new System.EventHandler(this.FrmHorarioPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHorarios)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaHorarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider erpCanal;
        private System.Windows.Forms.ErrorProvider erpPrograma;
        private System.Windows.Forms.ErrorProvider erpPrincipal;
        private System.Windows.Forms.ErrorProvider erpHoraInicio;
        private System.Windows.Forms.ErrorProvider erpHoraFin;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.TextBox txtDiaSemana;
    }
}

