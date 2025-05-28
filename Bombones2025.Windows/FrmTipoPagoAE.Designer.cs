namespace Bombones2025.Windows
{
    partial class FrmTipoPagoAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BtnCancelarPagoAE = new Button();
            BtnOKPagoAE = new Button();
            TxtPagoAE = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnCancelarPagoAE
            // 
            BtnCancelarPagoAE.Image = Properties.Resources.Cancelar;
            BtnCancelarPagoAE.Location = new Point(373, 71);
            BtnCancelarPagoAE.Name = "BtnCancelarPagoAE";
            BtnCancelarPagoAE.Size = new Size(75, 52);
            BtnCancelarPagoAE.TabIndex = 11;
            BtnCancelarPagoAE.Text = "Cancelar";
            BtnCancelarPagoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelarPagoAE.UseVisualStyleBackColor = true;
            BtnCancelarPagoAE.Click += BtnCancelarPagoAE_Click;
            // 
            // BtnOKPagoAE
            // 
            BtnOKPagoAE.Image = Properties.Resources.Aceptar1;
            BtnOKPagoAE.Location = new Point(135, 71);
            BtnOKPagoAE.Name = "BtnOKPagoAE";
            BtnOKPagoAE.Size = new Size(75, 52);
            BtnOKPagoAE.TabIndex = 12;
            BtnOKPagoAE.Text = "OK";
            BtnOKPagoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOKPagoAE.UseVisualStyleBackColor = true;
            BtnOKPagoAE.Click += BtnOKPagoAE_Click;
            // 
            // TxtPagoAE
            // 
            TxtPagoAE.Location = new Point(135, 32);
            TxtPagoAE.MaxLength = 200;
            TxtPagoAE.Name = "TxtPagoAE";
            TxtPagoAE.Size = new Size(313, 23);
            TxtPagoAE.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 9;
            label1.Text = "Tipo de pago:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmTipoPagoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 159);
            Controls.Add(BtnCancelarPagoAE);
            Controls.Add(BtnOKPagoAE);
            Controls.Add(TxtPagoAE);
            Controls.Add(label1);
            MaximumSize = new Size(540, 198);
            MinimumSize = new Size(540, 198);
            Name = "FrmTipoPagoAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTipoPagoAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelarPagoAE;
        private Button BtnOKPagoAE;
        private TextBox TxtPagoAE;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}