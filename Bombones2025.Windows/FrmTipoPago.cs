using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bombones2025.Entidades.Entidades;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.Helpers;
using Bombones2025.Windows.Properties;

namespace Bombones2025.Windows
{
    public partial class FrmTipoPago : Form
    {
        private readonly FormaDePagoServicio _pagoServicio;

        private List<FormaDePago> listaPago = new();

        private bool filterOn = false;
        public FrmTipoPago(FormaDePagoServicio pagoservicio)
        {
            InitializeComponent();
            _pagoServicio = pagoservicio;
        }

        private void TsbNuevoPago_Click(object sender, EventArgs e)
        {
            FrmTipoPagoAE frm = new FrmTipoPagoAE() { Text = "Forma de pago" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            FormaDePago? formaDePago = frm.GetPago();
            if (formaDePago == null) return;
            try
            {
                if (!_pagoServicio.Existe(formaDePago))
                {
                    _pagoServicio.Guardar(formaDePago);
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosPago);
                    GridHelper.SetearFila(r, formaDePago);
                    GridHelper.AgregarFila(r, dgvDatosPago);
                    MessageBox.Show("Metodo de pago agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Pais existente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbBorrarPago_Click(object sender, EventArgs e)
        {
            if (dgvDatosPago.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosPago.SelectedRows[0];
            FormaDePago pagoBorrar = (FormaDePago)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar la siguiente forma de pago {pagoBorrar}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                _pagoServicio.Borrar(pagoBorrar.FormaDePagoId);
                GridHelper.QuitarFila(r, dgvDatosPago);
                MessageBox.Show("Método de pago eliminado correctamente");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TsbEditarPago_Click(object sender, EventArgs e)
        {
            if (dgvDatosPago.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosPago.SelectedRows[0];
            FormaDePago? formaDePago = (FormaDePago)r.Tag!;
            if (formaDePago == null) return;
            FormaDePago? pagoEditar = formaDePago.Clonar();
            FrmTipoPagoAE frm = new FrmTipoPagoAE() { Text = "Editar un Método de Pago" };
            frm.SetPago(pagoEditar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            pagoEditar = frm.GetPago();
            if (pagoEditar == null) return;
            try
            {
                if (!_pagoServicio.Existe(pagoEditar))
                {
                    _pagoServicio.Guardar(pagoEditar);
                    GridHelper.SetearFila(r, pagoEditar);

                    MessageBox.Show("Método de pago editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Método de pago existente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TsbFiltrarPago_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                FrmFiltro frm = new FrmFiltro() { Text = "Filtrar Metodos de Pago" };
                DialogResult dr = frm.ShowDialog(this);
                string? textoParaFiltrar = frm.GetTexto();
                if (textoParaFiltrar is null) return;
                try
                {
                    listaPago = _pagoServicio.Filtrar(textoParaFiltrar);
                    MostrarDatosEnGrilla();
                    TsbFiltrarPago.Image = Resources.filter_intense_40px;
                    filterOn = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Quitar el filtro!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                filterOn = false;
                TsbFiltrarPago.Image = Resources.filter_40px;
                listaPago = _pagoServicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTipoPago_Load(object sender, EventArgs e)
        {
            try
            {
                listaPago = _pagoServicio.GetLista();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosPago);
            foreach (FormaDePago formaDePago in listaPago)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosPago);
                GridHelper.SetearFila(r, formaDePago);
                GridHelper.AgregarFila(r, dgvDatosPago);
            }
        }

        private void TsbCerrarPago_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
