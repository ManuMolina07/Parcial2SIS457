using CadParcial2Mmc;
using ClnParcial2Mmc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpParcial2Mmc
{
    public partial class FrmHorarioPrograma : Form
    {
        private bool esNuevo;
        public FrmHorarioPrograma()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var HorarioProgramas = HorarioProgramaCln.listarPa(txtParametro.Text.Trim());
            dgvListaHorarios.DataSource = HorarioProgramas;

            dgvListaHorarios.Columns["id"].Visible = false;
            dgvListaHorarios.Columns["idCanal"].Visible = false;
            dgvListaHorarios.Columns["estado"].Visible = false;
            dgvListaHorarios.Columns["canal"].HeaderText = "Canal";
            dgvListaHorarios.Columns["titulo"].HeaderText = "Nombre Programa";
            dgvListaHorarios.Columns["horaInicio"].HeaderText = "Hora Inicio";
            dgvListaHorarios.Columns["horaFin"].HeaderText = "Hora Fin";
            dgvListaHorarios.Columns["diaSemana"].HeaderText = "Día de la Semana";
            dgvListaHorarios.Columns["conductorPrincipal"].HeaderText = "Conductor Principal";
            dgvListaHorarios.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            dgvListaHorarios.Columns["diaSemana"].HeaderText = "Día de la Semana";

            if (HorarioProgramas.Count > 0) dgvListaHorarios.CurrentCell = dgvListaHorarios.Rows[0].Cells["canal"];
            btnEditar.Enabled = HorarioProgramas.Count > 0;
            btnEliminar.Enabled = HorarioProgramas.Count > 0;

        }

        private void cargarCanal()
        {
            cbxCanal.DataSource = CanalCln.listar();
            cbxCanal.ValueMember = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = (short)Estado.Eliminado;
        }

        private void FrmHorarioPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(978, 403);
            listar();
            cargarCanal();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void resetearCampos()
        {
            cbxCanal.SelectedIndex = (short)Estado.Eliminado;
            txtPrograma.Clear();
            txtPrincipal.Clear();
            dtpHoraInicio.Value = DateTime.Today;
            dtpHoraFin.Value = DateTime.Today;
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpCanal.Clear();
            erpPrograma.Clear();
            erpPrincipal.Clear();
            erpHoraInicio.Clear();
            erpHoraFin.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(978, 569);
            pnlAcciones.Enabled = false;
            resetearCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(978, 569);
            pnlAcciones.Enabled = false;

            int id = (int)dgvListaHorarios.CurrentRow.Cells["id"].Value;
            var horarioPrograma = HorarioProgramaCln.obtenerUno(id);

            cbxCanal.SelectedValue = horarioPrograma.idCanal;
            txtPrograma.Text = horarioPrograma.titulo;
            dtpHoraInicio.Value = DateTime.Today.Add(horarioPrograma.horaInicio);
            dtpHoraFin.Value = DateTime.Today.Add(horarioPrograma.horaFin);
            txtDiaSemana.Text = horarioPrograma.diaSemana;
            txtPrincipal.Text = horarioPrograma.conductorPrincipal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(978, 403);
            pnlAcciones.Enabled = true;
        }

        private bool validarCampos()
        {
            bool esValido = true;
            resetearErrores();

            if(cbxCanal.SelectedIndex == (short)Estado.Eliminado)
            {
                erpCanal.SetError(cbxCanal, "El canal es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrograma.Text))
            {
                erpPrograma.SetError(txtPrograma, "El programa es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrincipal.Text))
            {
                erpPrincipal.SetError(txtPrincipal, "El conductor principal es obligatorio");
                esValido = false;
            }

            if(dtpHoraInicio.Value >= dtpHoraFin.Value)
            {
                erpHoraInicio.SetError(dtpHoraInicio, "La hora de inicio debe ser anterior a la hora de fin");
                esValido = false;
            }

            if(dtpHoraFin.Value <= dtpHoraInicio.Value)
            {
                erpHoraFin.SetError(dtpHoraFin, "La hora de fin debe ser posterior a la hora de inicio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var horarioPrograma = new HorarioPrograma
                {
                    idCanal = (int)cbxCanal.SelectedValue,
                    titulo = txtPrograma.Text.Trim(),
                    horaInicio = dtpHoraInicio.Value.TimeOfDay,
                    horaFin = dtpHoraFin.Value.TimeOfDay,
                    diaSemana = txtDiaSemana.Text.Trim(),
                    conductorPrincipal = txtPrincipal.Text.Trim(),
                    usuarioRegistro = "admin"
                };

                if (esNuevo)
                {
                    horarioPrograma.fechaRegistro = DateTime.Now;
                    horarioPrograma.estado = (short)Estado.Activo;

                    HorarioProgramaCln.crear(horarioPrograma);
                }
                else
                {
                    horarioPrograma.id = (int)dgvListaHorarios.CurrentRow.Cells["id"].Value;

                    HorarioProgramaCln.actualizar(horarioPrograma);
                }

                listar();
                btnCancelar.PerformClick();

                MessageBox.Show(
                    "Registro guardado correctamente",
                    "Gestión de Programas TV",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException?.InnerException?.Message
                    ?? ex.InnerException?.Message
                    ?? ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaHorarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un programa para eliminar");
                return;
            }

            int id = (int)dgvListaHorarios.CurrentRow.Cells["id"].Value;

            string titulo = dgvListaHorarios.CurrentRow.Cells["titulo"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar el programa {titulo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    HorarioProgramaCln.eliminar(id, "admin");

                    listar();

                    MessageBox.Show("Programa eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al eliminar");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}