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

namespace Bombones2025.Windows
{
    public partial class FrmTipoPagoAE : Form
    {
        private FormaDePago? formaDePago;
        public FrmTipoPagoAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (formaDePago is not null)
            {
                TxtPagoAE.Text = formaDePago.Descripcion;
            }
        }

        public FormaDePago? GetPago()
        {
            return formaDePago;
        }

        public void SetPago(FormaDePago formaDePago)
        {
            this.formaDePago = formaDePago;
        }

        private void BtnOKPagoAE_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (formaDePago is null)
                {
                    formaDePago = new FormaDePago();

                }
                formaDePago.Descripcion = TxtPagoAE.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtPagoAE.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtPagoAE, "El nombre es requerido");

            }
            return valido;
        }

        private void BtnCancelarPagoAE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
